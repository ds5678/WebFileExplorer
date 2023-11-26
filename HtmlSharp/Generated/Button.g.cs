// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Button
{
	private const string ElementName = "button";
	private readonly TextWriter writer;

	public Button(TextWriter writer)
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

	public Button WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Button WithAccesskey(string value)
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

	public Button WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Button WithAutocapitalize(string value)
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

	public Button WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Button WithClass(string value)
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

	public Button WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Button WithContenteditable(string value)
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

	public Button WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Button WithContextmenu(string value)
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

	public Button WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Button WithDir(string value)
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

	public Button WithDisabled()
	{
		writer.Write(" disabled");
		return this;
	}

	public Button WithDisabled(string value)
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

	public Button WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Button WithDraggable(string value)
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

	public Button WithForm()
	{
		writer.Write(" form");
		return this;
	}

	public Button WithForm(string value)
	{
		writer.Write(" form=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Formaction
	{
		set
		{
			writer.Write(" formaction");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithFormaction()
	{
		writer.Write(" formaction");
		return this;
	}

	public Button WithFormaction(string value)
	{
		writer.Write(" formaction=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Formenctype
	{
		set
		{
			writer.Write(" formenctype");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithFormenctype()
	{
		writer.Write(" formenctype");
		return this;
	}

	public Button WithFormenctype(string value)
	{
		writer.Write(" formenctype=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Formmethod
	{
		set
		{
			writer.Write(" formmethod");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithFormmethod()
	{
		writer.Write(" formmethod");
		return this;
	}

	public Button WithFormmethod(string value)
	{
		writer.Write(" formmethod=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Formnovalidate
	{
		set
		{
			writer.Write(" formnovalidate");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithFormnovalidate()
	{
		writer.Write(" formnovalidate");
		return this;
	}

	public Button WithFormnovalidate(string value)
	{
		writer.Write(" formnovalidate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Formtarget
	{
		set
		{
			writer.Write(" formtarget");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithFormtarget()
	{
		writer.Write(" formtarget");
		return this;
	}

	public Button WithFormtarget(string value)
	{
		writer.Write(" formtarget=\"");
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

	public Button WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Button WithHidden(string value)
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

	public Button WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Button WithId(string value)
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

	public Button WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Button WithItemprop(string value)
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

	public Button WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Button WithLang(string value)
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

	public Button WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Button WithName(string value)
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

	public Button WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Button WithRole(string value)
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

	public Button WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Button WithSlot(string value)
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

	public Button WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Button WithSpellcheck(string value)
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

	public Button WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Button WithStyle(string value)
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

	public Button WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Button WithTabindex(string value)
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

	public Button WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Button WithTitle(string value)
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

	public Button WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Button WithTranslate(string value)
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

	public Button WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Button WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Value
	{
		set
		{
			writer.Write(" value");
			WriteValueIfNotNull(value);
		}
	}

	public Button WithValue()
	{
		writer.Write(" value");
		return this;
	}

	public Button WithValue(string value)
	{
		writer.Write(" value=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Button WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Button WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Button WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
