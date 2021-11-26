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
        static bool PlayerDead = false;
        
       

        static void Main(string[] args)
        {
            // how am I supposed to do this......
            // GameLoops for player interaction
            // I need to make triggers - when button is pressed choice is displayed (if statments)
            // Use string array for story text


            GameTitle();
            while (gameOver == false)
            {
                if (PlayerDead == true)
                {
                    gameOver = true;
                }
                Story(currentPage);
                PageCorrector();
                Inputs();
                Options();
                Console.Clear();

             

            }


        }

        static void Story(int storyLocation)
        {
            

         //                                                                                             For Story Artist, 00:00 is how to make paths lead to each other 
         //                                                                                             EXAMPLE: 01:02 = Option A : Option B -> numbers arent pages they are index 
            
            storyTable[00] = "                                        Page One" +
                " \n You awake, Inside a cube, There is a Door to the Left and Right of you, which door do you want to explore? " +
                " \n Option A - Go Left" +
                " \n Option B - Go Right 01:02";
                
            storyTable[01] = "                                        Page Two" +
                " \n      _    _                           " +
                " \n   ,-(|)--(|)-.                        " +
                " \n   \\_  ..   _/                         " +
                " \n    \\_______/                     /\\ " +
                " \n     \\V  V \\                     / / " +
                " \n     |      |    _------_       (   \\  "        +
                " \n     \\      \\  /          \\      \\  )    " +
                " \n       \\     \\/    __       \\_---'  /     " +
                " \n        (          /  \\             /" +
                " \n         \\_______'     \\___________/       " +
                " \n ------------------------------------------------------------------------------------" +
                " \n|You Fall into a pit full of snakes, Unfortunitly your Allergic to snakes, you dying|" +
                " \n_____________________________________________________________________________________ 01:01";

            storyTable[02] = "                                        Page Three" +
                " \n You peek your head into the door. It seems to be safe, walking through there is two more doors. do you go Left or Right?" +
                " \n Option A - Go Left" +
                " \n Option B - Go Right 03:04";

            storyTable[03] = "                                        Page Four" +
                " \n Conifdent about passing that first room, You fast-walked into the Left Room without any thought." +
                " \n Bold desison in that if you walked any slower you would have fallen into the pit that appeared under the few tiles you onced were standing on." +
                " \n Your not safe yet though, more and more tiles are starting to fall into the pit revealing long pointed spikes, " +
                " \n quickly! you must choose which door to sprite to!" +
                " \n Option A - Left Door" +
                " \n Option B - Right Door 05:06";
                

            storyTable[04] = "                                        Page Five" +
                " \n You Cautiously walk into the room, so far so good this werid facility you woke up just has a bunch of empty rooms." +
                " \n This time there is two doors ahead of you one to the Left on to the Right, which do you choose?" +
                " \n Option A - Door On The Left" +
                " \n Option B - Door On The Right 07:08";

            storyTable[05] = "                                        Page Six" +
                " \n Well knowing that if you dont take this chance of running to Left Room you will become a Human sized and falvoured Shish Kabob." +
                " \n Diving right into the room with no time to spare as the metal airlock looking door slides shut behind you Catching your foot in the process." +
                " \n its stuck, But theres a single Hunting Knife in the Centre of the room, What do You Do?" +
                " \n Option A - Cut Off Foot" +
                " \n Option B - Sit And Wait 09:11";

            storyTable[06] = "                                           Page Seven" +
                " \n Spriting as fast as you can to the Right Room, well knowing if you choose the wrong door you could possibly end up dead the same way or even more gruesome.  " +
                " \n Its clear in any situation where its life or death we will choose to stick it out as long as we can." + 
                " \n                                   You sucuessfully make it to the new room. " +
                " \n Everything seems fine, no holes in the floor, no traps what so ever accept the air is a bit cooler." +
                " \n It gets colder and colder, so cold that you can feel your blood starting to cystalize within your body, skin turning black and digits falling off" +
                " \n                                      You Painfully Freezing To Death. 06:06";

            storyTable[07] = "                                     Page Eight" +
                " \n You make it to the Left room and find it covered in cobwebs" +
                " \n A shadow is casted behind you when you walk farther in" +
                " \n You feel many eyes watching, just as your about to turn around your body is stuck," +
                " \n Many webs have wrapped around you and a Man-Eatting spider apears, Comsuing your flesh like a bug. 07:07";

            storyTable[08] = "                                     Page Nine" +
                " \n The Right Room seemed to be the right choice" +
                " \n Some Great, fancy looking food are platted in the middle of the room on a steel table" +
                " \n Option A - Eat Food" +
                " \n Option B - Contuine ForWard 11:13";

            storyTable[09] = "                                     Page Ten" +
                " \n You reach for the knife Well knowing that the decision your about to make is going to hinder the rest of your experince in this Death Trap aswell as the rest of your life if you make it out." +
                " \n Holding up the knife like out of a horror movie, just about to bring it down upon your foot, the door swings open releasing your foot and a Woman jumps through just like you did." +
                " \n She Catches a glimps of you still holding up the knife, fearful she backs up telling you to 'Stay Away'" +
                " \n Option A - -------" +
                " \n Option B - ------- 14:14";

            storyTable[10] = "                                  Page Eleven" +
                " \n Eating The Food it you start to feel a bit funny, grasping at your throat you uncontrollaby start coughing, blood being splirted out with each exhale." +
                " \n You dropping dead in the middle of the room 10:10";

            storyTable[11] = "                                  Page Twelve" +
                " \n The Thought of cutting of your own foot sickens you, the knife might be useful later though, putting it in your pocket." +
                " \n You sit and wait for it feels like days but probably more like hours have past, just when your about to pull out the knife and contemplate cutting your foot off again," +
                " \n The door swings open releasing your foot and a Woman jumps through it just like you did prior" +
                " \n She catches a glimps of you, reaches for your hand to help you up." +
                " \n Option A - ------" +
                " \n Option B - ------ 14:14";

            storyTable[12] = "                                 Page Thirdteen" +
                " \n Passing up the many elegant dishes was a very hard desison walking past them your still drooling, walking into the new room" +
                " \n You see a blinding Light following it you escape the Facility with no Scratches " +
                " \n Good Job! 12:12";

            storyTable[14] = "                                Page Fithteen" +
                " \n A Voice booms from all sides of the room." +
                " \n ' ONLY ONE CAN PASS '" +
                " \n You both intensely stare at each other each waiting for each others move." +
                " \n Option A - KILL HER" +
                " \n Option B - Do Nothing 15:16";

            storyTable[15] = "                                Page Sixteen" +
                " \n You take the knife, the woman instanly knows whats going to happen, trying to run away from you" +
                " \n You case her to a couner of the room, no where for her to go, she screams admitting defeat, curling into a fetal postion as you aproach closer. " +
                " \n With no empathy you stabe her in the arm as she trys to protect her face, terror filled, agony screams realse from her. " +
                " \n You stab until the screams and body looses all life." +
                " \n A door slides open with a metalic screach, blinding light shinning through. " +
                " \n Covered in the Womans blood you exit the facility, knife still in hand with no Regrets you Sicko 15:15";

            storyTable[16] = "                                Page SevenTeen" + 
                " \n You see that the woman starts to cry, not being strong enough to take the stress of not knowing if shes going to die." + 
                " \n You lay down the knife suggesting your not going to hurt her. " + 
                " \n The voice booms again." + 
                " \n 'ONE MUST DIE' " + 
                " \n Walls start to close in knowing both of you will, you decide to run back to the Spike pit room throwing yourself off of it" +
                " \n A door slides open with a metalic screach, blinding light shinning through. " +
                " \n The Woman walks through unharmed, you saving her life, being a Hero! 16:16";
        }

        
        
      
                         

        

        static void DeathChecks()
        {
            if (storyTable[currentPage].Contains("dying") || storyTable[currentPage].Contains("Death") || storyTable[currentPage].Contains("Sicko") 
              || storyTable[currentPage].Contains("die") || storyTable[currentPage].Contains("Dead") || storyTable[currentPage].Contains("Man-Eatting"))
            {
                
                GameOver();
                PlayerDead = true;
               
            }
        }
        static void Options()
        {
          if(storyTable[currentPage].Contains("Page"))
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Option A - Press A   Option B - Press B");
                Console.ResetColor();
            }
        }
        static void PageChanger()
        {
            
            string choiceA = 
                // [X] "xyz" AA:BB --- .Removes the BB option ( so it doesnt read it )
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 3);
            


                // Takes [X] "xyz" AA and reads the AA part 
                choiceA = choiceA.Substring(choiceA.Length - 2);


            string choiceB =
                // Takes [X] "xyz" BB and reads the BB part 
                storyTable[currentPage].Substring(storyTable[currentPage].Length - 2);


                // Removes The AA:BB page markers from string before printing 
            string pageHider = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 5);


            if (ChoiceA == true)
            {
                // Converts string choiceA's AA to int current page ->[XX]
                int.TryParse(choiceA, out currentPage);
            }

            if (ChoiceB == true)
            {
                // Converts string choiceB's BB to int current page ->[XX]
                int.TryParse(choiceB, out currentPage);
            }

            if (CorrectedText == true)
            {

                Console.Write(pageHider);
                DeathChecks();


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
            PageChanger();

           
        }
        static void PageCorrector()
        {
            // Makes sure your on the right page aswell as resting the choice Bools so cannot Spam
            if (ChoiceA == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press Any Key To Continue ...");
                Console.ReadKey(true);
                Console.Clear();
            }
            if (ChoiceB == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press Any Key To Continue ...");
                Console.ReadKey(true);
                Console.Clear();
            }

            ChoiceA = false;
            ChoiceB = false;
            CorrectedText = true;
        }

        public static void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          _|||||||||||   |||       |||   ||||||||||||   ||||||||||||||   |||||||||||    |||||||||||||   |||||||||||||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||       |||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||       |||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||      |||");
            Console.WriteLine("          |||            |||=======|||   |||======|||   |||   ||   |||   |||======||    |||=========    |||=======");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||      |||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||      |||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||      |||");
            Console.WriteLine("          |||            |||       |||   |||      |||   |||   ||   |||   |||      |||   |||             |||      |||");
            Console.WriteLine("           ||||||||||||  |||       |||   |||      |||   |||   ||   |||   |||||||||||    |||||||||||||   |||      |||");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             A Text Adventure Game                                                              ");
            Console.ResetColor();
            Console.WriteLine("                                            Press any button to begin                                                             ");
            Console.ReadKey(true);
            Console.Clear();
           
           
        }

        public static void GameOver()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("               |||||||    ||||     |    |    |||||||     ||||||    |     ||   |||||||   ||||||    ||||");
            Console.WriteLine("              ||||||||   ||||||   |||  |||  |||||| |    |||  |||  ||     ||  |||||| |  |||  |||   ||||");
            Console.WriteLine("              ||        |||   ||  |||  |||  ||    |     ||    ||  ||     ||  ||    |   ||    ||   ||||");
            Console.WriteLine("              ||        ||    ||  ||||||||  ||          ||    ||  ||     ||  ||        ||    ||   ||||");
            Console.WriteLine("              ||  ||||  ||    ||  ||||||||  ||||||||    ||    ||  ||     ||  ||||||||  ||    ||   ||||");
            Console.WriteLine("              ||   |||  ||    ||  || || ||  ||||||||    ||    ||  ||     ||  ||||||||  ||||||||    || ");
            Console.WriteLine("               |    |   ||||||||  ||    ||  ||          ||    ||  ||     ||  ||        |||||||     || ");
            Console.WriteLine("              ||    ||  ||    ||  ||    ||  ||          ||    ||   ||   ||   ||        ||  ||         ");
            Console.WriteLine("              ||||||||  ||    ||  ||    ||   |||||||     |||||||   |||||||    |||||||  ||   ||     || ");
            Console.WriteLine("               |||  |   |      |  ||    ||   |||| ||      |||||     |||       ||||| |  |     ||    || ");
           
            
        }

        public static void YouWin()
        {
            Console.WriteLine("you win");
            Console.ReadKey(true);
            gameOver = true;
        }

        

    }
}
