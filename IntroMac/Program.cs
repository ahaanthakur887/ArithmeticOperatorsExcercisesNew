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
    }
}