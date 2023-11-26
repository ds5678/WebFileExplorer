using HtmlSharp;

namespace WebFileExplorer;

public class FibonacciPage : DefaultPage
{
	private readonly int count;
	public FibonacciPage(int count) : base()
	{
		this.count = count;
	}

	public override void WriteInnerContent(TextWriter writer)
	{
		using (new H1(writer).WithId("heading").End())
		{
			using (new A(writer).WithHref("https://en.wikipedia.org/wiki/Fibonacci_sequence").WithNewTabAttributes().End())
			{
				writer.Write("Fibonacci");
			}
		}
		using (new Ol(writer).End())
		{
			int a = 1;
			int b = 1;
			WriteListItem(writer, a);
			WriteListItem(writer, b);
			for (int i = 2; i < count; i++)
			{
				int c = a + b;
				a = b;
				b = c;
				WriteListItem(writer, c);
			}
		}
		using (new Footer(writer).WithClass("text-center").End())
		{
			writer.Write("Copyright 2023");
		}

		static void WriteListItem(TextWriter writer, int value)
		{
			using (new Li(writer).End())
			{
				writer.Write(value);
			}
		}
	}

	public override string? GetTitle()
	{
		return "Fibonacci List";
	}
}
