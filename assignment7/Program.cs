using System;

namespace BalanceCalc
{
  class Program
  {
    static void Main(string[] args)
    {
      int er = 0;
      double totalBalance = 0;
      double totalDeposite = 0;
      double totalWithdraw = 0;
      double totalInterest = 0;
      double initialValue = 0;
    
      Console.WriteLine("Pleas Enter the Starting Balance of Your account");
      double statingValue = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please Enter the Rate");
      double rate = Convert.ToDouble(Console.ReadLine());

      for(int i = 1; i <=3; i++){

        Console.WriteLine("Please Enter the amount deposited for month "+i);
        double amountDeposited = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Enter the amount withdrawn "+i);
        double amountWithdrawn = Convert.ToDouble(Console.ReadLine());

        // remember this value the first time 
        if(i == 1){
          initialValue = statingValue;
          totalBalance = statingValue;
        }

        // validate user input to prevent negative number 
        if(amountDeposited < 0 || amountWithdrawn < 0){
          Console.WriteLine("Only positive numbers are allowed");
          er = 1;
          break;
        }
        // check the amount the user wants to widthdraw 
        if(amountWithdrawn > totalBalance){
          Console.WriteLine("The amount you're trying to withdraw is greater than your balance");
          er = 1;
          break;
        }
        // calculate the interest ==> average 
        double interest = ((statingValue+(amountDeposited+statingValue))/2)*((rate/100)/12);
        
        totalBalance = (interest+statingValue+amountDeposited)-amountWithdrawn;
        totalWithdraw += amountWithdrawn;
        totalDeposite += amountDeposited;
        totalInterest += interest;
        // swap the variable 
        statingValue = totalBalance;
      }

      // let print the values if every things is success ful 
      if(er != 1){
        Console.WriteLine("================ACCOUNT STATEMENT==========");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Initial Balance................ "+initialValue);
        Console.WriteLine("Total Deposite................. "+totalDeposite);
        Console.WriteLine("Total Withdraw ................."+totalWithdraw);
        Console.WriteLine("Total interest accumulated......"+totalInterest);
        Console.WriteLine("_______________________________________________");
        Console.WriteLine("ACCOUNT BALANCE ................."+totalBalance);

      }else{
        Console.WriteLine("Program terminated because an error occured ");
      }


    }
  }
}