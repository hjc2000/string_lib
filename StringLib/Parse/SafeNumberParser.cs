using System.Globalization;
using System.Numerics;

namespace StringLib.Parse;

/// <summary>
/// 不会抛出异常的 parser，分析字符串，返回数值类型。分析失败会返回 0。
/// 能够自动识别 16 进制数和 10 进制数的字符串。（要求 16 进制数的字符串以 0x 前导符开始，10 进制数
/// 没有任何修饰符）
/// </summary>
public static class SafeNumberParser
{
	public static sbyte ParseInt8(string str)
	{
		try
		{
			return str.StartsWith("0x") ? sbyte.Parse(str, NumberStyles.HexNumber) : sbyte.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static byte ParseUint8(string str)
	{
		try
		{
			return str.StartsWith("0x") ? byte.Parse(str, NumberStyles.HexNumber) : byte.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static short ParseInt16(string str)
	{
		try
		{
			return str.StartsWith("0x") ? short.Parse(str, NumberStyles.HexNumber) : short.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static ushort ParseUint16(string str)
	{
		try
		{
			return str.StartsWith("0x") ? ushort.Parse(str, NumberStyles.HexNumber) : ushort.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static int ParseInt32(string str)
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

	public static uint ParseUInt32(string str)
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

	public static ulong ParseUInt64(string str)
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

	public static long ParseInt64(string str)
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

	public static double ParseDouble(string str)
	{
		try
		{
			return str.StartsWith("0x") ? double.Parse(str, NumberStyles.HexNumber) : double.Parse(str);
		}
		catch
		{
			return 0;
		}
	}

	public static BigInteger ParseBigInt(string str)
	{
		try
		{
			return str.StartsWith("0x") ? BigInteger.Parse(str, NumberStyles.HexNumber) : BigInteger.Parse(str);
		}
		catch
		{
			return 0;
		}
	}
}
