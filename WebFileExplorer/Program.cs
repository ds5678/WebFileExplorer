namespace WebFileExplorer;
public static class Program
{
	private const string CorsPolicyName = "AllowAnyOrigin";

	public static void Main(string[] args)
	{
		WebApplicationBuilder builder = WebApplication.CreateSlimBuilder(args);

		builder.Services.ConfigureHttpJsonOptions(options =>
		{
			options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
		});
		builder.Services.AddCors(options =>
		{
			options.AddPolicy(CorsPolicyName,
				builder => builder
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader());
		});

		WebApplication app = builder.Build();

		//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0#middleware-order

		app.UseStaticFiles();

		app.UseCors(CorsPolicyName);

		app.MapGet("/fibonacci", () => new FibonacciPage(10).ToResult());
		app.MapGet("/fibonacci/{count}", (int count) =>
		{
			return count switch
			{
				> 0 => new FibonacciPage(count).ToResult(),
				_ => Results.NotFound()
			};
		});

		app.MapGet("/", () => IndexPage.Instance.ToResult());

		app.MapGet("/download/{path}", LoadFile);

		app.MapGet("/files/{path}", ListFiles);

		app.MapGet("/directories/{path}", ListDirectories);

		app.MapGet("/directory/", () => new DirectoryPage(AppContext.BaseDirectory).ToResult());

		app.MapGet("/directory/{path}", (string path) =>
		{
			if (Directory.Exists(path))
			{
				return new DirectoryPage(path).ToResult();
			}
			else
			{
				return Results.NotFound();
			}
		});

		app.MapGet("/version", () => typeof(Program).Assembly.GetName().Version);

		app.MapPost("/log/write/{content}", (string content) => Console.WriteLine(content));

		Todo[] sampleTodos = [
			new(1, "Walk the dog"),
			new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
			new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
			new(4, "Clean the bathroom"),
			new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
		];

		RouteGroupBuilder todosApi = app.MapGroup("/todos");
		todosApi.MapGet("/", () => sampleTodos);
		todosApi.MapGet("/{id}", (int id) =>
			sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
				? Results.Ok(todo)
				: Results.NotFound());

		app.Run();
	}

	private static IResult LoadFile(string path)
	{
		try
		{
			if (File.Exists(path))
			{
				return Results.File(path, "application/octet-stream", Path.GetFileName(path));
			}
			else
			{
				return Results.NotFound(path);
			}
		}
		catch (Exception ex)
		{
			// Log or handle the exception
			return Results.Problem($"Error: {ex.Message}");
		}
	}

	private static IResult ListFiles(string path)
	{
		if (Directory.Exists(path))
		{
			return Results.Ok(Directory.GetFiles(path));
		}
		else
		{
			return Results.NotFound(path);
		}
	}

	private static IResult ListDirectories(string path)
	{
		if (Directory.Exists(path))
		{
			return Results.Ok(Directory.GetDirectories(path));
		}
		else
		{
			return Results.NotFound(path);
		}
	}
}
