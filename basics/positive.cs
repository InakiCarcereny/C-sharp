int number;

Console.Write("Ingrese un número: "); 
number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
  Console.WriteLine("El número es positivo");
}
else
{
  Console.WriteLine("El número es negativo");
}