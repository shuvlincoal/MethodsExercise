namespace MethodsExercise
{
    public class Program
    {
        //public static int Add(int nbr1, int nbr2)
        //{
        //    int sumNbrs = nbr1 + nbr2;
        //    return sumNbrs;
        //}

        //public static int Multiply(int nbr1, int nbr2)
        //{
        //    int prodNbrs = nbr1 * nbr2;
        //    return prodNbrs;
        //}
        public static int Add(params int[] numbers)
        {
            int sumNbrs = 0;
            foreach (int num in numbers)
            {
                sumNbrs = sumNbrs + num;
            }
            return sumNbrs;
        }

        public static int Multiply(params int[] numbers)
        {
            int prodNbrs = 1;
            foreach (int num in numbers)
            {
                prodNbrs = prodNbrs * num;
            }
            return prodNbrs;
        }


        public static void GreetingMsg()
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



        public static void Main(string[] args)
        {
            Program.GreetingMsg();

            int blahInt = Program.Add(4, 5);
            Console.WriteLine($"Sum of nbr1 and nbr2 is {blahInt}");

            int fooInt = Program.Multiply(4, 5);
            Console.WriteLine($"Product of nbr1 and nbr2 is {fooInt}");


        }



    }
}
