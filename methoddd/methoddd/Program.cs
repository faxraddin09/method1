using System.Threading.Channels;

namespace methoddd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region overloading
            //string word = "Fexi";
            //    foreach (char s in word)
            //    {
            //        Console.WriteLine(s);
            //    }
            ////    Console.WriteLine(Print("Fexi"));
            //    Console.WriteLine(Print("Fexi", "Cabbarli"));
            //    Console.WriteLine(Print("Fexi", "Cabbarli", "Baku"));

            //}
            //static string Print(string name)
            //{
            //    return name;
            //}
            //static string Print(string name, string surname)
            //{
            //    return name + " " + surname;

            //}
            //static string  Print (string name,string surname,string adress)
            //
            //    return name + " " + surname + " " + adress;
            #endregion
            //Verilmiş strigin ilk 4 hərfini ekrana yazdırın."salam fexi necesen"
            CutString("salam fexi necesen");
        }
        static void CutString(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
               if(count == 5)
                {
                    break;
                }
                count++;
                Console.WriteLine(c);
            }
        }
    }
}
