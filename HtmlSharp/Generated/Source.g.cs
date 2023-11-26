// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Source
{
	private const string ElementName = "source";
	private readonly TextWriter writer;

	public Source(TextWriter writer)
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

	public Source WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Source WithAccesskey(string value)
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

	public Source WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Source WithAutocapitalize(string value)
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

	public Source WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Source WithClass(string value)
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

	public Source WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Source WithContenteditable(string value)
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

	public Source WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Source WithContextmenu(string value)
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

	public Source WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Source WithDir(string value)
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

	public Source WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Source WithDraggable(string value)
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

	public Source WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Source WithHidden(string value)
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

	public Source WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Source WithId(string value)
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

	public Source WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Source WithItemprop(string value)
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

	public Source WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Source WithLang(string value)
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

	public Source WithMedia()
	{
		writer.Write(" media");
		return this;
	}

	public Source WithMedia(string value)
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

	public Source WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Source WithRole(string value)
	{
		writer.Write(" role=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Sizes
	{
		set
		{
			writer.Write(" sizes");
			WriteValueIfNotNull(value);
		}
	}

	public Source WithSizes()
	{
		writer.Write(" sizes");
		return this;
	}

	public Source WithSizes(string value)
	{
		writer.Write(" sizes=\"");
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

	public Source WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Source WithSlot(string value)
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

	public Source WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Source WithSpellcheck(string value)
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

	public Source WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Source WithSrc(string value)
	{
		writer.Write(" src=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Srcset
	{
		set
		{
			writer.Write(" srcset");
			WriteValueIfNotNull(value);
		}
	}

	public Source WithSrcset()
	{
		writer.Write(" srcset");
		return this;
	}

	public Source WithSrcset(string value)
	{
		writer.Write(" srcset=\"");
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

	public Source WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Source WithStyle(string value)
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

	public Source WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Source WithTabindex(string value)
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

	public Source WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Source WithTitle(string value)
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

	public Source WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Source WithTranslate(string value)
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

	public Source WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Source WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Source WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Source WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Source WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
