using System.Text;
using System.Xml.Serialization;

namespace StringLib;

/// <summary>
/// XML 反序列化错误
/// </summary>
public class XmlDeserializeException : Exception
{
	public XmlDeserializeException() { }
	public XmlDeserializeException(string? message, Exception? innerException) : base(message, innerException) { }
}

/// <summary>
/// XML 序列化错误
/// </summary>
public class XmlSerializeException : Exception
{
	public XmlSerializeException() { }
	public XmlSerializeException(string? message, Exception? innerException) : base(message, innerException) { }
}

public static class Xml
{
	#region 序列化
	/// <summary>
	/// 将对象序列化为 XML 字符串
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="o"></param>
	/// <returns></returns>
	/// <exception cref="XmlSerializeException"></exception>
	public static string ObjToXml<T>(object? o)
	{
		try
		{
			XmlSerializer xmlSerializer = new(typeof(T));
			using MemoryStream memoryStream = new();
			xmlSerializer.Serialize(memoryStream, o);
			return Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception e)
		{
			throw new XmlSerializeException("ObjToXml error", e);
		}
	}

	/// <summary>
	/// 将对象序列化为包含 XML 的流
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="o"></param>
	/// <param name="stream"></param>
	/// <exception cref="XmlSerializeException"></exception>
	public static void ObjToXmlStream<T>(object? o, Stream stream)
	{
		try
		{
			XmlSerializer xmlSerializer = new(typeof(T));
			xmlSerializer.Serialize(stream, o);
		}
		catch (Exception e)
		{
			throw new XmlSerializeException("ObjToXmlStream error", e);
		}
	}
	#endregion

	#region 反序列化
	/// <summary>
	/// 将 XML 字符串反序列化为对象
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="xml"></param>
	/// <returns></returns>
	/// <exception cref="XmlDeserializeException"></exception>
	public static T? XmlToObj<T>(string xml)
	{
		try
		{
			XmlSerializer xmlSerializer = new(typeof(T));
			byte[] buff = Encoding.UTF8.GetBytes(xml);
			using MemoryStream memoryStream = new(buff);
			return (T?)xmlSerializer.Deserialize(memoryStream);
		}
		catch (Exception e)
		{
			throw new XmlDeserializeException("XmlToObj error", e);
		}
	}

	/// <summary>
	/// 将含有 xml 的流反序列化为对象
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="xmlStream"></param>
	/// <returns></returns>
	/// <exception cref="XmlDeserializeException"></exception>
	public static T? XmlStreamToObj<T>(Stream xmlStream)
	{
		try
		{
			XmlSerializer xmlSerializer = new(typeof(T));
			return (T?)xmlSerializer.Deserialize(xmlStream);
		}
		catch (Exception ex)
		{
			throw new XmlDeserializeException("XmlStreamToObj error", ex);
		}
	}
	#endregion
}
