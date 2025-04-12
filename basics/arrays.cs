namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            int[] numbers = new int[3];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            int[] numbers2 = new int[3];

            numbers2[0] = 1;
            numbers2[1] = 2;
            numbers2[2] = 3;

            Console.WriteLine($"{num1}, {num2}, {num3}");
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int num in numbers2)
            {
                Console.WriteLine(num);
            }


            const int ANGLE_COUNT = 3;
            int[] angles = new int[ANGLE_COUNT];
            int angles_sum = 0;

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
                angles_sum += angles[i];
            }

            Console.WriteLine(angles_sum == 180 ? "Valid" : "Invalid");
        }
    }
}
