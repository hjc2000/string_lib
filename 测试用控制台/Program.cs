using StringLib;

string str = "000123456789";
str = str.SliceMaxOn("12", "56") ?? str;
Console.WriteLine(str);