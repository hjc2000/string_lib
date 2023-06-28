using System.Text;

namespace StringLib.Parse;

public static class KeyValueParser
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
			key = Trim(key);
			value = Trim(value);
			return (true, key, value);
		}
		catch
		{
			return (false, string.Empty, string.Empty);
		}
	}

	/// <summary>
	/// 一直读取行（一次读取一行）直到读到一行，这一行内容等于 match
	/// </summary>
	/// <param name="reader"></param>
	/// <param name="match"></param>
	/// <exception cref="Exception">如果没读到 match 字符串就结束了会抛出异常</exception>
	public static string ReadLineUntil(this StringReader reader, string match)
	{
		StringBuilder sb = new();
		while (true)
		{
			string? line = reader.ReadLine();
			if (line == null)
			{
				throw new Exception("没读到 match 字符串就结束了");
			}
			else
			{
				sb.AppendLine(line);
				if (line == match) break;
			}
		}

		return sb.ToString();
	}

	/// <summary>
	/// 去除字符串开头和结尾位置的引号和空白符
	/// </summary>
	/// <returns></returns>
	private static string Trim(string value)
	{
		if (value.StartsWith('\"') || value.StartsWith('\''))
		{
			value = value[1..];
		}

		if (value.EndsWith('\"') || value.EndsWith('\''))
		{
			value = value[..^1];
		}

		value = value.Trim();
		return value;
	}
}
