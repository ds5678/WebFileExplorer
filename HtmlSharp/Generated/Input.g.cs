// Auto-generated code. Do not modify manually.

#nullable enable

namespace HtmlSharp;

public readonly ref partial struct Input
{
	private const string ElementName = "input";
	private readonly TextWriter writer;

	public Input(TextWriter writer)
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

	public Input WithAccept()
	{
		writer.Write(" accept");
		return this;
	}

	public Input WithAccept(string value)
	{
		writer.Write(" accept=\"");
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

	public Input WithAccesskey()
	{
		writer.Write(" accesskey");
		return this;
	}

	public Input WithAccesskey(string value)
	{
		writer.Write(" accesskey=\"");
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

	public Input WithAlt()
	{
		writer.Write(" alt");
		return this;
	}

	public Input WithAlt(string value)
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

	public Input WithAutocapitalize()
	{
		writer.Write(" autocapitalize");
		return this;
	}

	public Input WithAutocapitalize(string value)
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

	public Input WithAutocomplete()
	{
		writer.Write(" autocomplete");
		return this;
	}

	public Input WithAutocomplete(string value)
	{
		writer.Write(" autocomplete=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Capture
	{
		set
		{
			writer.Write(" capture");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithCapture()
	{
		writer.Write(" capture");
		return this;
	}

	public Input WithCapture(string value)
	{
		writer.Write(" capture=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Checked
	{
		set
		{
			writer.Write(" checked");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithChecked()
	{
		writer.Write(" checked");
		return this;
	}

	public Input WithChecked(string value)
	{
		writer.Write(" checked=\"");
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

	public Input WithClass()
	{
		writer.Write(" class");
		return this;
	}

	public Input WithClass(string value)
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

	public Input WithContenteditable()
	{
		writer.Write(" contenteditable");
		return this;
	}

	public Input WithContenteditable(string value)
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

	public Input WithContextmenu()
	{
		writer.Write(" contextmenu");
		return this;
	}

	public Input WithContextmenu(string value)
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

	public Input WithDir()
	{
		writer.Write(" dir");
		return this;
	}

	public Input WithDir(string value)
	{
		writer.Write(" dir=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Dirname
	{
		set
		{
			writer.Write(" dirname");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithDirname()
	{
		writer.Write(" dirname");
		return this;
	}

	public Input WithDirname(string value)
	{
		writer.Write(" dirname=\"");
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

	public Input WithDisabled()
	{
		writer.Write(" disabled");
		return this;
	}

	public Input WithDisabled(string value)
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

	public Input WithDraggable()
	{
		writer.Write(" draggable");
		return this;
	}

	public Input WithDraggable(string value)
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

	public Input WithForm()
	{
		writer.Write(" form");
		return this;
	}

	public Input WithForm(string value)
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

	public Input WithFormaction()
	{
		writer.Write(" formaction");
		return this;
	}

	public Input WithFormaction(string value)
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

	public Input WithFormenctype()
	{
		writer.Write(" formenctype");
		return this;
	}

	public Input WithFormenctype(string value)
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

	public Input WithFormmethod()
	{
		writer.Write(" formmethod");
		return this;
	}

	public Input WithFormmethod(string value)
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

	public Input WithFormnovalidate()
	{
		writer.Write(" formnovalidate");
		return this;
	}

	public Input WithFormnovalidate(string value)
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

	public Input WithFormtarget()
	{
		writer.Write(" formtarget");
		return this;
	}

	public Input WithFormtarget(string value)
	{
		writer.Write(" formtarget=\"");
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

	public Input WithHeight()
	{
		writer.Write(" height");
		return this;
	}

	public Input WithHeight(string value)
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

	public Input WithHidden()
	{
		writer.Write(" hidden");
		return this;
	}

	public Input WithHidden(string value)
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

	public Input WithId()
	{
		writer.Write(" id");
		return this;
	}

	public Input WithId(string value)
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

	public Input WithItemprop()
	{
		writer.Write(" itemprop");
		return this;
	}

	public Input WithItemprop(string value)
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

	public Input WithLang()
	{
		writer.Write(" lang");
		return this;
	}

	public Input WithLang(string value)
	{
		writer.Write(" lang=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? List
	{
		set
		{
			writer.Write(" list");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithList()
	{
		writer.Write(" list");
		return this;
	}

	public Input WithList(string value)
	{
		writer.Write(" list=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Max
	{
		set
		{
			writer.Write(" max");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithMax()
	{
		writer.Write(" max");
		return this;
	}

	public Input WithMax(string value)
	{
		writer.Write(" max=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Maxlength
	{
		set
		{
			writer.Write(" maxlength");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithMaxlength()
	{
		writer.Write(" maxlength");
		return this;
	}

	public Input WithMaxlength(string value)
	{
		writer.Write(" maxlength=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Minlength
	{
		set
		{
			writer.Write(" minlength");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithMinlength()
	{
		writer.Write(" minlength");
		return this;
	}

	public Input WithMinlength(string value)
	{
		writer.Write(" minlength=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Min
	{
		set
		{
			writer.Write(" min");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithMin()
	{
		writer.Write(" min");
		return this;
	}

	public Input WithMin(string value)
	{
		writer.Write(" min=\"");
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

	public Input WithMultiple()
	{
		writer.Write(" multiple");
		return this;
	}

	public Input WithMultiple(string value)
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

	public Input WithName()
	{
		writer.Write(" name");
		return this;
	}

	public Input WithName(string value)
	{
		writer.Write(" name=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Pattern
	{
		set
		{
			writer.Write(" pattern");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithPattern()
	{
		writer.Write(" pattern");
		return this;
	}

	public Input WithPattern(string value)
	{
		writer.Write(" pattern=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Placeholder
	{
		set
		{
			writer.Write(" placeholder");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithPlaceholder()
	{
		writer.Write(" placeholder");
		return this;
	}

	public Input WithPlaceholder(string value)
	{
		writer.Write(" placeholder=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Readonly
	{
		set
		{
			writer.Write(" readonly");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithReadonly()
	{
		writer.Write(" readonly");
		return this;
	}

	public Input WithReadonly(string value)
	{
		writer.Write(" readonly=\"");
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

	public Input WithRequired()
	{
		writer.Write(" required");
		return this;
	}

	public Input WithRequired(string value)
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

	public Input WithRole()
	{
		writer.Write(" role");
		return this;
	}

	public Input WithRole(string value)
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

	public Input WithSize()
	{
		writer.Write(" size");
		return this;
	}

	public Input WithSize(string value)
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

	public Input WithSlot()
	{
		writer.Write(" slot");
		return this;
	}

	public Input WithSlot(string value)
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

	public Input WithSpellcheck()
	{
		writer.Write(" spellcheck");
		return this;
	}

	public Input WithSpellcheck(string value)
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

	public Input WithSrc()
	{
		writer.Write(" src");
		return this;
	}

	public Input WithSrc(string value)
	{
		writer.Write(" src=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public string? Step
	{
		set
		{
			writer.Write(" step");
			WriteValueIfNotNull(value);
		}
	}

	public Input WithStep()
	{
		writer.Write(" step");
		return this;
	}

	public Input WithStep(string value)
	{
		writer.Write(" step=\"");
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

	public Input WithStyle()
	{
		writer.Write(" style");
		return this;
	}

	public Input WithStyle(string value)
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

	public Input WithTabindex()
	{
		writer.Write(" tabindex");
		return this;
	}

	public Input WithTabindex(string value)
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

	public Input WithTitle()
	{
		writer.Write(" title");
		return this;
	}

	public Input WithTitle(string value)
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

	public Input WithTranslate()
	{
		writer.Write(" translate");
		return this;
	}

	public Input WithTranslate(string value)
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

	public Input WithType()
	{
		writer.Write(" type");
		return this;
	}

	public Input WithType(string value)
	{
		writer.Write(" type=\"");
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

	public Input WithUsemap()
	{
		writer.Write(" usemap");
		return this;
	}

	public Input WithUsemap(string value)
	{
		writer.Write(" usemap=\"");
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

	public Input WithValue()
	{
		writer.Write(" value");
		return this;
	}

	public Input WithValue(string value)
	{
		writer.Write(" value=\"");
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

	public Input WithWidth()
	{
		writer.Write(" width");
		return this;
	}

	public Input WithWidth(string value)
	{
		writer.Write(" width=\"");
		writer.Write(value);
		writer.Write('"');
		return this;
	}

	public Input WithCustomAttribute(string key)
	{
		WriteKey(key);
		return this;
	}

	public Input WithCustomAttribute(string key, string value)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Input WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
