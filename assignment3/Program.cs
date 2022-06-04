using System;

namespace CompanySurvey {
    class Program {
        static void Main(string[] args){
        // define the given information into key verables
        int totalCustomers = 12467;
        double percentOfEnergyDrink = 0.14;
        double percentOfCitrusFlavor = 0.64;

        // customers who purchase one or more energy drinks per week.

        int energyDrinkCustomers = Convert.ToInt32(totalCustomers*percentOfEnergyDrink);
        Console.WriteLine("Total customers who purchase one or more energy drinks per week");
        Console.WriteLine(energyDrinkCustomers);
   
        Console.WriteLine("customers in the survey who prefer citrus-flavored energy drinks");
        int citrusFlavorCustomers = Convert.ToInt32(energyDrinkCustomers*percentOfCitrusFlavor);
        Console.WriteLine(citrusFlavorCustomers);

        }
    }
}