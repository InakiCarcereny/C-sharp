static void main(string[] args)
{
  const double PI = 3.14;
  int radius = Convert.ToInt32(Console.ReadLine());

  double area = PI * radius * radius;
  Console.Write("El area es: " + area);
}