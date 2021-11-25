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
            

         
            
            storyTable[00] = "                                        Page One" +
                " \n You awake, Inside a cube, There is a Door to the Left and Right of you, which door do you want to explore? 01:02";
                
            storyTable[01] = "                                        Page Two" +
                " \n You Fall into a pit full of snakes, Unfortunitly your illergic to snakes, you dying   ";

            storyTable[02] = "                                        Page Three" +
                " \n You peek your head into the door. It seems to be safe, walking through there is two more doors. do you go Left or Right? 03:04";

            storyTable[03] = "                                        Page Four" +
                " \n Conifdent about passing that first room, You fast-walked into the Left Room without any thought." +
                " \n Bold desison in that if you walked any slower you would have fallen into the pit that appeared under the few tiles you onced were standing on." +
                " \n Your not safe yet though, more and more tiles are starting to fall into the pit revealing long pointed spikes, " +
                " \n quickly! you must choose which door to sprite to! 05:06";
                

            storyTable[04] = "                                        Page Five" +
                " \n  ";

            storyTable[05] = "                                        Page Six" +
                " \n Well knowing that if you dont take this chance of running to Left Room you will become a Human sized and falvoured Shish Kabob." +
                " \n Diving right into the room with no time to spare as the metal airlock looking door slides shut behind you Catching your foot in the process." +
                " \n its stuck, But theres a single Hunting Knife in the Centre of the room, What do You Do? 09:12";

            storyTable[06] = "                                      Page Seven" +
                " \n Spriting as fast as you can to the Right Room, well knowing if you choose the wrong door you could possibly end up dead the same way or even more gruesome.  " +
                " \n Its clear in any situation where its life or death we will choose to stick it out as long as we can." + Console.ReadKey(true) +
                " \n                                   You sucuessfully make it to the new room. " + Console.ReadKey(true) +
                " \n Everything seems fine, no holes in the floor, no traps what so ever accept the air is a bit cooler." +
                " \n It gets colder and colder, so cold that you can feel your blood starting to cystalize within your body, skin turning black and digits falling off" +
                " \n                                      You Painfully Freezing To Death.   ";

            storyTable[7] = " Page Eight:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[8] = " Page Nine:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[09] = "                                     Page Ten" +
                " \n You reach for the knife Well knowing that the decision your about to make is going to hinder the rest of your experince in this Death Trap aswell as the rest of your life if you make it out." +
                " \n Holding up the knife like out of a horror movie, just about to bring it down upon your foot, the door swings open releasing your foot and a Woman jumps through just like you did." +
                " \n She Catches a glimps of you still holding up the knife, fearful she backs up telling you to 'Stay Away' 14:14";

            storyTable[10] = " Page Eleven:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[11] = "                                  Page Twelve" +
                "";

            storyTable[12] = " Page Thirdteen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore?  ";

            storyTable[13] = " Page FourTeen:" +
                " You awake, Inside a cube, each direction has a door which door do you want to explore? 15:11  ";

            storyTable[14] = "                                Page Fithteen" +
                " \n A Voice booms from all sides of the room." +
                " \n ' ONLY ONE CAN PASS '  ";

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
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 3);


                // Takes [X] "xyz" A and reads it making it a substring aswell as removing A 
                choiceA = choiceA.Substring(choiceA.Length - 2);


            string choiceB =
                // Takes [X] "xyz" B and reads it making it a substring aswell as removing B 
                storyTable[currentPage].Substring(storyTable[currentPage].Length - 2);


                // Removes The A:B page markers from string before printing 
            string pageHider = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 5);


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
                Console.ReadKey(true);
                Console.Clear();
            }
            if (ChoiceB == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lock In Your Answer by Double Tapping Key");
                Console.ReadKey(true);
                Console.Clear();
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
