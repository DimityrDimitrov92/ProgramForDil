using System;
using System.Globalization;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Dilmara
{
    class Program
    {

        static void Main(string[] args)
        {

            int MenuRow = 8;
            
            DrawManu();
            //Console.WriteLine(legend);
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.GetCultureInfo("en-US");
            grr:Console.SetCursorPosition(40, ++MenuRow);
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.SetCursorPosition(80, MenuRow);
            Console.WriteLine($"Name is : {name}");




            Console.SetCursorPosition(40, ++MenuRow);
            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(80, MenuRow);
            Console.WriteLine($"Age : {age}");



            Console.SetCursorPosition(40, ++MenuRow);
            Console.Write("Enter your tall in cm : ");
            double tall = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(80, MenuRow);
            Console.WriteLine($"Your tall is : {tall}");



            Console.SetCursorPosition(40, ++MenuRow);
            Console.Write("Enter your kg : ");
            double kg = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(80, MenuRow);
            Console.WriteLine($"Your kg is : {kg}");
            Console.SetCursorPosition(40, ++MenuRow);
            Console.WriteLine();
            int a;
            Console.SetCursorPosition(3, ++MenuRow);
            Console.WriteLine($"1.Enter number one(1) to Calculate your BMI .");
            Console.SetCursorPosition(70, MenuRow);
            Console.WriteLine($"2.Enter number two(2) to Calculate your Calory .");


            do
            {
                Console.SetCursorPosition(50, ++MenuRow);
                Console.Write("Enter a number : ");
                a = int.Parse(Console.ReadLine());
            } while (a < 1 || a > 2);
            switch (a)
            {
                case 1:
                    Console.Clear();
                    DrawBMI();
                    CalcolateBMI(tall,kg);
                    break;
                case 2:
                    Console.Clear();
                    DrawCaloria();
                    CalcolateCaloria(kg,tall,age);
                    break;
            }


            do
            {
                Console.WriteLine();
                Console.WriteLine("                      Enter 1 to check again !                                Enter 2 for Exit !");
                Console.WriteLine();
                Console.Write($"                                                      Enter 1 or 2 ! : ");
                a = int.Parse(Console.ReadLine());
            } while (a < 1 || a > 2);
            switch (a)
            {
                case 1:
                    Console.Clear();
                    DrawManu();
                    MenuRow = 8;
                    goto grr;

                case 2:
                    break;
            }


        }
        public static void CalcolateBMI(double tall, double kg)
        {
            double result = kg / ((tall / 100) * (tall / 100));
            if (result < 16)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ========== Your category is :  Severe Thinness ");
            }
            else if (result < 17)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Moderate Thinness ");
            }
            else if (result < 18.5)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Mild Thinness ");
            }
            else if (result < 25)
            { 
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Normal ");
            }
            else if (result < 30)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Overweight ");
            }
            else if (result < 35)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Obese Class I ");
            }
            else if (result < 40)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Obese Class II ");
            }
            else if (result >= 40)
            {
                Console.WriteLine($"Your BMI = {result,15:0.00} ==========  Your category is : Obese Class III ");

            }


        }
        public static void CalcolateCaloria(double kg, double tall, int age)
        {
            double result = 0;
            int localRow = 8;
            ConsoleKeyInfo cki;
            do
            {
                Console.SetCursorPosition(20, ++localRow);
                Console.Write($"Enter m for male and f for female : ");
                cki = Console.ReadKey();
                Console.WriteLine();
            } while (cki.Key != ConsoleKey.F && cki.Key != ConsoleKey.M);

            if (cki.Key == ConsoleKey.M)
            {
                result = 655 + ((9.6 * kg)) + ((1.8 * tall)) - ((4.7 * age));
            }
            else if(cki.Key == ConsoleKey.F)
            {
                 result = 66 + ((13.7 * kg)) + ((5 * age)) - ((6.8 * age));
            }
            Console.WriteLine($"Life and everyday life with a little movement or exercise (calories) = {result *1.2:0} per day.");
            Console.WriteLine($"Life and daily life with light, toning workouts and activities, 1 to 3 times a week (calories) = {result *1.37:0} per day.");
            Console.WriteLine($"Life and daily life with moderately heavy, regular di 3-5 times a week physical activity (calories) = {result *1.55:0} per day.");
            Console.WriteLine($"Life and daily life with workouts up to 6-7 times a week (calories) = { result *1.72:0} per day.");

        }
        public static void DrawManu()
        {
            Console.WriteLine($"                                   ##      ##  #########  ##         ##  ##       ##");
            Console.WriteLine($"                                   ####  ####  ##         ## ##      ##  ##       ##");
            Console.WriteLine($"                                   ## #### ##  ##         ##  ##     ##  ##       ##");
            Console.WriteLine($"                                   ##  ##  ##  #########  ##    ##   ##  ##       ##");
            Console.WriteLine($"                                   ##      ##  ##         ##      ## ##  ##       ##");
            Console.WriteLine($"                                   ##      ##  ##         ##        # #   ##     ##");
            Console.WriteLine($"                                   ##      ##  #########  ##         ##     ## ##");
            Console.SetCursorPosition(8, 8);
            
        }
        public static void DrawBMI()
        {
            string legend = "BMI LEGEND !\nBMI < 16 = Severe Thinness.\nBMI 16-17 = Moderate Thinness.\nBMI 17-18.5 = Mild Thinness.\nBMI 18.5 - 25 = Normal." +
    "\nBMI 25-30 = Overweight.\nBMI 30-35 = Obese Class I.\nBMI 35-40 =Your category is : Obese Class II.\nBMI >=40 = Obese Class III.";
           
            Console.WriteLine($"                                     ##            ########              ###      ### ");
            Console.WriteLine($"                                     ##            ##      ##            ## ##  ## ## ");
            Console.WriteLine($"                                     ##            ##       ##           ##   ##   ## ");
            Console.WriteLine($"                                     ##            ### ##  ##            ##        ## ");
            Console.WriteLine($"                                     ##            ##        ##          ##        ## ");
            Console.WriteLine($"                                     ##            ##        ##          ##        ## ");
            Console.WriteLine($"                                     ##            ### ##  ##            ##        ## ");
            Console.WriteLine(legend);
            Console.WriteLine();
        }
        public static void DrawCaloria()
        {
            Console.WriteLine($"                 ## ## ##           ##           ##             ## # # ##    ## ## ##     ##          ##       ");
            Console.WriteLine($"                ##                 ## ##         ##             ##     ##    ##     ##    ##         ## ##     ");
            Console.WriteLine($"                ##                ##   ##        ##             ##     ##    ##    ##     ##        ##   ##    ");
            Console.WriteLine($"                ##               ##     ##       ##             ##     ##    ## ##        ##       ##     ##   ");
            Console.WriteLine($"                ##              ## # # # ##      ##             ##     ##    ##   ##      ##      ## # # # ##  ");
            Console.WriteLine($"                ##             ##         ##     ##             ##     ##    ##    ##     ##     ##         ## ");
            Console.WriteLine($"                 ## ## ##     ##           ##    ## ## ## ##    ## # # ##    ##     ##    ##    ##           ##");

            Console.SetCursorPosition(8, 8);

        }

    }
}
