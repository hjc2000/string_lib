using System.Text;
using System.Xml.Serialization;

namespace StringLib;
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

	public static T? XmlStreamToObj<T>(Stream xmlStream)
	{
		XmlSerializer xmlSerializer = new(typeof(T));
		return (T?)xmlSerializer.Deserialize(xmlStream);
	}
}
