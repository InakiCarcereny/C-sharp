int age = 23;

age++;
age+=1;
age = age + 1;
Console.WriteLine(age);

age--;
age-=1;
age = age - 1;
Console.WriteLine(age);

age *= 2;
age /= 2; // se basa en el tipo de dato, si fuese por ejemplo un double, me devolveria 2.3

string name = "Iñaki";
name += " is a developer";
Console.WriteLine(name);

string name2 = "Luca";
int age2 = 35;

Console.WriteLine(name2 + " is " + age2 + " years old");

int num1 = 20;
int num2 = 10;

Console.WriteLine(num1 + num2);
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine(num1 / num2);
Console.WriteLine(num1 % num2);