using System;

namespace Part_3_Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            double leg1;
            double leg2;
            double hypotenuse;
            static extern double Sqrt(double d);

            Console.WriteLine("Enter first leg length: ");
            leg1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second leg length: ");
            leg2 = Convert.ToDouble(Console.ReadLine());

            hypotenuse = (Math.Sqrt(leg1 * 2) + (leg2 * 2));

            Console.WriteLine("The hypotenuse is: " + hypotenuse);
            Console.ReadLine();
        }
    }
}
