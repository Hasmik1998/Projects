using System;
using System.IO;
namespace ConsoleApp3
{
    public class Phonebook
    {
        Entry[] a;
        int n; 
        int N = 100; 
   
        public  Phonebook() {
            a = new Entry[N];
            n = 0;
        }
   
        public Phonebook(int x) {
            a = new Entry[x];
            N = x; 
            n = 0; 
        }
   
        public Boolean add(string name, string phone) {
            if (n == N) return false;
            a[n] = new Entry(name, phone);
            n++;
            return true;
        }
   
        public string getPhone(string x) {
            int i;
            for (i = 0; i < n; ++i)
                if (a[i].name.Equals(x)) break;
            if (i == n) return null;
            return a[i].number;
        }
   
        public Boolean delete(string x)
        {
            int i; 
            for (i = 0; i < n; ++i)
                if (a[i].name.Equals(x)) break;
            if (i == n) return false;
            for (int j = i; j < n-1; j++)
                a[j] = a[j+1];
            a[n - 1] = null;
            n -= 1;
            return true;
        }
   
        public void showAll() {
            for (int i = 0; i < n; ++i)
                Console.WriteLine(a[i].name+" "+a[i].number);
        }

        public Boolean write()
        {
            StreamWriter sw = new StreamWriter("names.txt");
           
            for (int i = 0; i < n; i++)
            {
               sw.Write(a[i].name);
                sw.Write("  ");
               sw.Write(a[i].number);
                sw.WriteLine();
            }
            sw.Close();

            return true;
        }
    }
}