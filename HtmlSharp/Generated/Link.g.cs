// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Link
{
	private const string ElementName = "link";
	private readonly TextWriter writer;

	public Link(TextWriter writer)
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

	public Link WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Link WithAccesskey(string value)
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

	public Link WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Link WithAutocapitalize(string value)
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

	public Link WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Link WithClass(string value)
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

	public Link WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Link WithContenteditable(string value)
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

	public Link WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Link WithContextmenu(string value)
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

	public Link WithCrossorigin()
	{
		writer.Write(" crossorigin");
		return this;
	}

	public Link WithCrossorigin(string value)
	{
		writer.Write(" crossorigin=\"");
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

	public Link WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Link WithDir(string value)
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

	public Link WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Link WithDraggable(string value)
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

	public Link WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Link WithHidden(string value)
	{
		writer.Write(" hidden=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Href
	{
		set
		{
			writer.Write(" href");
			WriteValueIfNotNull(value);
		}
	}

	public Link WithHref()
	{
		writer.Write(" href");
		return this;
	}

	public Link WithHref(string value)
	{
		writer.Write(" href=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Hreflang
	{
		set
		{
			writer.Write(" hreflang");
			WriteValueIfNotNull(value);
		}
	}

	public Link WithHreflang()
	{
		writer.Write(" hreflang");
		return this;
	}

	public Link WithHreflang(string value)
	{
		writer.Write(" hreflang=\"");
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

	public Link WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Link WithId(string value)
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

	public Link WithIntegrity()
	{
		writer.Write(" integrity");
		return this;
	}

	public Link WithIntegrity(string value)
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

	public Link WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Link WithItemprop(string value)
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

	public Link WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Link WithLang(string value)
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

	public Link WithMedia()
	{
		writer.Write(" media");
		return this;
	}

	public Link WithMedia(string value)
	{
		writer.Write(" media=\"");
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

	public Link WithReferrerpolicy()
	{
		writer.Write(" referrerpolicy");
		return this;
	}

	public Link WithReferrerpolicy(string value)
	{
		writer.Write(" referrerpolicy=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Rel
	{
		set
		{
			writer.Write(" rel");
			WriteValueIfNotNull(value);
		}
	}

	public Link WithRel()
	{
		writer.Write(" rel");
		return this;
	}

	public Link WithRel(string value)
	{
		writer.Write(" rel=\"");
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

	public Link WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Link WithRole(string value)
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

	public Link WithSizes()
	{
		writer.Write(" sizes");
		return this;
	}

	public Link WithSizes(string value)
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

	public Link WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Link WithSlot(string value)
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

	public Link WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Link WithSpellcheck(string value)
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

	public Link WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Link WithStyle(string value)
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

	public Link WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Link WithTabindex(string value)
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

	public Link WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Link WithTitle(string value)
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

	public Link WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Link WithTranslate(string value)
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

	public Link WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Link WithType(string value)
	{
		writer.Write(" type=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Link WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Link WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Link WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
