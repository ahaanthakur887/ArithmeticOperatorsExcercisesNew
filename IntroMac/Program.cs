namespace IntroMac
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(Circumference(5));
            Console.WriteLine(Area(10));
            Console.WriteLine(ExactlyDivisible(8, 4));
            Console.WriteLine($"The hypotenuse is {Pythagoras(3, 4)}");
            Console.WriteLine(BooksPerStudent());
            Console.WriteLine(BlocksToStore(1.1));
            Console.WriteLine(PocketMoneySavings());
            Console.ReadLine();
        }

        static double Circumference(double radius)
        {
            double output = Math.PI * (2 * radius);
            return Math.Round(output, 2);
        }

        static double Area(double radius)
        {
            double output = Math.PI * Math.Pow(radius, 2);
            return Math.Round(output, 2);
        }

        static bool ExactlyDivisible(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double Pythagoras(double side1, double side2)
        {
            double output = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            return Math.Sqrt(output);
        }

        static string BooksPerStudent()
        {
            Console.WriteLine("How many students are there?");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many books are there?");
            int books = Convert.ToInt32(Console.ReadLine());
            int DividedEqually = books / students;
            int LeftOver = books - (DividedEqually * students);
            return $"The number of books per student is : {DividedEqually}. The number of books left over is : {LeftOver}";
        }

        static int BlocksToStore(double FileSize)
        {
            double BlockSize = 512;
            int output = Convert.ToInt32(Math.Ceiling((FileSize * 1024) / BlockSize));
            return output;
        }

        static string PocketMoneySavings()
        {
            Console.WriteLine("How much pocket money do you get a week?");
            double Money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What percentage of this do you want to save?");
            double Percentage = Convert.ToDouble(Console.ReadLine());
            double SavingsPerWeek = Math.Round(Money * (Percentage / 100), 2);
            double SavingsPerYear = SavingsPerWeek * 52;
            return $"The amount of money saved per week is : {SavingsPerWeek}. The amount of money saved per year is : {SavingsPerYear}.";
        }
    }
}