// int i;

// while (i < 10)
// {
//     Console.WriteLine(i);
//     i++;
// }

int age = 10;

bool condition = age >= 10;

string isValid = condition ? "valid" : "invalid";

Console.WriteLine(isValid);

Console.Write("Ingresa un numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingresa otro numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int answer = num1 * num2;
int currentAnswer = 0;

// while(answer != currentAnswer)
// {
//   Console.WriteLine($"Cual es el resultado de {num1} * {num2}");
//   currentAnswer = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Respuesta correcta");

do
{
  Console.Write($"Cual es el resultado de {num1} * {num2}: ");
  currentAnswer = Convert.ToInt32(Console.ReadLine());
} while (answer != currentAnswer);

Console.WriteLine();
Console.WriteLine("Respuesta correcta");
