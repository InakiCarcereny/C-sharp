int nota;

Console.Write("Ingrese una nota: ");
nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 80 && nota <= 100)
{
  Console.WriteLine("Nota promocionada");
}
else if (nota >= 60)
{
  Console.WriteLine("Nota aprobada");
}
else {
  Console.WriteLine("Nota desaprobada");
}