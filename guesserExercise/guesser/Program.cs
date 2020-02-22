using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;

        static void Main(string[] args)
        {
            /* TO DO: here is where you add your code! */

            //What?? What should I do?? Code a guessing game!!?
            //Ok.... Wait....No... Ok I got It... I think...

            //Hmmm.... MaxTrials=10;.... Maby there should be a max on trials!!

            //--------------PSEUDO CODE------------------->
            //This is a guess a Name Game;
            //Console.WriteLine(Hello there!);
            //Console.WriteLine(Welcome to this awfull Guessing Game);
            //wait 1 sec
            //Console.WriteLine(Now here is the question:);
            //Console.WriteLine(What do you have to Guess?!);
            //input
            //Console.WriteLine(No, not that...);
            //-1 MaxTrials
            //Console.WriteLine(Try again!);
            //for loop until maxTrials = 3
            //Console.WriteLine(Heres a clue:);
            //Console.WriteLine(Its a name...);
            //indput
            //Console.WriteLine(No, not that name...);
            //-1 MaxTrials    (maxTrials=2)
            //Console.WriteLine(Heres a clue:);
            //Console.WriteLine(Its a male name...);
            //indput
            //Console.WriteLine(No, not that name...);
            //-1 MaxTrials    (maxTrials=1)
            //Console.WriteLine(Uhh!! Only one trial back);
            //Wait
            //Console.WriteLine(I bet he drives in a Polo!);
            //input
            //if input = Marco -> Hurray You guessed who made me make this aweful Guess a name game!! (Endgame)
            //-1 MaxTrials
            //if maxTrials= 0 -> Damm... Bad Luck! You are just as blank as I was when given this exersice!!
            //--------------PSEUDO CODE-------------------<

            //Now for coding.
            // Ok.... Nothing happens when I run this.....!
            //Maby I need to leave all the // out....

            Console.WriteLine("Hello there!");

            //TO DO: Write the rest of the code.
            //AND as structured and easy to read as possible.
            //Ok, remember to update comments.

            Console.WriteLine("Welcome to this awfull Guessing Game");

            //wait 2 sec
            Thread.Sleep(2000);                                                 // Bonus: using System.Threading; AND using System.Threading.Tasks; Is not the same! 
                                                                                // Thread.Sleep(2000); are using System.Threading;... -and not System.Threading.Tasks;
                                                                                // It could be written this way;
                                                                                // System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Now here is the question:");
            Console.WriteLine("What do you have to Guess?!");

            //Start point system
            int point = 0;

            //Guess and its wrong!                          MuHAHAHaAAW! 
            while (point <= 6)
            {
                //input
                string firstGuess = Console.ReadLine();
                point++;
                Console.WriteLine("No, not " + firstGuess + "...");
                Console.WriteLine("You have " + (MaxTrials - point) + " trials back!");
                Console.WriteLine("Try again!");   
             }
            

            Console.WriteLine("Here is a clue:");
            Console.WriteLine("Its a name...");

            //indput
            string secondGuess = Console.ReadLine();

            Console.WriteLine("HA HA!! No! " + secondGuess + " is not rigth...");
            point++;


            Console.WriteLine("Here is a clue:");
            Console.WriteLine("Its a male name...");

            //indput
            string thirdGuess = Console.ReadLine();
            Console.WriteLine("No, " + thirdGuess + " is wrong!...");
            point++;
            
            Console.WriteLine("Uhh!! Only one trial back");

            //Wait
            Thread.Sleep(2000);
            Console.WriteLine("I bet he drives in a Polo!");

            //input
            string finalGuess = Console.ReadLine();

            //The correct answer can only be answered in "finalGuess" childlike manner.
            if (finalGuess == "Marco")
            { 
                Console.WriteLine("Hurray You guessed who made me make this aweful Guess a name game!!");
                return;
            }

            //Last point to fail...
            point++;

            if (point >= 10)
            {
                Console.WriteLine("Damm... Bad Luck! You are just as blank as I was when given this exersice!!");
                return;
            }  
        }
    }
}
