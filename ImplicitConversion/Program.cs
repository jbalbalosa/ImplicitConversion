// See https://aka.ms/new-console-template for more information


//Implicit convresion
int myInt = 13;
double myDouble = myInt; // double can hold the int information
long myLong = 1323450632514; // long can hold the Long information

//Explicit conversion
int myInt2 = (int)myLong;
Console.WriteLine($"{myInt2}");

//Conversion helpers parse and convert
string numberString = "123";
int result = int.Parse( numberString );
Console.WriteLine("Parsing: "+result);

string myBoolString = "true";
bool myBool = Convert.ToBoolean( myBoolString );
Console.WriteLine("myBool is "+myBool);

Console.ReadKey();
