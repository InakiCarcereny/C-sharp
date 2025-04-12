Console.WriteLine("Put your name: ");
string name = Console.ReadLine();

Console.WriteLine("Put your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

if (age == 18)
{
    Console.WriteLine("You are an adult");
}
else
{
    Console.WriteLine("You are a child");
}