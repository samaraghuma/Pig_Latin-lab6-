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

                // string word;
                Console.WriteLine("welcome to the pig latin translator!  enter a line to be translated");
                string input = Console.ReadLine();
                string[] ar = input.Split(' ');
                foreach (string word in ar)
                {

                    string w = "";

                    //word = Console.ReadLine();

                    string v = "aeiou";
                    if (v.Contains(word.ToLower()[0]))
                    {
                        Console.WriteLine(word + "way");

                    }
                    else
                    {
                        string a;

                        char[] v1 = { 'a', 'e', 'i', 'o', 'u' };
                        int i = word.IndexOfAny(v1);
                        a = word.Substring(i);
                        w = word.Remove(word.IndexOf(a));
                        w = a + w;
                        Console.WriteLine(w + "ay");
                     //   Console.WriteLine("do you want to translate other line(yes/no)");
                       // continuee = Console.ReadLine();
                    }
                }
                Console.WriteLine("do you want to translate other line(yes/no)");
                continuee = Console.ReadLine();
            }
            while (continuee == "yes");
            

        }
            

        }
    }

