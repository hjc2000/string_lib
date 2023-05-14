using StringLib;
using System.Text;

Person person = new Person()
{
	Name = "张三",
	Age = 10,
};

MemoryStream memoryStream = new MemoryStream();
Xml.ObjToXmlStream<Person>(person, memoryStream);
memoryStream.Position = 0;
Person? person1 = Xml.XmlStreamToObj<Person>(memoryStream);
if (person1 != null)
{
	Console.WriteLine(person1);
}

public class Person
{
	public string? Name { get; set; }
	public int Age { get; set; }

	public override string ToString()
	{
		return $"姓名：{Name}，年龄：{Age}";
	}
}