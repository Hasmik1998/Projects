using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Letter_Changer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<string> a = new List<string>();
            StreamReader r = new StreamReader("test.txt");
            Console.WriteLine("Enter the latter that you want to cahnge");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the new latter");
            string str2 = Console.ReadLine();
            read();
            replace();
            Write();

            void read()
            {
                string line = null;
                while ((line = r.ReadLine()) != null)
                {
                    a.Add(line);
                    i++;
                }
            }

            void replace()
            {
                for (int j = 0; j < i; j++)
                {
                    a[j] = a[j].Replace(str1, str2);
                }
            }


            void Write()
            {
                StreamWriter w = new StreamWriter("test.txt");
                for (int j = 0; j < i; j++)
                {
                    w.Write(a[j]);
                    w.WriteLine();
                }

                w.Close();
            }
        }
    }
}