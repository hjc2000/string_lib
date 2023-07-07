namespace StringLib.Parse;
public static class UrlPharser
{
	/// <summary>
	/// * 将类似 http://localhost:9000/web/ 的 url 取出其中的基础部分
	/// http://localhost:9000/ 进行返回
	/// * 解析失败会返回空字符串
	/// </summary>
	/// <returns></returns>
	public static string GetBaseUrl(this string url)
	{
		try
		{
			int index1 = url.IndexOf("//");
			int index2 = url.IndexOf("/", index1 + 2);
			return url[..(index2 + 1)];
		}
		catch
		{
			return string.Empty;
		}
	}
}
