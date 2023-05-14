using System.Text;
using System.Xml.Serialization;

namespace StringLib;
public static class Xml
{
	public static string ObjToXml<T>(object? o)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		MemoryStream memoryStream = new MemoryStream();
		using (memoryStream)
		{
			xmlSerializer.Serialize(memoryStream, o);
			return Encoding.UTF8.GetString(memoryStream.ToArray());
		}
	}

	public static void ObjToXmlStream<T>(object? o, Stream stream)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		xmlSerializer.Serialize(stream, o);
		stream.Position = 0;
	}

	public static T? XmlToObj<T>(string xml)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		byte[] buff = Encoding.UTF8.GetBytes(xml);
		MemoryStream memoryStream = new MemoryStream(buff);
		using (memoryStream)
		{
			return (T?)xmlSerializer.Deserialize(memoryStream);
		}
	}

	public static T? XmlStreamToObj<T>(Stream xmlStream)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		return (T?)xmlSerializer.Deserialize(xmlStream);
	}
}
