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
		catch
		{
			return 0;
		}
	}

	public static byte ParseUint8(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static short ParseInt16(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static ushort ParseUint16(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static int ParseInt32(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static uint ParseUInt32(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static ulong ParseUInt64(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static long ParseInt64(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static double ParseDouble(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}

	public static BigInteger ParseBigInt(string str)
	{
		try
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
		catch
		{
			return 0;
		}
	}
}
