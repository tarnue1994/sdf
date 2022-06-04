
    
using System;

public class BillCalculator
{
    public static void Main(string[] args)
    {
        string package; // nititalize package variable
          string customerName; // initialize customer name variable
          int hours;// initiate the hours that will be entered
          decimal bill = 0.0M;
          decimal costPerMin = 0.08M; // cost per minute is a constant in the problem
          decimal packageAprice = 9.95M;
          decimal packageBprice = 14.95M;
          decimal packageCprice = 19.95M;

          // prompt user to enter his/her name 
          Console.WriteLine("What is your name");
          customerName = Console.ReadLine();
          // prompt user for the package 
          Console.WriteLine(" Which package do you want? Enter A, B or C only");
          package =  Console.ReadLine();
          // prompt user for num of hours used 
          Console.WriteLine("How many hours uded");
          hours = int.Parse(Console.ReadLine());

        if(package == "A")
        {
            if(hours > 5)
            {
               bill  = packageAprice+(hours-5)*costPerMin*60;
            }
            else
            {
                bill = packageAprice;
            }
        }
        else if(package == "B")
        {
            if(hours > 10)
            {
                bill = packageBprice+(hours-10)*costPerMin*60;
            }
            else
            {
                bill = packageBprice;
            }
        }
         else if(package == "C")
            {
               bill = packageCprice; 
            }
        else
        {
            Console.WriteLine("ERROR!::::You musPlease enter only A, B, or C for a package");
        }

        // designe the bill out put 
        Console.WriteLine(":::::: CUSTOMER BILL SUMMARY  ::::::");
        Console.WriteLine("____________________________________");
        Console.WriteLine("1 Customer Name:....... "+customerName);
        Console.WriteLine("2 Package:............. "+package);
        Console.WriteLine("3 Total Time Consummed.. "+hours);
        Console.WriteLine("_____________________________________");
        Console.WriteLine("TOTAL BILL............. "+bill);

        
    }
}