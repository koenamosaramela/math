using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace investment2017
{
    internal class Program
    {
        static int menuoptions;
        static double investmentAmount;
        static void Main()
        {
            housekeeping();
            detailLoop();
            finishUp();
        }
        static void housekeeping()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                INVESTMENT MENU");
            Console.WriteLine();
            Console.WriteLine("1. Make Investment ");
            Console.WriteLine("2. exit program ");
            Console.WriteLine();
            Console.WriteLine("investment interest is 11% per months");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter the menu option");
            menuoptions = Convert.ToInt32(Console.ReadLine());
            while (menuoptions < 1 && menuoptions > 2)
            {
                Console.WriteLine("incorrect menu option please enter the menu options ");
                menuoptions = Convert.ToInt32(Console.ReadLine());
            }
            switch (menuoptions)
            {
                case 1:
                    detailLoop();
                    break;
                case 2:
                    finishUp();
                    break;
                default:
                    Main();
                    break;
            }
        }
        static void detailLoop()
        {
            Console.WriteLine("the money yo are investing will grow monthly by 11%");
            Console.WriteLine();
            Console.WriteLine("please eneter the amount you would like to invest ");
            investmentAmount = Convert.ToDouble(Console.ReadLine());

            for (int month = 1; month <=12; month++)
            {
                investmentAmount = investmentAmount + (investmentAmount * 0.11);
                Console.WriteLine("Month{0}    amount R{1:F2}",month,investmentAmount);
            }

        }
        static void finishUp()
        {
            string exitProgram;

            Console.WriteLine(" would you like to exit the program ");
            exitProgram = Console.ReadLine();

            if(exitProgram == "y")
            {
                Console.WriteLine("bye bye ");
            }
            else
            {
                Main();
            }
        }
    }
}
