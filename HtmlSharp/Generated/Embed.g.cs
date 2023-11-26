// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Embed
{
	private const string ElementName = "embed";
	private readonly TextWriter writer;

	public Embed(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Accesskey
	{
		set
		{
			writer.Write(" accesskey");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Embed WithAccesskey(string value)
	{
		writer.Write(" accesskey=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Autocapitalize
	{
		set
		{
			writer.Write(" autocapitalize");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Embed WithAutocapitalize(string value)
	{
		writer.Write(" autocapitalize=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Class
	{
		set
		{
			writer.Write(" class");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Embed WithClass(string value)
	{
		writer.Write(" class=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Contenteditable
	{
		set
		{
			writer.Write(" contenteditable");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Embed WithContenteditable(string value)
	{
		writer.Write(" contenteditable=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Contextmenu
	{
		set
		{
			writer.Write(" contextmenu");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Embed WithContextmenu(string value)
	{
		writer.Write(" contextmenu=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Dir
	{
		set
		{
			writer.Write(" dir");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Embed WithDir(string value)
	{
		writer.Write(" dir=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Draggable
	{
		set
		{
			writer.Write(" draggable");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Embed WithDraggable(string value)
	{
		writer.Write(" draggable=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Height
	{
		set
		{
			writer.Write(" height");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithHeight()
	{
		writer.Write(" height");
		return this;
	}

	public Embed WithHeight(string value)
	{
		writer.Write(" height=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Hidden
	{
		set
		{
			writer.Write(" hidden");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Embed WithHidden(string value)
	{
		writer.Write(" hidden=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Id
	{
		set
		{
			writer.Write(" id");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Embed WithId(string value)
	{
		writer.Write(" id=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Itemprop
	{
		set
		{
			writer.Write(" itemprop");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Embed WithItemprop(string value)
	{
		writer.Write(" itemprop=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Lang
	{
		set
		{
			writer.Write(" lang");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Embed WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Role
	{
		set
		{
			writer.Write(" role");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Embed WithRole(string value)
	{
		writer.Write(" role=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Slot
	{
		set
		{
			writer.Write(" slot");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Embed WithSlot(string value)
	{
		writer.Write(" slot=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Spellcheck
	{
		set
		{
			writer.Write(" spellcheck");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Embed WithSpellcheck(string value)
	{
		writer.Write(" spellcheck=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Src
	{
		set
		{
			writer.Write(" src");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Embed WithSrc(string value)
	{
		writer.Write(" src=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Style
	{
		set
		{
			writer.Write(" style");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Embed WithStyle(string value)
	{
		writer.Write(" style=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Tabindex
	{
		set
		{
			writer.Write(" tabindex");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Embed WithTabindex(string value)
	{
		writer.Write(" tabindex=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Title
	{
		set
		{
			writer.Write(" title");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Embed WithTitle(string value)
	{
		writer.Write(" title=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Translate
	{
		set
		{
			writer.Write(" translate");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Embed WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Type
	{
		set
		{
			writer.Write(" type");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Embed WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Width
	{
		set
		{
			writer.Write(" width");
			WriteValueIfNotNull(value);
		}
	}

	public Embed WithWidth()
	{
		writer.Write(" width");
		return this;
	}

	public Embed WithWidth(string value)
	{
		writer.Write(" width=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Embed WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Embed WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Embed WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
	{
		foreach ((string key, string? value) in attributes)
		{
			WriteKey(key);
			WriteValueIfNotNull(value);
		}
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

	public void Close() => writer.Write("/>");
}
