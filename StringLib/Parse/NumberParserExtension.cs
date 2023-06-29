using System.Globalization;
using System.Numerics;

namespace StringLib.Parse;

/// <summary>
/// 分析字符串返回数字，兼容十六进制和十进制。失败会抛出异常
/// </summary>
public static class NumberParserExtension
{
	public static sbyte ToInt8(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return sbyte.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return sbyte.Parse(str);
		}
	}

	public static byte ToUint8(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return byte.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return byte.Parse(str);
		}
	}

	public static short ToInt16(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return short.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return short.Parse(str);
		}
	}

	public static ushort ToUint16(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return ushort.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return ushort.Parse(str);
		}
	}

	public static int ToInt32(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return int.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return int.Parse(str);
		}
	}

	public static uint ToUInt32(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return uint.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return uint.Parse(str);
		}
	}

	public static ulong ToUInt64(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return ulong.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return ulong.Parse(str);
		}
	}

	public static long ToInt64(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return long.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return long.Parse(str);
		}
	}

	public static double ToDouble(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return double.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return double.Parse(str);
		}
	}

	public static BigInteger ToBigInt(this string str)
	{
		if (str.StartsWith("0x"))
		{
			str = str[2..];
			return BigInteger.Parse(str, NumberStyles.HexNumber);
		}
		else
		{
			return BigInteger.Parse(str);
		}
	}
}
