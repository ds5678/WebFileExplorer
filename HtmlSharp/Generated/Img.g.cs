// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Img
{
	private const string ElementName = "img";
	private readonly TextWriter writer;

	public Img(TextWriter writer)
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

	public Img WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Img WithAccesskey(string value)
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

	public Img WithAlign()
	{
		writer.Write(" align");
		return this;
	}

	public Img WithAlign(string value)
	{
		writer.Write(" align=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Alt
	{
		set
		{
			writer.Write(" alt");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithAlt()
	{
		writer.Write(" alt");
		return this;
	}

	public Img WithAlt(string value)
	{
		writer.Write(" alt=\"");
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

	public Img WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Img WithAutocapitalize(string value)
	{
		writer.Write(" autocapitalize=\"");
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

	public Img WithBorder()
	{
		writer.Write(" border");
		return this;
	}

	public Img WithBorder(string value)
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

	public Img WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Img WithClass(string value)
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

	public Img WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Img WithContenteditable(string value)
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

	public Img WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Img WithContextmenu(string value)
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

	public Img WithCrossorigin()
	{
		writer.Write(" crossorigin");
		return this;
	}

	public Img WithCrossorigin(string value)
	{
		writer.Write(" crossorigin=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Decoding
	{
		set
		{
			writer.Write(" decoding");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithDecoding()
	{
		writer.Write(" decoding");
		return this;
	}

	public Img WithDecoding(string value)
	{
		writer.Write(" decoding=\"");
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

	public Img WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Img WithDir(string value)
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

	public Img WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Img WithDraggable(string value)
	{
		writer.Write(" draggable=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Height
	{
		set
		{
			writer.Write(" height");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithHeight()
	{
		writer.Write(" height");
		return this;
	}

	public Img WithHeight(string value)
	{
		writer.Write(" height=\"");
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

	public Img WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Img WithHidden(string value)
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

	public Img WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Img WithId(string value)
	{
		writer.Write(" id=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Intrinsicsize
	{
		set
		{
			writer.Write(" intrinsicsize");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithIntrinsicsize()
	{
		writer.Write(" intrinsicsize");
		return this;
	}

	public Img WithIntrinsicsize(string value)
	{
		writer.Write(" intrinsicsize=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Ismap
	{
		set
		{
			writer.Write(" ismap");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithIsmap()
	{
		writer.Write(" ismap");
		return this;
	}

	public Img WithIsmap(string value)
	{
		writer.Write(" ismap=\"");
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

	public Img WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Img WithItemprop(string value)
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

	public Img WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Img WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Loading
	{
		set
		{
			writer.Write(" loading");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithLoading()
	{
		writer.Write(" loading");
		return this;
	}

	public Img WithLoading(string value)
	{
		writer.Write(" loading=\"");
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

	public Img WithReferrerpolicy()
	{
		writer.Write(" referrerpolicy");
		return this;
	}

	public Img WithReferrerpolicy(string value)
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

	public Img WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Img WithRole(string value)
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

	public Img WithSizes()
	{
		writer.Write(" sizes");
		return this;
	}

	public Img WithSizes(string value)
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

	public Img WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Img WithSlot(string value)
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

	public Img WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Img WithSpellcheck(string value)
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

	public Img WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Img WithSrc(string value)
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

	public Img WithSrcset()
	{
		writer.Write(" srcset");
		return this;
	}

	public Img WithSrcset(string value)
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

	public Img WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Img WithStyle(string value)
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

	public Img WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Img WithTabindex(string value)
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

	public Img WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Img WithTitle(string value)
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

	public Img WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Img WithTranslate(string value)
	{
		writer.Write(" translate=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Usemap
	{
		set
		{
			writer.Write(" usemap");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithUsemap()
	{
		writer.Write(" usemap");
		return this;
	}

	public Img WithUsemap(string value)
	{
		writer.Write(" usemap=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Width
	{
		set
		{
			writer.Write(" width");
			WriteValueIfNotNull(value);
		}
	}

	public Img WithWidth()
	{
		writer.Write(" width");
		return this;
	}

	public Img WithWidth(string value)
	{
		writer.Write(" width=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Img WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Img WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Img WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
