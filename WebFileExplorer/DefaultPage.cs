using HtmlSharp;

namespace WebFileExplorer;

public abstract class DefaultPage : HtmlPage
{
	public sealed override void Write(TextWriter writer)
	{
		base.Write(writer);
		using (new Html(writer).End())
		{
			using (new Head(writer).End())
			{
				new Meta(writer).WithCharset("utf-8").Close();
				using (new Title(writer).End())
				{
					writer.Write(GetTitle());
				}
				new Meta(writer).WithCustomAttribute("viewport", "width=device-width").Close();
				WriteBootstrapCSS(writer);
			}
			using (new Body(writer).WithCustomAttribute("data-bs-theme", "dark").End())
			{
				WriteInnerContent(writer);
				WriteBootstrapScript(writer);
			}
		}

		static void WriteBootstrapCSS(TextWriter writer)
		{
			new Link(writer)
			{
				Rel = "stylesheet",
				Href = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css",
				Integrity = "sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN",
				Crossorigin = "anonymous"
			}.Close();
		}

		static void WriteBootstrapScript(TextWriter writer)
		{
			new Script(writer)
			{
				Src = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js",
				Integrity = "sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL",
				Crossorigin = "anonymous"
			}.Close();
		}
	}

	public abstract string? GetTitle();

	public abstract void WriteInnerContent(TextWriter writer);
}
