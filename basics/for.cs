// for (int i = 0; i <= 10; i++)
// {   
//     Console.Write("the iteration number is: ");
//     Console.WriteLine(i);
// }

Console.Write("How many times do you want to say hi: ");
int times = Convert.ToInt32(Console.ReadLine());

const string greeting = "Hello C#";

if (times <= 0)
{
    Console.WriteLine("Invalid number");
}
else
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(greeting);
    }
}