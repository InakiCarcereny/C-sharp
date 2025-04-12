string textAge = "23";
int age = Convert.ToInt32(textAge);
Console.WriteLine(age);

string textBigNumber = "900000000";
long bigNumber = Convert.ToInt64(textBigNumber);
Console.WriteLine(bigNumber);

string textNegative = "-123.456";
double negativeValue = Convert.ToDouble(textNegative);
Console.WriteLine(negativeValue);

string textFloat = "123.456";
float floatValue = Convert.ToSingle(textFloat);
Console.WriteLine(floatValue);

string textDecimal = "123.456";
decimal decimalValue = Convert.ToDecimal(textDecimal);
Console.WriteLine(decimalValue);