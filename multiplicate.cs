int num1,
    num2,
    num3;

Console.Write("Ingrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el tercer numero: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El resultado es {num1 * num2 * num3}");