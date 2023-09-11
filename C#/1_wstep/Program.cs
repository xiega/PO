/*Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");*/
Console.WriteLine("Hello, World!");
Console.WriteLine("abc");

//typy danych
int i = 10; //32 bity - 4 bajty
Int16 j = 10; //16 bitów - 2 bajty
System.Int64 k = 10; //64 bity - 8 bajtów

long l = 10; //64 bity

float f = 10.5F; //32 bity
Console.WriteLine(f);

double d = 11.24; //64 bity
Console.WriteLine(d);

decimal dec = 10.5m; //128 bitów - 16 bajtów

string text;
text = d.ToString();
Console.WriteLine(text);

bool check = true;
Console.WriteLine(check);
bool check2 = true;
Console.WriteLine(check2);

Console.WriteLine(byte.MinValue); //0 - 8 bitów
Console.WriteLine(byte.MaxValue); //255

Console.WriteLine(sbyte.MinValue); //-128
Console.WriteLine(sbyte.MaxValue); //127

Console.WriteLine(sizeof(byte)); //1 bajt

Console.WriteLine(sizeof(short)); //2 bajty
Console.WriteLine(sizeof(char)); //2 bajty

Console.WriteLine(sizeof(ushort)); //2 bajty