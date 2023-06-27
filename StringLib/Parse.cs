namespace StringLib;

public static class Parse
{
	/// <summary>
	/// 解析 key = value 形式的字符串。key, value 支持使用单引号、双引号包起来，就像：
	/// key = "value" , key = 'value' , 'key' = 'value' ...... 等
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	public static (bool success, string key, string value) ParseKeyValue(this string str)
	{
		try
		{
			str = str.Trim();
			int index = str.IndexOf('=');
			string key = str[..index];
			string value = str[(index + 1)..];
			key = RemoveQuotationMark(key);
			value = RemoveQuotationMark(value);
			return (true, key, value);
		}
		catch
		{
			return (false, string.Empty, string.Empty);
		}
	}

	/// <summary>
	/// 一直读取行（一次读取一行）知道读到一行，这一行中包含 match
	/// </summary>
	/// <param name="reader"></param>
	/// <param name="match"></param>
	public static void ReadLineUntil(this StringReader reader, string match)
	{
		while (true)
		{
			string? line = reader.ReadLine();
			if (line == null) break;
			if (line.Contains(match)) break;
		}
	}
	/// <summary>
	/// 去除字符串开头和结尾位置的引号
	/// </summary>
	/// <returns></returns>
	private static string RemoveQuotationMark(string value)
	{
		if (value.StartsWith('\"') || value.StartsWith('\''))
		{
			value = value[1..];
		}

		if (value.EndsWith('\"') || value.EndsWith('\''))
		{
			value = value[..^1];
		}

		return value;
	}
}
