namespace StringLib
{
	public static class Parse
	{
		public static (bool success, string key, string value) ParseKeyValue(this string str)
		{
			try
			{
				str = str.Trim();
				int index = str.IndexOf('=');
				string key = str.Substring(0, index);
				string value = str.Substring(index + 1);
				return (true, key, value);
			}
			catch
			{
				return (false, string.Empty, string.Empty);
			}
		}
	}
}
