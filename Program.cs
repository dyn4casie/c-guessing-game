using System;
using System.Collections.Generic;

namespace NumberGuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            String retry;
            
            int guesses, number, levelselected, Guessednumber; 

            //Store username
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please Enter your name: \n");
            String name = Console.ReadLine();
            
            Difficulty:
            //Return username in greeting
            Console.WriteLine("===============================================\nWelcome, Please Select a difficulty: " , name);
            Console.WriteLine("Enter 1 for Easy");
            Console.WriteLine("Enter 2 for Medium");
            Console.WriteLine("Enter 3 for Hard\n================================================");
            Console.ResetColor();
            levelselected = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (levelselected)
            {

                case 1:
                Console.WriteLine("You have chosen Easy, you have 6 Guesses");
                     goto Easy;
                

                case 2:      
                Console.WriteLine("You have chosen Easy, you have 4 Guesses");             
                    goto Medium;
                

                case 3:
                Console.WriteLine("You have chosen Easy, you have 3 Guesses");
                    goto Hard;
                

                default:
                Console.WriteLine("Please choose a level");
                break;
            }
            Console.ResetColor();
//Code For Easy Difficulty
            Easy:
             number = r.Next(1, 10);
              guesses = 6;
            
           do
           {
            Console.Write("Guess a number between 1-10: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
           
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You got it right!");
                        Console.ResetColor()
;                        break;
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                        Console.ResetColor();
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
               Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!!");
                Console.ResetColor();
                
           }

            Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Would you like to play again:");
           Console.WriteLine("Enter yes or no");
             retry = Console.ReadLine();
             Console.ResetColor();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }
//Code For Medium Difficulty
           Medium:
                 number = r.Next(1, 20);
                    guesses = 4;
                    do
           {
            Console.Write("Guess a number between 1-20: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You got it right!");
                        Console.ResetColor();
                        break;
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                        Console.ResetColor();
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
               Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!!");
                Console.ResetColor();
           }
           Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Would you like to play again:");
           Console.WriteLine("Enter yes or no");
           Console.ResetColor();
            retry = Console.ReadLine();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }
//Code For Hard Difficulty
           Hard:            
                    number = r.Next(1, 50);
                    guesses = 3;
           do
           {
            Console.Write("Guess a number between 1-50: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
                    {
                         Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You got it right!");
                        Console.ResetColor();
                        break;
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                        Console.ResetColor();
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!!");
                Console.ResetColor();
           }
           Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Do you want to play again:");
           Console.WriteLine("Enter yes or no");
           Console.ResetColor();
            retry = Console.ReadLine();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }

           Finish:
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Thank you for playing" , name);
           Console.ResetColor();
    }
}
}