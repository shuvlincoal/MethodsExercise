namespace MethodsExercise
{

    public class Bogon
    {
        public static void UserInquiry()
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
        }//End UserInquiry
    }//End Bogon


    public class MathLib
    {
            public static int Add(params int[] numbers)
            {
                int sumNbrs = 0;
                foreach (int num in numbers)
                {
                    sumNbrs = sumNbrs + num;
                }
                return sumNbrs;
            }

            public static int Subtract(int num1, int num2)
                {
                   return num1 - num2;
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

            public static int Divide(int num1, int num2)
            {
               return num1 / num2;
            }
    }//End MathLib



    public class Program
    {
        public static void Main(string[] args)
        {
            int blahInt = MathLib.Add(4, 5);
            Console.WriteLine($"Sum of nbr1 and nbr2 is {blahInt}");

            int fooInt = MathLib.Multiply(4, 5);
            Console.WriteLine($"Product of nbr1 and nbr2 is {fooInt}");

            Bogon.UserInquiry();


        }
    }//End Class Program


}//End Namespace MethodsExercise
