namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Sum(5,7,9));
            //metod 3 deyer qebul etsin cemin qaytarsin
            //ad soyad yas metodu 
            Console.WriteLine(Info("Fexi","Cabbarli",17));
            Console.WriteLine(Info("Ulvi","Filankesov",19));
        }
        static int Sum(int a, int b,int c)
        {
            return a + b + c;
        }
        static string Info(string a, string b, int c)
        {
            //    return a + " "+b + " "+c;
            return $"{a} {b} {c}";

        }

    }
}
