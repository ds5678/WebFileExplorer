using HtmlSharp;

namespace WebFileExplorer;

public class IndexPage : DefaultPage
{
	public static IndexPage Instance { get; } = new();

	public override string? GetTitle() => "Web File Explorer";

	public override void WriteInnerContent(TextWriter writer)
	{
		using (new Div(writer).WithClass("text-center").End())
		{
			using (new H1(writer).WithClass("display-4").End())
			{
				writer.Write("Welcome");
			}
			using (new A(writer).WithClass("btn btn-success").WithHref("/directory").End())
			{
				writer.Write("View Files");
			}
		}
	}
}
