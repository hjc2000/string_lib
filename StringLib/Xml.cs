using System.Text;
using System.Xml.Serialization;

namespace StringLib;

public class XmlDeserializeException : Exception
{
	public XmlDeserializeException(string? message, Exception? innerException) : base(message, innerException)
	{

	}
}

public static class Xml
{
	public static string ObjToXml<T>(object? o)
	{
		XmlSerializer xmlSerializer = new(typeof(T));
		MemoryStream memoryStream = new();
		using (memoryStream)
		{
			xmlSerializer.Serialize(memoryStream, o);
			return Encoding.UTF8.GetString(memoryStream.ToArray());
		}
	}

	public static void ObjToXmlStream<T>(object? o, Stream stream)
	{
		XmlSerializer xmlSerializer = new(typeof(T));
		xmlSerializer.Serialize(stream, o);
		stream.Position = 0;
	}

	public static T? XmlToObj<T>(string xml)
	{
		XmlSerializer xmlSerializer = new(typeof(T));
		byte[] buff = Encoding.UTF8.GetBytes(xml);
		MemoryStream memoryStream = new(buff);
		using (memoryStream)
		{
			return (T?)xmlSerializer.Deserialize(memoryStream);
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
			throw new XmlDeserializeException("XmlStreamToObj 错误", ex);
		}
	}
}
