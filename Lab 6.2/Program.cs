using System;

namespace Lab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Тарту дорог как город утрат";
            string s = string.Empty;
            string y = string.Empty;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i].ToString() != " ")
                {
                    s += a[i].ToString().ToLower();
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j].ToString() != " ")
                {
                    y += a[j].ToString().ToLower();
                }
            }
            if (s == y)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }                 
                Console.ReadKey();
        }
    }
}   

