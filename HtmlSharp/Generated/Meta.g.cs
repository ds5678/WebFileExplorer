// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Meta
{
	private const string ElementName = "meta";
	private readonly TextWriter writer;

	public Meta(TextWriter writer)
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

	public Meta WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Meta WithAccesskey(string value)
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

	public Meta WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Meta WithAutocapitalize(string value)
	{
		writer.Write(" autocapitalize=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Charset
	{
		set
		{
			writer.Write(" charset");
			WriteValueIfNotNull(value);
		}
	}

	public Meta WithCharset()
	{
		writer.Write(" charset");
		return this;
	}

	public Meta WithCharset(string value)
	{
		writer.Write(" charset=\"");
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

	public Meta WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Meta WithClass(string value)
	{
		writer.Write(" class=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Content
	{
		set
		{
			writer.Write(" content");
			WriteValueIfNotNull(value);
		}
	}

	public Meta WithContent()
	{
		writer.Write(" content");
		return this;
	}

	public Meta WithContent(string value)
	{
		writer.Write(" content=\"");
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

	public Meta WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Meta WithContenteditable(string value)
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

	public Meta WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Meta WithContextmenu(string value)
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

	public Meta WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Meta WithDir(string value)
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

	public Meta WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Meta WithDraggable(string value)
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

	public Meta WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Meta WithHidden(string value)
	{
		writer.Write(" hidden=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? HttpEquiv
	{
		set
		{
			writer.Write(" http-equiv");
			WriteValueIfNotNull(value);
		}
	}

	public Meta WithHttpEquiv()
	{
		writer.Write(" http-equiv");
		return this;
	}

	public Meta WithHttpEquiv(string value)
	{
		writer.Write(" http-equiv=\"");
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

	public Meta WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Meta WithId(string value)
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

	public Meta WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Meta WithItemprop(string value)
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

	public Meta WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Meta WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Name
	{
		set
		{
			writer.Write(" name");
			WriteValueIfNotNull(value);
		}
	}

	public Meta WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Meta WithName(string value)
	{
		writer.Write(" name=\"");
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

	public Meta WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Meta WithRole(string value)
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

	public Meta WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Meta WithSlot(string value)
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

	public Meta WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Meta WithSpellcheck(string value)
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

	public Meta WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Meta WithStyle(string value)
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

	public Meta WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Meta WithTabindex(string value)
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

	public Meta WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Meta WithTitle(string value)
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

	public Meta WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Meta WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Meta WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Meta WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Meta WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
