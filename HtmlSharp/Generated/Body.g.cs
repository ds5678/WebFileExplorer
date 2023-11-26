// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Body
{
	private const string ElementName = "body";
	private readonly TextWriter writer;

	public Body(TextWriter writer)
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

	public Body WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Body WithAccesskey(string value)
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

	public Body WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Body WithAutocapitalize(string value)
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

	public Body WithBackground()
	{
		writer.Write(" background");
		return this;
	}

	public Body WithBackground(string value)
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

	public Body WithBgcolor()
	{
		writer.Write(" bgcolor");
		return this;
	}

	public Body WithBgcolor(string value)
	{
		writer.Write(" bgcolor=\"");
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

	public Body WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Body WithClass(string value)
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

	public Body WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Body WithContenteditable(string value)
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

	public Body WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Body WithContextmenu(string value)
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

	public Body WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Body WithDir(string value)
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

	public Body WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Body WithDraggable(string value)
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

	public Body WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Body WithHidden(string value)
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

	public Body WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Body WithId(string value)
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

	public Body WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Body WithItemprop(string value)
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

	public Body WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Body WithLang(string value)
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

	public Body WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Body WithRole(string value)
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

	public Body WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Body WithSlot(string value)
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

	public Body WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Body WithSpellcheck(string value)
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

	public Body WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Body WithStyle(string value)
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

	public Body WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Body WithTabindex(string value)
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

	public Body WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Body WithTitle(string value)
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

	public Body WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Body WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Body WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Body WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Body WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
