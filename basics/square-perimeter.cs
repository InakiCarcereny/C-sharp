static void Main(string[] args)
{
  int side;
  int perimeter;

  Console.WriteLine("Ingrese el lado del cuadrado: ");
  side = Convert.ToInt32(Console.ReadLine());
  perimeter = 4 * side;
  Console.Write("El perímetro es: " + perimeter);
  Console.Write($"El perimetro es: {perimeter}");
}