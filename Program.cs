using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG161_Project_2025_final
{
    internal class Program
    {
        enum MainMenu
        {
            AddCustomer = 1,
            AddBook,
            RentBooks,
            Exit
        }
        
        static void Main(string[] args)
        {



        }

         static double GetDiscount(int yearsRegistered)
 {
     if (yearsRegistered >= 15)  // 0.35 = 35% | 0.20 = 20% | 0.10 = 10% | 0.05 = 5% 
         return 0.35;
     else if (yearsRegistered >= 10)
         return 0.20;
     else if (yearsRegistered >= 5)
         return 0.10;
     else
         return 0.05;
 }

 static int GetFreeRentals(int totalBooksRented)
 {
     if (totalBooksRented >= 75)
         return 8;
     else if (totalBooksRented >= 50)
         return 4;
     else if (totalBooksRented >= 25)
         return 2;
     else if (totalBooksRented >= 10)
         return 1;
     else
         return 0;
 }

 static string GetRoomOfRequirementReward(int yearsRegistered, int totalBooksRented)
 {
     if (yearsRegistered >= 15 && totalBooksRented >= 75)
         return "5 Bronze + 2 Silver + 1 Gold Tier Book";
     else if (yearsRegistered >= 10 && totalBooksRented >= 50)
         return "3 Bronze + 1 Silver Tier Book";
     else if (yearsRegistered >= 5 && totalBooksRented >= 25)
         return "1 Bronze Tier Book";
     else
         return "Oops! It looks like you're not eligible just yet.";
 }
    }
}
