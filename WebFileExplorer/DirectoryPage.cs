using HtmlSharp;
using System.Net;

namespace WebFileExplorer;

public class DirectoryPage : DefaultPage
{
	private DirectoryInfo CurrentDirectory { get; }
	private FileInfo[] Files => CurrentDirectory.GetFiles();
	private DirectoryInfo[] Directories => CurrentDirectory.GetDirectories();

	public DirectoryPage(string directory)
	{
		CurrentDirectory = new DirectoryInfo(directory);
	}

	public override string? GetTitle() => CurrentDirectory.Name;

	public override void WriteInnerContent(TextWriter writer)
	{
		using (new H1(writer).End())
		{
			writer.Write(CurrentDirectory.Name);
		}
		using (new P(writer).End())
		{
			writer.Write("Full Name: ");
			writer.Write(CurrentDirectory.FullName);
		}
		DirectoryInfo? parent = CurrentDirectory.Parent;
		if (parent is not null)
		{
			using (new P(writer).End())
			{
				using (new A(writer).WithClass("btn btn-primary").WithHref($"/directory/{WebUtility.UrlEncode(parent.FullName)}").End())
				{
					writer.Write("View Parent Directory");
				}
			}
		}

		DirectoryInfo[] directories = Directories;
		if (directories.Length > 0)
		{
			using (new H2(writer).End())
			{
				writer.Write("Directories");
			}
			using (new Ul(writer).End())
			{
				foreach (DirectoryInfo directory in directories)
				{
					using (new Li(writer).End())
					{
						using (new A(writer).WithHref($"/directory/{WebUtility.UrlEncode(directory.FullName)}").End())
						{
							writer.Write(directory.Name);
						}
					}
				}
			}
		}

		FileInfo[] files = Files;
		if (files.Length > 0)
		{
			using (new H2(writer).End())
			{
				writer.Write("Files");
			}
			using (new Ul(writer).End())
			{
				foreach (FileInfo file in files)
				{
					using (new Li(writer).End())
					{
						using (new A(writer).WithHref($"/download/{WebUtility.UrlEncode(file.FullName)}").End())
						{
							writer.Write(file.Name);
						}
					}
				}
			}
		}
	}
}
