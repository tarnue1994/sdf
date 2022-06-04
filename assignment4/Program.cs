using System;

namespace TicketSummary{
    class Program{
        static void Main(String[] args){
            // inilitiaze  the prices in to appropriate variables 
            decimal vIPTicket_price = 150.0m;
            decimal aroundVIPTicket_price = 50.0m;
            decimal stadiumWings_price = 20.0m;
            decimal aroundField_price = 5.0m;

            // declare categoral of tickets total 
            int vIPTicket_Total;
            int aroundVIPTicket_Total;
            int stadiumWingsTicket_Total;
            int aroundFieldTicket_Total;

            /* asks how many tickets for each category were sold
            and determine the sale for each; then assigned them 
            to their respective variables */
            
            Console.WriteLine("How many VIP tickets were sold? ");
            vIPTicket_Total = Convert.ToInt32(Console.ReadLine());
            decimal VIP_ticket_sale = vIPTicket_Total*vIPTicket_price;

            Console.Write("How many Around VIP tickets were sold? ");
            aroundVIPTicket_Total = Convert.ToInt32(Console.ReadLine());
            decimal aroundVIPTicket_sale = aroundVIPTicket_Total*aroundVIPTicket_price;

            Console.Write("How many Stadium Wings tickets were sold? ");
            stadiumWingsTicket_Total = Convert.ToInt32(Console.ReadLine());
            decimal stadiumWings_sale = stadiumWingsTicket_Total*stadiumWings_price;

            Console.Write("How many Around Field tickets were sold? ");
            aroundFieldTicket_Total = Convert.ToInt32(Console.ReadLine());
            decimal aroundField_sale = aroundFieldTicket_Total*aroundField_price;

            //total sale generated 
            decimal totalSale = VIP_ticket_sale+aroundVIPTicket_sale+stadiumWings_sale+aroundField_sale;

            // print out the sale summary 
            Console.WriteLine("Category of ticket......... Total Sale");
            Console.WriteLine("________________________________________");
            Console.WriteLine("VIP Ticket .................$ "+decimal.Round(VIP_ticket_sale,2));
            Console.WriteLine("Around VIP Ticket ..........$ "+decimal.Round(aroundVIPTicket_sale,2));
            Console.WriteLine("Satium Wings Tick...........$ "+decimal.Round(stadiumWings_sale,2));
            Console.WriteLine("Around Field Ticket ........$ "+decimal.Round(aroundField_sale,2));
            Console.WriteLine("________________________________________");
            Console.WriteLine("TOTAL SALE..................$ "+decimal.Round(totalSale,2));

        }
    }
}