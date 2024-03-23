using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq 1
            //Console.WriteLine(Name());

            //Tapşırıq 2
            //Number(10);


            //Tapşırıq 4

            //Console.WriteLine("Soz daxil edin");
            //string text = Console.ReadLine();
            //if (palindrom(text))
            //{
            //    Console.WriteLine(text + " palindromdur.");
            //}
            //else
            //{
            //    Console.WriteLine(text + "  palindrom deyil!");
            //}



            //Tapşırıq 3
            //StringText();

        }

        //static string Name(string text)
        //{
        //    Tapşırıq 1
        //    string Text="Ali Sadat Nicat Mirqubad";
        //    string A = "";

        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        A += text[i];

        //    }
        //    return A;
        //}



        //Tapşırıq 2

        //static void Number(int n)
        //{
        //    Console.WriteLine("Ededi daxil edin");
        //    n=Convert.ToInt32(Console.ReadLine());
        //    int num = 0;
        //    while (n>0)
        //    {


        //        num *= 10;

        //        num += n % 10;
        //        n /= 10;
        //    }
        //     Console.WriteLine(num);

        //}


        //Tapşırıq 4

        //static bool palindrom(string text)
        //{

        //    for (int i = 0; i < text.Length / 2; i++)
        //    {
        //        if (text[i] != text[text.Length - i - 1])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        //static void StringText()
        //{
           
        //    Console.Write("Cumleni daxil edin ");
        //    string name = Console.ReadLine();

        //    char[] letters = name.ToCharArray();
            
        //    byte[] counter = new byte[name.Length];

        //    for (int i = 0; i < letters.Length; i++)
        //    {
        //        for (int j = 0; j < name.Length; j++)
        //        {
        //            if (letters[i] == name[j])
        //            {
        //                counter[i]++;
        //            }
        //        }
        //    }

        //    Console.WriteLine($"{name} cumlesinde ");

        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        Console.WriteLine($"{counter[i]} eded {letters[i]} herfi var.");
        //    }
        //    Console.ReadLine();
        //}
    }
}
