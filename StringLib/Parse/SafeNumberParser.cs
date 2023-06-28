using System.Globalization;

namespace StringLib.Parse;

/// <summary>
/// 不会抛出异常的 parser，分析字符串，返回数值类型。分析失败会返回 0
/// </summary>
public static class SafeNumberParser
{
	public static int SafeParseInt32(string str)
	{
		try
		{
			return str.StartsWith("0x") ? int.Parse(str, NumberStyles.HexNumber) : int.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static uint SafeParseUInt32(string str)
	{
		try
		{
			return str.StartsWith("0x") ? uint.Parse(str, NumberStyles.HexNumber) : uint.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static ulong SafeParseUInt64(string str)
	{
		try
		{
			return str.StartsWith("0x") ? ulong.Parse(str, NumberStyles.HexNumber) : ulong.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static long SafeParseInt64(string str)
	{
		try
		{
			return str.StartsWith("0x") ? long.Parse(str, NumberStyles.HexNumber) : long.Parse(str);
		}
		catch
		{
			return 0;
		}
	}
}
