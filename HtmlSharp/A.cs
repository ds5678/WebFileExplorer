namespace HtmlSharp;

ref partial struct A
{
	/// <summary>
	/// Makes this anchor element open in a new tab.
	/// </summary>
	/// <remarks>
	/// Based on <see href="https://www.freecodecamp.org/news/how-to-use-html-to-open-link-in-new-tab/"/>
	/// </remarks>
	/// <returns><see langword="this"/></returns>
	public A WithNewTabAttributes()
	{
		return WithTarget("_blank").WithRel("noopener noreferrer");
	}
}
