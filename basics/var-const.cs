//si los datos son obvios podemos usar var, sino usamos el tipo de dato correspondiente

var name = "Iñaki";

var age = 23;

const int VALUE = 10;

VALUE = 20 error

var value = Console.ReadLine();
Console.WriteLine(value);

// ejercicio

int num1 = 20;
int num2 = 10;

var remainder = num1 % num2;
Console.WriteLine(remainder);

num1 = 43;

remainder = num1 % num2;
Console.WriteLine(remainder);

//ejercicio

Console.WriteLine("Put your name: ");
string name = Console.ReadLine();

Console.WriteLine("Put your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

Console.WriteLine("your name is " + name + " and your age is " + age);