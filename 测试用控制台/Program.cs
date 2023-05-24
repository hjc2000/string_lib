using System.Text;

StringBuilder sb = new();
for (int i = 0; i < 10; i++)
{
	sb.AppendLine(i.ToString());
}

StringReader reader = new(sb.ToString());
while (true)
{
	string? str = reader.ReadLine();
	if (str == null)
		break;
	Console.WriteLine(str);
}