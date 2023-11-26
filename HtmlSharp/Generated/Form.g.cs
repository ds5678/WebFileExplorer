// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Form
{
	private const string ElementName = "form";
	private readonly TextWriter writer;

	public Form(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Accept
	{
		set
		{
			writer.Write(" accept");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithAccept()
	{
		writer.Write(" accept");
		return this;
	}

	public Form WithAccept(string value)
	{
		writer.Write(" accept=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? AcceptCharset
	{
		set
		{
			writer.Write(" accept-charset");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithAcceptCharset()
	{
		writer.Write(" accept-charset");
		return this;
	}

	public Form WithAcceptCharset(string value)
	{
		writer.Write(" accept-charset=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Accesskey
	{
		set
		{
			writer.Write(" accesskey");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Form WithAccesskey(string value)
	{
		writer.Write(" accesskey=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Action
	{
		set
		{
			writer.Write(" action");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithAction()
	{
		writer.Write(" action");
		return this;
	}

	public Form WithAction(string value)
	{
		writer.Write(" action=\"");
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

	public Form WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Form WithAutocapitalize(string value)
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

	public Form WithAutocomplete()
	{
		writer.Write(" autocomplete");
		return this;
	}

	public Form WithAutocomplete(string value)
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

	public Form WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Form WithClass(string value)
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

	public Form WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Form WithContenteditable(string value)
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

	public Form WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Form WithContextmenu(string value)
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

	public Form WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Form WithDir(string value)
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

	public Form WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Form WithDraggable(string value)
	{
		writer.Write(" draggable=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Enctype
	{
		set
		{
			writer.Write(" enctype");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithEnctype()
	{
		writer.Write(" enctype");
		return this;
	}

	public Form WithEnctype(string value)
	{
		writer.Write(" enctype=\"");
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

	public Form WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Form WithHidden(string value)
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

	public Form WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Form WithId(string value)
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

	public Form WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Form WithItemprop(string value)
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

	public Form WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Form WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Method
	{
		set
		{
			writer.Write(" method");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithMethod()
	{
		writer.Write(" method");
		return this;
	}

	public Form WithMethod(string value)
	{
		writer.Write(" method=\"");
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

	public Form WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Form WithName(string value)
	{
		writer.Write(" name=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Novalidate
	{
		set
		{
			writer.Write(" novalidate");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithNovalidate()
	{
		writer.Write(" novalidate");
		return this;
	}

	public Form WithNovalidate(string value)
	{
		writer.Write(" novalidate=\"");
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

	public Form WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Form WithRole(string value)
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

	public Form WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Form WithSlot(string value)
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

	public Form WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Form WithSpellcheck(string value)
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

	public Form WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Form WithStyle(string value)
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

	public Form WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Form WithTabindex(string value)
	{
		writer.Write(" tabindex=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Target
	{
		set
		{
			writer.Write(" target");
			WriteValueIfNotNull(value);
		}
	}

	public Form WithTarget()
	{
		writer.Write(" target");
		return this;
	}

	public Form WithTarget(string value)
	{
		writer.Write(" target=\"");
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

	public Form WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Form WithTitle(string value)
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

	public Form WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Form WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Form WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Form WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Form WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
