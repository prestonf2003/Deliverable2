using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestonDeliverable2
{
    class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to our buffet. It is all you can eat for $9.99! We only charge $1.00 extra for our soda. How many people will be joining us today?, Please parties of 6 or lower.");
            string p = (Console.ReadLine());
            int NumberOfPeople;
            bool success = int.TryParse(p, out NumberOfPeople);
            bool valid = success && NumberOfPeople < 7;
       
            while (!valid)
            {
                Console.WriteLine("Sorry we do not serve parties greater than 6 have a blessed day");
                Environment.Exit(0);
            }

                

            
                int numbWater = 0;
                int numbSoda = 0;
                Decimal totalBill = 0;
                Console.WriteLine($"\r\nAlright a table for {p} Follow me and I will show you to your table");
                Console.WriteLine("Lets get everyone started with some drinks. We have soda and water as our options today");


               
     
                for (int i = 0; i < NumberOfPeople; i++)
                {
                    Console.WriteLine($"Hello person number  {i + 1}   water or soda");
                    string drink = Console.ReadLine().ToLower();

                    if (drink != "water" && drink != "soda")
                    {
                        Console.WriteLine("We don't have that no drink for you!");

                    }
                    else if (drink == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        numbWater++;
                    }
                    else
                    {
                        Console.WriteLine("Soda great!");
                        numbSoda++;
                    }
                    Console.WriteLine("Okay so that's " + numbWater + " water(s) and " + numbSoda + " soda(s)");
                    totalBill = (decimal)NumberOfPeople * 9.99M + (decimal)numbWater * 0 + (decimal)numbSoda * 2;
                    Console.WriteLine($"Heres you check the total came out to be:  ${totalBill}");

                }

          
            }
        }
    }


