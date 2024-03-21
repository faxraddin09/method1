using System.Numerics;

namespace metod_2
{
    internal class Program
    {//iki parametr qebul olsun ve birinci parametri ikinciye bolmek
        static void Main(string[] args)
        {
            Sum(12);
            Console.WriteLine(division(10, 2));
        }

        static int division(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
