using System;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp3
{
    public class Reading
    {
        public List<string> arr = new List<string>();
        public List<Entry> a;
        public int n;
        StreamReader sr = new StreamReader("names.txt");
        public Reading()
        {
        }

        public void Read()
        {
            int i = 0;
            string line;
            while ((line=sr.ReadLine()) != null)
            {
                arr.Add(line); 
                i++;
            }
            n = i;
        }
        public void create()
        {
         a= new List<Entry>();
            
            int i = 0;
            foreach (var k in arr)
            {
                string[] line1 = k.Split("  ");
                a.Insert(i,new Entry(line1[0],line1[1]));
                i++;
            }
        }

        public bool add(string name, string number)
        {
            a.Add(new Entry(name,number));
            n++;
            return true;
        }

        public bool delete(string name)
        {
            int i; 
            for (i = 0; i < n; ++i)
                if (a[i].name.Equals(name)) break;
            if (i == n) return false;
            for (int j = i; j < n-1; j++)
                a[j] = a[j+1];
            a[n - 1] = null;
            n -= 1;
            return true;
        }

        public string getPhone(string x) {
            int i;
            for (i = 0; i < n; ++i)
                if (a[i].name.Equals(x)) break;
            if (i == n) return null;
            return a[i].number;
        }
        
        public void ShowAll()
        {
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].name+"  "+a[i].number);
            }
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