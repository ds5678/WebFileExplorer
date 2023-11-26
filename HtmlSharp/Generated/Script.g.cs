// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Script
{
	private const string ElementName = "script";
	private readonly TextWriter writer;

	public Script(TextWriter writer)
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

	public Script WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Script WithAccesskey(string value)
	{
		writer.Write(" accesskey=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Async
	{
		set
		{
			writer.Write(" async");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithAsync()
	{
		writer.Write(" async");
		return this;
	}

	public Script WithAsync(string value)
	{
		writer.Write(" async=\"");
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

	public Script WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Script WithAutocapitalize(string value)
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

	public Script WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Script WithClass(string value)
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

	public Script WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Script WithContenteditable(string value)
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

	public Script WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Script WithContextmenu(string value)
	{
		writer.Write(" contextmenu=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Crossorigin
	{
		set
		{
			writer.Write(" crossorigin");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithCrossorigin()
	{
		writer.Write(" crossorigin");
		return this;
	}

	public Script WithCrossorigin(string value)
	{
		writer.Write(" crossorigin=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Defer
	{
		set
		{
			writer.Write(" defer");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithDefer()
	{
		writer.Write(" defer");
		return this;
	}

	public Script WithDefer(string value)
	{
		writer.Write(" defer=\"");
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

	public Script WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Script WithDir(string value)
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

	public Script WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Script WithDraggable(string value)
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

	public Script WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Script WithHidden(string value)
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

	public Script WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Script WithId(string value)
	{
		writer.Write(" id=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Integrity
	{
		set
		{
			writer.Write(" integrity");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithIntegrity()
	{
		writer.Write(" integrity");
		return this;
	}

	public Script WithIntegrity(string value)
	{
		writer.Write(" integrity=\"");
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

	public Script WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Script WithItemprop(string value)
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

	public Script WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Script WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Language
	{
		set
		{
			writer.Write(" language");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithLanguage()
	{
		writer.Write(" language");
		return this;
	}

	public Script WithLanguage(string value)
	{
		writer.Write(" language=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Referrerpolicy
	{
		set
		{
			writer.Write(" referrerpolicy");
			WriteValueIfNotNull(value);
		}
	}

	public Script WithReferrerpolicy()
	{
		writer.Write(" referrerpolicy");
		return this;
	}

	public Script WithReferrerpolicy(string value)
	{
		writer.Write(" referrerpolicy=\"");
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

	public Script WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Script WithRole(string value)
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

	public Script WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Script WithSlot(string value)
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

	public Script WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Script WithSpellcheck(string value)
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

	public Script WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Script WithSrc(string value)
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

	public Script WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Script WithStyle(string value)
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

	public Script WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Script WithTabindex(string value)
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

	public Script WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Script WithTitle(string value)
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

	public Script WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Script WithTranslate(string value)
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

	public Script WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Script WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Script WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Script WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Script WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
