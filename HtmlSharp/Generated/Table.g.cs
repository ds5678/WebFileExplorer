// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Table
{
	private const string ElementName = "table";
	private readonly TextWriter writer;

	public Table(TextWriter writer)
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

	public Table WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Table WithAccesskey(string value)
	{
		writer.Write(" accesskey=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Align
	{
		set
		{
			writer.Write(" align");
			WriteValueIfNotNull(value);
		}
	}

	public Table WithAlign()
	{
		writer.Write(" align");
		return this;
	}

	public Table WithAlign(string value)
	{
		writer.Write(" align=\"");
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

	public Table WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Table WithAutocapitalize(string value)
	{
		writer.Write(" autocapitalize=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Background
	{
		set
		{
			writer.Write(" background");
			WriteValueIfNotNull(value);
		}
	}

	public Table WithBackground()
	{
		writer.Write(" background");
		return this;
	}

	public Table WithBackground(string value)
	{
		writer.Write(" background=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Bgcolor
	{
		set
		{
			writer.Write(" bgcolor");
			WriteValueIfNotNull(value);
		}
	}

	public Table WithBgcolor()
	{
		writer.Write(" bgcolor");
		return this;
	}

	public Table WithBgcolor(string value)
	{
		writer.Write(" bgcolor=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Border
	{
		set
		{
			writer.Write(" border");
			WriteValueIfNotNull(value);
		}
	}

	public Table WithBorder()
	{
		writer.Write(" border");
		return this;
	}

	public Table WithBorder(string value)
	{
		writer.Write(" border=\"");
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

	public Table WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Table WithClass(string value)
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

	public Table WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Table WithContenteditable(string value)
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

	public Table WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Table WithContextmenu(string value)
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

	public Table WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Table WithDir(string value)
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

	public Table WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Table WithDraggable(string value)
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

	public Table WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Table WithHidden(string value)
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

	public Table WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Table WithId(string value)
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

	public Table WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Table WithItemprop(string value)
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

	public Table WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Table WithLang(string value)
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

	public Table WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Table WithRole(string value)
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

	public Table WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Table WithSlot(string value)
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

	public Table WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Table WithSpellcheck(string value)
	{
		writer.Write(" spellcheck=\"");
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

	public Table WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Table WithStyle(string value)
	{
		writer.Write(" style=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Summary
	{
		set
		{
			writer.Write(" summary");
			WriteValueIfNotNull(value);
		}
	}

	public Table WithSummary()
	{
		writer.Write(" summary");
		return this;
	}

	public Table WithSummary(string value)
	{
		writer.Write(" summary=\"");
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

	public Table WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Table WithTabindex(string value)
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

	public Table WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Table WithTitle(string value)
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

	public Table WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Table WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Table WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Table WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Table WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
