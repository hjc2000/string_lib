using StringLib;
string str = "name=a";
(bool success, string key, string value) = str.ParseKeyValue();
if (success)
{
	Console.WriteLine($"{key}={value}");
}