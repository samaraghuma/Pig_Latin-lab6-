using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string continuee;
            do
            {

                string word;
                Console.WriteLine("welcome to the pig latin translator!  enter a line to be translated");

                word = Console.ReadLine();
                word = word.ToLower();
                string v = "aeiou";
                if (v.Contains(word[0]))
                {
                    Console.WriteLine(word + "way");
                    Console.WriteLine("do you want to translate other line(yes/no)");
                    continuee = Console.ReadLine();
                }
                else
                {
                    string a;

                    char[] v1 = { 'a', 'e', 'i', 'o', 'u' };
                    int i = word.IndexOfAny(v1);
                    a = word.Substring(i);
                    word = word.Remove(word.IndexOf(a));
                    word = a + word;
                    Console.WriteLine(word + "ay");
                    Console.WriteLine("do you want to translate other line(yes/no)");
                    continuee = Console.ReadLine();
                }
            }
            while (continuee == "yes");

    {

            }

        }
    }
}
