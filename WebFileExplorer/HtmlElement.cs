using System.Diagnostics.CodeAnalysis;

namespace WebFileExplorer;

/// <summary>
/// A helper class for writing minified HTML.
/// </summary>
/// <remarks>
/// The output should also be XHTML compatible.
/// </remarks>
public readonly ref partial struct HtmlElement
{
	private readonly TextWriter writer;
	private readonly string? name;
	[MemberNotNullWhen(false)]
	private bool SelfClosing => name is null;

	private HtmlElement(TextWriter writer, string name, bool selfClosing, scoped ReadOnlySpan<(string, string?)> attributes)
	{
		this.writer = writer;
		this.name = selfClosing ? null : name;
		writer.Write('<');
		writer.Write(name);
		WriteAttributes(writer, attributes);
		if (selfClosing)
		{
			writer.Write('/');
		}
		writer.Write('>');
	}

	private HtmlElement(TextWriter writer, string name, bool selfClosing, scoped ReadOnlySpan<(string, string?)> requiredAttributes, scoped ReadOnlySpan<(string, string?)> optionalAttributes)
	{
		this.writer = writer;
		this.name = selfClosing ? null : name;
		writer.Write('<');
		writer.Write(name);
		WriteAttributes(writer, requiredAttributes);
		WriteAttributes(writer, optionalAttributes);
		if (selfClosing)
		{
			writer.Write('/');
		}
		writer.Write('>');
	}

	private static void WriteAttributes(TextWriter writer, scoped ReadOnlySpan<(string, string?)> attributes)
	{
		foreach ((string key, string? value) in attributes)
		{
			writer.Write(' ');
			writer.Write(key);
			if (value is not null)
			{
				writer.Write("=\"");
				writer.Write(value);
				writer.Write('"');
			}
		}
	}

	public void Close()
	{
		if (!SelfClosing)
		{
			writer.Write("</");
			writer.Write(name);
			writer.Write('>');
		}
	}

	public void Dispose() => Close();

	private static void SelfClosedElement(TextWriter writer, string name, scoped ReadOnlySpan<(string, string?)> attributes)
	{
		_ = new HtmlElement(writer, name, true, attributes);
	}

	private static void SelfClosedElement(TextWriter writer, string name, scoped ReadOnlySpan<(string, string?)> requiredAttributes, scoped ReadOnlySpan<(string, string?)> optionalAttributes)
	{
		_ = new HtmlElement(writer, name, true, requiredAttributes, optionalAttributes);
	}

	public static void Br(TextWriter writer, scoped ReadOnlySpan<(string, string?)> attributes = default)
	{
		SelfClosedElement(writer, "br", attributes);
	}

	public static void Img(TextWriter writer, string source, scoped ReadOnlySpan<(string, string?)> additionalAttributes = default)
	{
		SelfClosedElement(writer, "img", [("src", source)], additionalAttributes);
	}

	public static void Meta(TextWriter writer, scoped ReadOnlySpan<(string, string?)> attributes = default)
	{
		SelfClosedElement(writer, "meta", attributes);
	}

	public static HtmlElement Html(TextWriter writer, string language = "en", scoped ReadOnlySpan<(string, string?)> additionalAttributes = default)
	{
		return new HtmlElement(writer, "html", false, [("lang", language)], additionalAttributes);
	}

	public static HtmlElement Head(TextWriter writer, scoped ReadOnlySpan<(string, string?)> attributes = default)
	{
		return new HtmlElement(writer, "head", false, attributes);
	}

	public static HtmlElement Body(TextWriter writer, scoped ReadOnlySpan<(string, string?)> attributes = default)
	{
		return new HtmlElement(writer, "body", false, attributes);
	}

	public static void Title(TextWriter writer, string? title, scoped ReadOnlySpan<(string, string?)> attributes = default)
	{
		using (new HtmlElement(writer, "title", false, attributes))
		{
			writer.Write(title);
		}
	}
}
public readonly ref partial struct Img
{
	private const string ElementName = "img";
	private readonly TextWriter writer;

	public Img(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Src
	{
		set
		{
			writer.Write(" src");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Img WithSrc(string value)
	{
		writer.Write(" src=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	private void WriteKey(string key)
	{
		writer.Write(' ');
		writer.Write(key);
	}

	private void WriteValue(string value)
	{
		writer.Write("=\"");
		writer.Write(value);
		writer.Write('"');
	}

	private void WriteValueIfNotNull(string? value)
	{
		if (value is not null)
		{
			WriteValue(value);
		}
	}

	public Img WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Img WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Img WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
	{
		foreach ((string key, string? value) in attributes)
		{
			WriteKey(key);
			WriteValueIfNotNull(value);
		}
		return this;
	}

	public void Close() => writer.Write("/>");
}
