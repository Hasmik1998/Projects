using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
namespace ConsoleApp3
{
    public  class MyConsole
    {
       

        public void start()
        {
            Console.WriteLine("1-to use existing phonebook  2-to create phonebook");
            int k = Int32.Parse(Console.ReadLine());
                Reading r = new Reading();
                r.Read();
                r.create();
          
           
                Console.WriteLine("enter the number of books you want to add");
                int u = Int32.Parse(Console.ReadLine());
                Phonebook pb = new Phonebook(u);
            
            while (true)
            {
                String n, b;
                if (k == 1)
                {
                    Console.WriteLine("1-add new object 2-search 3-delete 4-show 0-save changes");
                    int c = Int32.Parse(Console.ReadLine());
                   
                    switch (c)
                        {
                            case 0: r.write();
                            break;
                            case 1:
                            Console.WriteLine("name ");
                            n = Console.ReadLine();
                            try
                            {
                           
                                bool containsNum = Regex.IsMatch(n, @"\d");
                                if (containsNum)
                                {
                                throw new InvalidCastException("You should write only letters ");
                                }
                            }
                            catch(InvalidCastException e)
                            {
                                Console.WriteLine("You should write only letters "+e);
                                n = Console.ReadLine();
                            }
                            Console.WriteLine("number ");
                            b = Console.ReadLine();
                            try
                            {
                                bool containsLetter = Regex.IsMatch(b, @"[a-zA-Z]");
                                if (containsLetter)
                                {
                                    throw new InvalidCastException("You should use only digits");
                                }
                            }
                            catch(InvalidCastException e)
                            {
                                Console.WriteLine("You should use onlu digits "+e);
                                b = Console.ReadLine();
                            }
                            if (r.add(n, b))
                                Console.WriteLine("added");
                            else
                                Console.WriteLine("not added");
                                break;
                            case 2:
                            Console.WriteLine("name ");
                            n = Console.ReadLine();
                            try
                            {
                               
                                bool containsNum = Regex.IsMatch(n, @"\d");
                                if (containsNum)
                                {
                                    throw new InvalidCastException("You should write only letters ");
                                }
                            }
                                catch(InvalidCastException e)
                                {
                                    Console.WriteLine("You should write only letters "+e);
                                    n = Console.ReadLine();
                                }
                                Console.WriteLine(r.getPhone(n));
                                break;
                            case 3:
                                Console.WriteLine("name ");
                                n = Console.ReadLine();
                                try
                                {
                                   
                                    bool containsNum = Regex.IsMatch(n, @"\d");
                                    if (containsNum)
                                    {
                                        throw new InvalidCastException("You should write only letters ");
                                    }
                                }
                                catch(InvalidCastException e)
                                {
                                    Console.WriteLine("You should write only letters "+e);
                                    n = Console.ReadLine();
                                }
                                if (r.delete(n))
                                    Console.WriteLine("deleted");
                                else
                                    Console.WriteLine("not found");
                                break;
                            case 4:
                                r.ShowAll();
                                break;
                        }
                }
                else
                    if (k==2)
                    {
                        
                        Console.WriteLine("1-add 2-search 3-delete 4-show 0-add to file");
                        int c = Int32.Parse(Console.ReadLine());
                        switch (c)
                        {
                            case 0: pb.write();
                            break;
                            case 1:
                            Console.WriteLine("name ");
                            n = Console.ReadLine();
                            try
                            {
                           
                                bool containsNum = Regex.IsMatch(n, @"\d");
                                if (containsNum)
                                {
                                throw new InvalidCastException("You should write only letters ");
                                }
                            }
                            catch(InvalidCastException e)
                            {
                                Console.WriteLine("You should write only letters "+e);
                                n = Console.ReadLine();
                            }
                            Console.WriteLine("number ");
                            b = Console.ReadLine();
                            try
                            {
                                bool containsLetter = Regex.IsMatch(b, @"[a-zA-Z]");
                                if (containsLetter)
                                {
                                    throw new InvalidCastException("You should use only digits");
                                }
                            }
                            catch(InvalidCastException e)
                            {
                                Console.WriteLine("You should use onlu digits "+e);
                                b = Console.ReadLine();
                            }
                            if (pb.add(n, b))
                                Console.WriteLine("added");
                            else
                                Console.WriteLine("not added");
                                break;
                            case 2:
                            Console.WriteLine("name ");
                            n = Console.ReadLine();
                            try
                            {
                               
                                bool containsNum = Regex.IsMatch(n, @"\d");
                                if (containsNum)
                                {
                                    throw new InvalidCastException("You should write only letters ");
                                }
                            }
                                catch(InvalidCastException e)
                                {
                                    Console.WriteLine("You should write only letters "+e);
                                    n = Console.ReadLine();
                                }
                                Console.WriteLine(pb.getPhone(n));
                                break;
                            case 3:
                                Console.WriteLine("name ");
                                n = Console.ReadLine();
                                try
                                {
                                   
                                    bool containsNum = Regex.IsMatch(n, @"\d");
                                    if (containsNum)
                                    {
                                        throw new InvalidCastException("You should write only letters ");
                                    }
                                }
                                catch(InvalidCastException e)
                                {
                                    Console.WriteLine("You should write only letters "+e);
                                    n = Console.ReadLine();
                                }
                                if (pb.delete(n))
                                    Console.WriteLine("deleted");
                                else
                                    Console.WriteLine("not found");
                                break;
                            case 4:
                                pb.showAll();
                                break;
                        }
                    }  
            }
        }
    }
}