using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_L2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    ArrayList c_list = new ArrayList();
                    Queue<string> Q1 = new Queue<string>();     //waiting queue of senior citizen and females
                    Queue<string> Q2 = new Queue<string>();     //waiting queue of all other males.
                    Queue<string> Q3 = new Queue<string>();
                    Queue<string> Q4 = new Queue<string>();
                    Queue<string> Q5 = new Queue<string>();
                    String choice;
                    int age;
                    Char gender;
                    string name;
                    do
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("      C U S T O M E R S    I N F O ");
                        Console.WriteLine("----------------------------------------");
                        for (int customer = 1; customer <= 2; customer++)
                        {

                            Console.WriteLine("          Customer {0}", customer);
                            Console.WriteLine("         ------------   ");
                            Console.Write("Name :: ");
                            name = Console.ReadLine();

                            Console.Write("Age :: ");
                            age = int.Parse(Console.ReadLine());
                            Console.Write("Gender ::");
                            gender = Convert.ToChar(Console.ReadLine());

                            Console.WriteLine("         ------------   ");

                            c_list.Add(name);      //add names of all customers in arraylist

                            if (age >= 60 || gender == 'f' || gender == 'F')
                            {
                                Q1.Enqueue(name);       //insert values in Queue 1.
                                Q1.Dequeue();
                                Q3.Enqueue(name);
                                Q3.Dequeue();
                                Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                Console.WriteLine("Mr/Ms : " + name + " Thanks for shopping here!");
                                Console.WriteLine("Cash Counter :: 3");
                                Console.WriteLine("Check Out");
                                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");

                            }
                            else
                            {
                                Q2.Enqueue(name);       //insert values in Queue 2.
                                Q2.Dequeue();
                                if (customer % 2 == 0)
                                {
                                    Q4.Enqueue(name);   //insert values in Queue 4.
                                    Q4.Dequeue();
                                    Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                    Console.WriteLine("Mr : " + name + " Thanks for shopping here!");
                                    Console.WriteLine("Check Out");
                                    Console.WriteLine("Cash Counter :: 1");
                                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                                }
                                else
                                {
                                    Q5.Enqueue(name);   //insert values in Queue 5.
                                    Q5.Dequeue();
                                    Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                    Console.WriteLine("Mr : " + name + " Thanks for shopping here!");
                                    Console.WriteLine("Check Out");
                                    Console.WriteLine("Cash Counter :: 2");
                                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                                }
                            }
                        }




                        Console.WriteLine("\n\n\n------------------------------------------");
                        Console.WriteLine("List of all Customers :: ");
                        Console.WriteLine("-------------------------------------------");
                        foreach (string i in c_list)
                        {

                            Console.WriteLine(i);   //Display ArrayList(customers)
                        }
                        Console.WriteLine("-------------------------------------------\n\n\n");
                        Console.Write("\nDo you want to Enter more customer (Press Y to continue ) ::");
                        choice = Console.ReadLine();

                    } while (choice == "Y" || choice == "y");
                    
                }catch(Exception)
                {
                Console.WriteLine("Please Enter Valid Inputs !! ");
                }
            Console.ReadLine();
        }
    

        

    }
}
