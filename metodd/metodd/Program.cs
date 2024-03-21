using System.Data;

namespace metodd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Name = { "Filankes", "Ulvi" };
            Console.WriteLine(Names(Name));
            int[] num = { 1, 2, 3, 4, 5, };
            Console.WriteLine(Sum(num));
            //string massive qebul eden bir metod yazin massivin icerisinde "fexi"varsa true eks halda false qaytaran
            //bool massive qebul eden metod yazin icerisinde nece dene true varsa onu qaytarsin



        }
        static int Name(bool[] arr)
        {      
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    result++;GCCollectionMode 
                }
            }
            return result;
        }
        static bool Names(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "Fexi")
                {
                    return true;
                }
            }
            return false;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    result += arr[i];
                }

            }
            return result;
        }
    }

}
