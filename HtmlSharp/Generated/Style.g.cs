// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Style
{
	private const string ElementName = "style";
	private readonly TextWriter writer;

	public Style(TextWriter writer)
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

	public Style WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Style WithAccesskey(string value)
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

	public Style WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Style WithAutocapitalize(string value)
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

	public Style WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Style WithClass(string value)
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

	public Style WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Style WithContenteditable(string value)
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

	public Style WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Style WithContextmenu(string value)
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

	public Style WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Style WithDir(string value)
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

	public Style WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Style WithDraggable(string value)
	{
		writer.Write(" draggable=\"");
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

	public Style WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Style WithHidden(string value)
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

	public Style WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Style WithId(string value)
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

	public Style WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Style WithItemprop(string value)
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

	public Style WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Style WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Media
	{
		set
		{
			writer.Write(" media");
			WriteValueIfNotNull(value);
		}
	}

	public Style WithMedia()
	{
		writer.Write(" media");
		return this;
	}

	public Style WithMedia(string value)
	{
		writer.Write(" media=\"");
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

	public Style WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Style WithRole(string value)
	{
		writer.Write(" role=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Scoped
	{
		set
		{
			writer.Write(" scoped");
			WriteValueIfNotNull(value);
		}
	}

	public Style WithScoped()
	{
		writer.Write(" scoped");
		return this;
	}

	public Style WithScoped(string value)
	{
		writer.Write(" scoped=\"");
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

	public Style WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Style WithSlot(string value)
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

	public Style WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Style WithSpellcheck(string value)
	{
		writer.Write(" spellcheck=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Style_
	{
		set
		{
			writer.Write(" style");
			WriteValueIfNotNull(value);
		}
	}

	public Style WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Style WithStyle(string value)
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

	public Style WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Style WithTabindex(string value)
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

	public Style WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Style WithTitle(string value)
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

	public Style WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Style WithTranslate(string value)
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

	public Style WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Style WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Style WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Style WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Style WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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

	public HtmlElementCloser End()
	{
		writer.Write('>');
		return new HtmlElementCloser(writer, $"</{ElementName}>");
	}
}
