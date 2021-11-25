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
       static int i = 0;

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
            currentPage = storyLocation;

         
            
            storyTable[0] = " Page One:" +
                " You awake, Inside a cube, There is a Door to the Left and Right of you, which door do you want to explore? 1:2";
                

            storyTable[1] = " Page Two:" +
                " You Fall into a pit full of snakes, Unfortunitly your illergic to snakes, you dying   ";

            storyTable[2] = "Page Three:" +
                " You peek your head into the door. It seems to be safe, walking through there is two more doors. do you go Left or Right? 3:4";

            storyTable[3] = " Page Four:" +
                "     You awake, Inside a cube, each direction has a door" +
                "           which door do you want to explore?";

            storyTable[4] = "                 Page Five" +
                "     You awake, Inside a cube, each direction has a door" +
                "           which door do you want to explore?";

            
        }

        static void Options()
        {
          if(storyTable[currentPage].Contains("Page"))
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Option A - Go Right ");
                Console.WriteLine("Option B - Go Left");
                Console.ResetColor();
            }
        }
        static void PageChanger()
        {
            string choiceA = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 2);
                choiceA = choiceA.Substring(choiceA.Length - 1);

            string choiceB = 
                storyTable[currentPage].Substring(storyTable[currentPage].Length - 1);
            string pageHider = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 3);

            if (ChoiceA == true)
            {
                int.TryParse(choiceA, out currentPage);
            }

            if (ChoiceB == true)
            {
                int.TryParse(choiceB, out currentPage);
            }

            if (CorrectedText == true)
            {
                Console.Write(pageHider);
                Options();
            }

            Console.WriteLine("");
        }
        static void Inputs()
        {
            
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
            PageChanger();
            PageCorrector();
        }
        static void PageCorrector()
        {
            if (ChoiceA == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lock In Your Answer by Double Tapping Key");
                Console.ReadKey(true);
            }
            if (ChoiceB == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lock In Your Answer by Double Tapping Key");
                Console.ReadKey(true);
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
