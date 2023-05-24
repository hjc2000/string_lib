namespace StringLib;

public static class Slice
{
	/// <summary>
	/// 对字符串进行切片，从指定的第一个字符开始到指定的最后一个字符（闭区间）<br></br>
	/// 指定的最后一个字符是从字符串末尾开始查找的，所以切下来的字符串片段会是最长的，所以叫Max
	/// 切下来的子字符串包含开始字符和结束字符<br></br>
	/// </summary>
	/// <param name="str"></param>
	/// <param name="start"></param>
	/// <param name="end"></param>
	/// <returns></returns>
	public static string? SliceMaxOn(this string str, char start, char end)
	{
		int startIndex = str.IndexOf(start);
		int endIndex = str.LastIndexOf(end);
		try
		{
			return str.Substring(startIndex, endIndex - startIndex + 1);
		}
		catch
		{
			return null;
		}
	}

	/// <summary>
	/// 对字符串进行切片，从指定的第一个字符开始到指定的最后一个字符（闭区间）<br></br>
	/// 指定的最后一个字符是从字符串末尾开始查找的，所以切下来的字符串片段会是最长的，所以叫Max
	/// 切下来的子字符串包含开始字符和结束字符<br></br>
	/// </summary>
	/// <param name="str"></param>
	/// <param name="start"></param>
	/// <param name="end"></param>
	/// <returns></returns>
	public static string? SliceMaxOn(this string str, string start, string end)
	{
		int startIndex = str.IndexOf(start);
		int endIndex = str.LastIndexOf(end);
		try
		{
			return str.Substring(startIndex, endIndex - startIndex + end.Length);
		}
		catch
		{
			return null;
		}
	}

	/// <summary>
	/// 切片不包含指定的字符（开区间）
	/// </summary>
	/// <param name="str"></param>
	/// <param name="start"></param>
	/// <param name="end"></param>
	/// <returns></returns>
	public static string? SliceMaxBetween(this string str, char start, char end)
	{
		int startIndex = str.IndexOf(start);
		int endIndex = str.LastIndexOf(end);
		try
		{
			return str.Substring(startIndex + 1, endIndex - startIndex - 1);
		}
		catch
		{
			return null;
		}
	}

	/// <summary>
	/// 切片不包含指定的字符（开区间）
	/// </summary>
	/// <param name="str"></param>
	/// <param name="start"></param>
	/// <param name="end"></param>
	/// <returns></returns>
	public static string? SliceMaxBetween(this string str, string start, string end)
	{
		int startIndex = str.IndexOf(start);
		int endIndex = str.LastIndexOf(end);
		try
		{
			return str.Substring(startIndex + start.Length, endIndex - startIndex - end.Length);
		}
		catch
		{
			return null;
		}
	}
}