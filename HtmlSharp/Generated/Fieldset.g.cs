// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Fieldset
{
	private const string ElementName = "fieldset";
	private readonly TextWriter writer;

	public Fieldset(TextWriter writer)
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

	public Fieldset WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Fieldset WithAccesskey(string value)
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

	public Fieldset WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Fieldset WithAutocapitalize(string value)
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

	public Fieldset WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Fieldset WithClass(string value)
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

	public Fieldset WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Fieldset WithContenteditable(string value)
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

	public Fieldset WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Fieldset WithContextmenu(string value)
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

	public Fieldset WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Fieldset WithDir(string value)
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

	public Fieldset WithDisabled()
	{
		writer.Write(" disabled");
		return this;
	}

	public Fieldset WithDisabled(string value)
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

	public Fieldset WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Fieldset WithDraggable(string value)
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

	public Fieldset WithForm()
	{
		writer.Write(" form");
		return this;
	}

	public Fieldset WithForm(string value)
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

	public Fieldset WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Fieldset WithHidden(string value)
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

	public Fieldset WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Fieldset WithId(string value)
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

	public Fieldset WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Fieldset WithItemprop(string value)
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

	public Fieldset WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Fieldset WithLang(string value)
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

	public Fieldset WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Fieldset WithName(string value)
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

	public Fieldset WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Fieldset WithRole(string value)
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

	public Fieldset WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Fieldset WithSlot(string value)
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

	public Fieldset WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Fieldset WithSpellcheck(string value)
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

	public Fieldset WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Fieldset WithStyle(string value)
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

	public Fieldset WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Fieldset WithTabindex(string value)
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

	public Fieldset WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Fieldset WithTitle(string value)
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

	public Fieldset WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Fieldset WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Fieldset WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Fieldset WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Fieldset WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
