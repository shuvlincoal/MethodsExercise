namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?: ");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?: ");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?: ");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?: ");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{userName} dyes his hair {favColor}");
            Console.WriteLine($" while riding a {favAnimal} listening");
            Console.WriteLine($"to {favBand}");
        }
    }
}
