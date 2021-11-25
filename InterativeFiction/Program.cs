using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterativeFiction
{
    class Program
    {
        
        static bool gameOver = false;
        static string[] storyTable = new string[20];
        static int currentPage = 0;
        static bool ChoiceA = false;
        static bool ChoiceB = false;
        static bool CorrectedText = false;
        
       

        static void Main(string[] args)
        {
            // how am I supposed to do this......
            // GameLoops for player interaction
            // I need to make triggers - when button is pressed choice is displayed (if statments)
            // Use string array for story text


            GameTitle();
            while (gameOver == false)
            {
                
                Story(currentPage);
                PageCorrector();
                Inputs();
                Console.Clear();

            }


        }

        static void Story(int storyLocation)
        {
            

         
            
            storyTable[0] = " Page One:" +
                " You awake, Inside a cube, There is a Door to the Left and Right of you, which door do you want to explore? 1:2";
                
            storyTable[1] = " Page Two:" +
                " You Fall into a pit full of snakes, Unfortunitly your illergic to snakes, you dying   ";

            storyTable[2] = "Page Three:" +
                " You peek your head into the door. It seems to be safe, walking through there is two more doors. do you go Left or Right? 3:4";

            storyTable[3] = " Page Four:" +
                " Conifdent about passing that first room, You fast-walked into the Left Room without any thought." +
                " \n Bold desison in that if you walked any slower you would have fallen into the pit that appeared under the few tiles you onced were standing on." +
                " \n Your not safe yet though, more and more tiles are starting to fall into the pit, quickly! you must choose which door to sprite to!";
                

            storyTable[4] = " Page Five:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[5] = " Page Six:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[6] = " Page Seven:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[7] = " Page Eight:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[8] = " Page Nine:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[9] = " Page Ten:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[10] = " Page Eleven:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[11] = " Page Twelve:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[12] = " Page Thirdteen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[13] = " Page FourTeen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[14] = " Page Fithteen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[15] = " Page Sixteen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";
        }

        static void Options()
        {
          if(storyTable[currentPage].Contains("Page"))
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Option A -  ");
                Console.WriteLine("Option B -  ");
                Console.ResetColor();
            }
        }
        static void PageChanger()
        {
            
            string choiceA = 
                // [X] "xyz" A:B --- .Removes the B option ( so it doesnt read it )
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 2);


                // Takes [X] "xyz" A and reads it making it a substring aswell as removing A 
                choiceA = choiceA.Substring(choiceA.Length - 1);


            string choiceB =
                // Takes [X] "xyz" B and reads it making it a substring aswell as removing B 
                storyTable[currentPage].Substring(storyTable[currentPage].Length - 1);


                // Removes The A:B page markers from string before printing 
            string pageHider = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 3);


            if (ChoiceA == true)
            {
                // Converts string choiceA's A to int current page ->[X]
                int.TryParse(choiceA, out currentPage);
            }

            if (ChoiceB == true)
            {
                // Converts string choiceB's B to int current page ->[X]
                int.TryParse(choiceB, out currentPage);
            }

            if (CorrectedText == true)
            {
                Console.Write(pageHider);
                Options();
            }

            
        }
        static void Inputs()
        {
            PageChanger();
            PageCorrector();

            ConsoleKeyInfo Input = Console.ReadKey(intercept: true);

            if (Input.Key == ConsoleKey.A)
            {

                ChoiceA = true;
                ChoiceB = false;
                
            }
            else if (Input.Key == ConsoleKey.B)
            {
                ChoiceB = true;
                ChoiceA = false;
                
            }
            Console.WriteLine();
            PageChanger();
           
        }
        static void PageCorrector()
        {
            // Makes sure your on the right page aswell as resting the choice Bools so cannot Spam
            if (ChoiceA == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lock In Your Answer by Double Tapping Key");
                Console.ReadKey();
            }
            if (ChoiceB == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lock In Your Answer by Double Tapping Key");
                Console.ReadKey();
            }

            ChoiceA = false;
            ChoiceB = false;
            CorrectedText = true;
        }

        public static void GameTitle()
        {
            Console.WriteLine("welcome to game");
            Console.ReadKey(true);
           
           
        }

        public static void GameOver()
        {
            Console.WriteLine("you Lost");
            Console.ReadKey(true);
            gameOver = true;
        }

        public static void YouWin()
        {
            Console.WriteLine("you win");
            Console.ReadKey(true);
            gameOver = true;
        }

        

    }
}
