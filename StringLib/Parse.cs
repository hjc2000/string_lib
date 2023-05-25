namespace StringLib;

public static class Parse
{
	public static (bool success, string key, string value) ParseKeyValue(this string str)
	{
		try
		{
			str = str.Trim();
			int index = str.IndexOf('=');
			string key = str[..index];
			string value = str[(index + 1)..];
			if (value.StartsWith('\"') || value.StartsWith('\''))
			{
				value = value[1..];
			}

			if (value.EndsWith('\"') || value.EndsWith('\''))
			{
				value = value[..^1];
			}

			return (true, key, value);
		}
		catch
		{
			return (false, string.Empty, string.Empty);
		}
	}
}
