// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Select
{
	private const string ElementName = "select";
	private readonly TextWriter writer;

	public Select(TextWriter writer)
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

	public Select WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Select WithAccesskey(string value)
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

	public Select WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Select WithAutocapitalize(string value)
	{
		writer.Write(" autocapitalize=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Autocomplete
	{
		set
		{
			writer.Write(" autocomplete");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithAutocomplete()
	{
		writer.Write(" autocomplete");
		return this;
	}

	public Select WithAutocomplete(string value)
	{
		writer.Write(" autocomplete=\"");
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

	public Select WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Select WithClass(string value)
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

	public Select WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Select WithContenteditable(string value)
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

	public Select WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Select WithContextmenu(string value)
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

	public Select WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Select WithDir(string value)
	{
		writer.Write(" dir=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Disabled
	{
		set
		{
			writer.Write(" disabled");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithDisabled()
	{
		writer.Write(" disabled");
		return this;
	}

	public Select WithDisabled(string value)
	{
		writer.Write(" disabled=\"");
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

	public Select WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Select WithDraggable(string value)
	{
		writer.Write(" draggable=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Form
	{
		set
		{
			writer.Write(" form");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithForm()
	{
		writer.Write(" form");
		return this;
	}

	public Select WithForm(string value)
	{
		writer.Write(" form=\"");
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

	public Select WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Select WithHidden(string value)
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

	public Select WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Select WithId(string value)
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

	public Select WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Select WithItemprop(string value)
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

	public Select WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Select WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Multiple
	{
		set
		{
			writer.Write(" multiple");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithMultiple()
	{
		writer.Write(" multiple");
		return this;
	}

	public Select WithMultiple(string value)
	{
		writer.Write(" multiple=\"");
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

	public Select WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Select WithName(string value)
	{
		writer.Write(" name=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Required
	{
		set
		{
			writer.Write(" required");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithRequired()
	{
		writer.Write(" required");
		return this;
	}

	public Select WithRequired(string value)
	{
		writer.Write(" required=\"");
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

	public Select WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Select WithRole(string value)
	{
		writer.Write(" role=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Size
	{
		set
		{
			writer.Write(" size");
			WriteValueIfNotNull(value);
		}
	}

	public Select WithSize()
	{
		writer.Write(" size");
		return this;
	}

	public Select WithSize(string value)
	{
		writer.Write(" size=\"");
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

	public Select WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Select WithSlot(string value)
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

	public Select WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Select WithSpellcheck(string value)
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

	public Select WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Select WithStyle(string value)
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

	public Select WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Select WithTabindex(string value)
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

	public Select WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Select WithTitle(string value)
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

	public Select WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Select WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Select WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Select WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Select WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
