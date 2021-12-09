using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace InterativeFiction
{
    class Program
    {
        
        static bool gameOver = false;
        static string[] storyTable = new string[storySize];
        static int currentPage = 0;
        static bool ChoiceA = false;
        static bool ChoiceB = false;
        static bool CorrectedText = false;
        static bool PlayerDead = false;
        static int storySize;
        static int saves = 1;
        static string savedPageData;
        static string saveCounter;
        
       

        static void Main(string[] args)
        {
            
            GameTitle();
            MenuInputs();
            Inisalization();
      

            while(gameOver == false)
            {
                
                if (PlayerDead == true)
                {
                    gameOver = true;
                }
                  
                  StoryFile(currentPage);
                  PageCorrector();
                  Inputs();
                  Console.Clear();


            }


        }

        static void MenuInputs()
        {
            ConsoleKeyInfo Input = Console.ReadKey(intercept: true);
            if (Input.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                LoadSave();
            }
            else if (Input.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.ReadKey(true);

            }
            
        }
        static void Story(int storyLocation)
        {
            

         //                                                                                             For Story Artist, 00:00 is how to make paths lead to each other 
         //                                                                                             EXAMPLE: 01:02 = Option A : Option B -> numbers arent pages they are index 
            
            storyTable[00] = "                                        Page One" +
                " \n |                  |                                                                 |                   |" +
                " \n |          _____   |                                                                 |   _____           |" +
                " \n |       --     |   |                                                                 |   |     --        | " +
                " \n |      |       |   |                                                                 |   |       |       | " +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |    ___----------------------------------------------------------------------------___   |       |" +
                " \n ______-----                                                                                  -----_______" +
                " \n ----------------------------------------------------------------------------------------------------------" +
                " \n You awake, Inside a CHAMBER, There is a Door to the left and right of you, which door do you want to explore? " +
                " \n Option A - Go Left" +
                " \n Option B - Go Right 01:02";
                
            storyTable[01] = "                                        Page Two" +
                " \n                                   _    _                           " +
                " \n                                ,-(|)--(|)-.                        " +
                " \n                                \\_  ..   _/                         " +
                " \n                                 \\_______/                     /\\ " +
                " \n                                  \\V  V \\                     / / " +
                " \n                                    |      |    _------_       (   \\  "        +
                " \n                                    \\      \\  /          \\      \\  )    " +
                " \n                                     \\     \\/    __       \\_---'  /     " +
                " \n                                       (          /  \\             /" +
                " \n                                        \\_______'     \\___________/       " +
                " \n ------------------------------------------------------------------------------------" +
                " \n You fall into a pit full of snakes, unfortunately you`re allergic to snakes, you`re dying " +
                " \n 01:01";

            storyTable[02] = "                                        Page Three"+
                " \n |                  |                                                                 |                   |" +
                " \n |          _____   |                                                                 |   _____           |" +
                " \n |       --     |   |                                                                 |   |     --        | " +
                " \n |      |       |   |                                                                 |   |       |       | " +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |       |   |                                                                 |   |       |       |" +
                " \n |      |    ___----------------------------------------------------------------------------___   |       |" +
                " \n ______-----                                                                                  -----_______" +
                " \n ----------------------------------------------------------------------------------------------------------"+
                " \n You peek your head into the door. It seems to be safe, walking through there are two more doors. " +
                " \n Do you go left or right?" +
                " \n Option A - Go Left" +
                " \n Option B - Go Right 03:04";

            storyTable[03] = "                                        Page Four" +
                " \n |                  |                                                                   |                   | " +
                " \n |          _____   |                                                                   |   _____           |" +
                " \n |       --     |   |                                                                   |   |     --        | " +
                " \n |      |       |   |                                                                   |   |       |       | " +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |       |   |                                                                   |   |       |       |" +
                " \n |      |    ___-----------------------\\                                //-------------------___   |       |" +
                " \n ______-----                           /    /\\         /\\        /\\   \\                     -----_______" +
                " \n--------------------------------------/^^^^/ \\^^^^^^^^/  \\^^^^^^/  \\^^^^\\--------------------------------" +
                " \n Confident about passing that first room, You sped into the left room without any thought." +
                " \n Bold decison in that if you walked any slower you would have fallen into the pit that appeared under the few tiles you onced were standing on." +
                " \n You're not safe yet though, more and more tiles are starting to fall into the pit revealing long pointed spikes. " +
                " \n Quickly! You must choose which door to sprint to!" +
                " \n Option A - Left Door" +
                " \n Option B - Right Door 05:06";
                

            storyTable[04] = "                                        Page Five" +
                " \n |                  |                                                                 |                   | " +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |____________                                       ______________|                   | " +
                " \n |                  |           |                                       |             |                   | " +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |                  |           |                                       |             |                   |" +
                " \n |           ___----------------------------------------------------------------------------___           |" +
                " \n ______-----                                                                                  -----_______" +
                " \n ----------------------------------------------------------------------------------------------------------" + 
                " \n You cautiously walk into the room. So far so good. This weird facility you woke up in just has a bunch of empty rooms." +
                " \n This time there are two doors ahead of you, which do you choose?" +
                " \n Option A - Door On The Left" +
                " \n Option B - Door On The Right 07:08";

            storyTable[05] = "                                        Page Six" +
                " \n |                  |                                                                 |                   | " +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   | " +
                " \n |                  |                                                                 |                   | " +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                                                 |                   |" +
                " \n |                  |                                   _____________                 |                   |" +
                " \n |           ___--------------------------------________|*      *   /----------------  -----___           |" +
                " \n ______-----                                   (__________--*-----/                           -----_______" +
                " \n ----------------------------------------------------------------------------------------------------------" +
                " \n Knowing that if you don't take this chance of running to the left room you will become a human sized and flavoured shish kabob." +
                " \n Diving right into the room with no time to spare as the metal airlock slides shut behind you, catching your foot in the process." +
                " \n Its stuck, But theres a single hunting knife in front of you, What do you do?" +
                " \n Option A - Cut Off Foot" +
                " \n Option B - Sit And Wait 09:11";

            storyTable[06] = "                                           Page Seven" +
                " \n                                                     ,'/ //\\" +
                " \n                                                     /// // /)" +
                " \n                                                    /// // //|" +
                " \n                                                   /// // /// " +
                " \n                                                  /// // /// " +
                " \n                                                 (`: // /// " +
                " \n                                                  `;`: /// " +
                " \n                                                  / /:`:/ " +
                " \n                                                 / /  `' " +
                " \n                                                / /       " +
                " \n                                               (_/         " +
                " \n Sprinting as fast as you can to the right room. " + 
                " \n You sucuessfully make it to the new room. " +
                " \n Everything seems fine, no holes in the floor, no traps what so ever except the air is a bit cooler." +
                " \n It gets colder and colder, so cold that you can feel your blood starting to cystalize within your body, skin turning black and digits falling off" +
                " \n                                      You Painfully Freeze To Death. 06:06";

            storyTable[07] = "                                        Page Eight" +
                " \n                                  ____                      ," +
                " \n                                 /---.'.__             ____//" +
                " \n                                /---.'.__             ____//" +
                " \n                                     _______  \\\\         //" +
                " \n                                    /.------.\\  \\|      .'/  ______" +
                " \n                                    /  ___  \\ \\ ||/|\\  //  _/_----.\\__" +
                " \n                                    |/  /.-.\\  \\ \\:|< >|// _/.'..\\\\   '--'" +
                " \n                                         //   \\'. | \\'.|.'/ /_/ /  \\\\ " +
                " \n                                        //     \\ \\_\\/  \\          \\\\" +
                " \n                                       //       '-._| :H: |'-.__     \\\\" +
                " \n                                      //       '-._| :H: |'-.__     \\\\" +
                " \n                                     ||                      \\\\    \\|" +
                " \n                                     ||                        \\\\    '" +
                " \n                                     |/                          \\\\" +
                " \n                                                                   ||" +
                " \n                                                                   ||" +
                " \n                                                                   \\" +
                " \n                                                                     '" +
                " \n---------------------------------------------------------------------------------" +
                " \n You make it to the left room and find it covered in cobwebs" +
                " \n A shadow is casted behind you when you walk farther in" +
                " \n You feel many eyes watching you, just as your about to turn around you're stuck in place." +
                " \n Many webs have wrapped around you and a Man-Eating spider appears, comsuming your flesh. 07:07";

            storyTable[08] = "                                     Page Nine" +
                " \n |                  |          _____________________________________                 |                   | " +
                " \n |                  |          |                                   |                 |                   |" +
                " \n |                  |          |                                   |                 |                   | " +
                " \n |                  |          |                                   |                 |                   | " +
                " \n |                  |          |                                   |                 |                   |" +
                " \n |                  |          |                                   |                 |                   |" +
                " \n |                  |          |                ___                |                 |                   |" +
                " \n |                  |          |              -{   }-              |                 |                   |" +
                " \n |                  |          |            _{_______}_            |                 |                   |" +
                " \n |                  |          |       __()__|_______|__()___      |                 |                   |" +
                " \n |                  |          |        |                  |       |                 |                   |" +
                " \n |           ___---------------|--------|                  |-------|-----------------------___           |" +
                " \n ______-----                            |__________________|                                   -----_______" +
                " \n ---------------------------------------------------------------------------------------------------------" +
                " \n The right room seemed to be the right choice" +
                " \n Some fancy looking dishes are platted in the middle of the room on a steel table" +
                " \n Option A - Eat the Cake!" +
                " \n Option B - Contuine Forward 10:12";

            storyTable[09] = "                                     Page Ten" +
                 "\n                                    __________     __________" +
                " \n                                  /    -----  \\  //  -----   \\" +
                " \n                                 /         \\  \\//  /            \\" +
                " \n                               /         ___----------/__        \\" +
                " \n                               |        /                \\       |  " +
                " \n                               |       / _____      ______\\      |            " +
                " \n                               |        _-----\\    /-----_       |   " +
                " \n                               |       *   ()         ()  *      |   " +
                " \n                               |      |        /  \\       |     |   " +
                " \n                               |      \\       (    )      //     |   " +
                " \n                               /        |       `  `      |        \\  " +
                " \n                              /         \\    _---- _    /         \\     " +
                " \n                             |          \\   -       -   /           |   " +
                " \n                             |            -____________-             |" +
                " \n                             |            /              \\          |" +
                " \n-------------------------------------------------------------------------------------------------------------------------" + 
                " \n You reach for the knife Well knowing that the decision your about to make is going to hinder the rest of your experince in this death trap." +
                " \n Aswell as the rest of your life, if you make it out." +
                " \n Holding up the knife like out of a horror movie, just about to bring it down upon your foot, the door swings open releasing your foot and a Woman jumps through just like you did." +
                " \n She catches a glimps of you still holding up the knife, fearful, she backs up telling you to 'Stay Away'" +
                " \n Press Any Button To Continue 14:14";

            storyTable[10] = "                                  Page Eleven" +
                " \n" +
                " \n                             ___________________________                " +
                " \n                            /    -    -    -   -   -   \\=              " +
                " \n                            | ~~~ ~~~~ ~~~~ ~~~ ~~~ ~~~ |               " +
                " \n                            |  .          .           . (               " +
                " \n                   _________|                           '              " +
                " \n                  /  ~         \\---------------------------/            " +
                " \n                  |        ~             ~              ~   |              " +            
                " \n            ______|   .        .        .          .        . _    __    " +
                " \n           /  ~     \\----------------------------------------   ---     \\" +
                " \n           |      ~          ~            ~               ~             |" +
                " \n           |                                                            |" +
                " \n           |______        .      .          .         .   .       ______|" +
                " \n                 -----------_____________________________--------" +
                " \n--------------------------------------------------------------------------------------------------------------" +
                " \n After eating The Cake you start to feel a bit funny, grasping at your throat you uncontrollaby start coughing," +
                " \n blood splurting out with each exhale. " +
                " \n You Drop Dead In The Middle Of The Room 10:10";

            storyTable[11] = "                                  Page Twelve" +
                " \n                                   __________     __________" +
                " \n                                  /    -----  \\  //  -----   \\" +
                " \n                                 /         \\  \\//  /            \\" +
                " \n                               /         ___----------/__        \\" +
                " \n                               |        /                \\       |  " +
                " \n                               |       / _____      ______\\      |            " +
                " \n                               |        _-----\\    /-----_       |   " +
                " \n                               |       *    ()         ()  *     |   " +
                " \n                               |      |        /  \\       |     |   " +
                " \n                               |      \\       (    )      //     |   " +
                " \n                               /        |       `  `      |        \\  " +
                " \n                              /         \\    __---- __   /         \\     " +
                " \n                             |          \\      ----     /            |   " +
                " \n                             |            -____________-             |" +
                " \n                             |            /              \\          |" +
                " \n-------------------------------------------------------------------------------------------------------------------------" +
                " \n The Thought of cutting of your own foot sickens you, the knife might be useful later though, putting it in your pocket." +
                " \n You sit and wait for hours, but feels like days." +
                " \n Just when your about to pull out the knife and contemplate cutting your foot off again," +
                " \n The door swings open releasing your foot and a Woman jumps through it just like you did prior" +
                " \n She catches a glimps of you, reaches for your hand to help you up." +
                " \n  Press Any Button To Continue 14:14";

            storyTable[12] = "                                 Page Thirteen" +
                " \n Passing up the many elegant dishes was a very hard decison, walking past them you're still drooling, walking into the new room." +
                " \n You see a blinding Light, following it you escape the facility with no scratches " +
                " \n Good Job! 12:12";

            storyTable[14] = "                                Page Fifthteen" +
                " \n A voice booms from all sides of the room." +
                " \n ' ONLY ONE CAN PASS '" +
                " \n You both intensely stare at each other each waiting for each others move." +
                " \n Option A - KILL HER" +
                " \n Option B - Do Nothing 15:16";

            storyTable[15] = "                                Page Sixteen" +
                " \n You take the knife, the woman instanly knows whats going to happen, trying to run away from you" +
                " \n You chase her into a corner of the room, nowhere for her to go, she screams admitting defeat, curling into a fetal postion as you approach." +
                " \n With no empathy you stab her in the arm as she trys to protect her face, terror filled, agonizing screams release from her. " +
                " \n You stab until the screams stop and her body loses all life." +
                " \n A door slides open with a metallic screech, blinding light shining through. " +
                " \n Covered in the woman's blood you exit the facility, knife still in hand with no regrets. " +
                " \n You Sicko..... 15:15";

            storyTable[16] = "                                Page Seventeen" + 
                " \n You see that the woman starts to cry, not being strong enough to take the stress of not knowing if shes going to die." + 
                " \n You lay down the knife suggesting your not going to hurt her. " + 
                " \n The voice booms again." + 
                " \n 'ONE MUST DIE' " + 
                " \n Walls start to close in knowing both of you will, you decide to run back to the Spike pit room throwing yourself off of it" +
                " \n A door slides open with a metalic screach, blinding light shinning through. " +
                " \n The Woman walks through unharmed, you saving her life." +
                " \n You are a Hero! 16:16";
        }
        static void StoryFile(int storyLocation)
        {
            
            storyTable = File.ReadAllLines("Story.txt");

            
           // Console.Write(storyFile[0]);
           
        }

        static void Inisalization()
        {
            storySize = File.ReadLines("Story.txt").Count();
            
        }

        static void LoadSave()
        {
            using (StreamReader sr = new StreamReader("SaveData.txt"))
            {
                savedPageData = sr.ReadLine();
                saveCounter = sr.ReadLine();

            }

            int.TryParse(savedPageData, out currentPage);
            int.TryParse(saveCounter, out saves);

        }

        static void WinChecks()
        {
            if (storyTable[currentPage].Contains("Hero") || storyTable[currentPage].Contains("escape") || storyTable[currentPage].Contains("Sicko"))
            {

                YouWin();
                PlayerDead = true;

            }
        }
        static void DeathChecks()
        {
            if (storyTable[currentPage].Contains("dying") || storyTable[currentPage].Contains("Freeze")
               || storyTable[currentPage].Contains("Dead") || storyTable[currentPage].Contains("Man-Eating"))
            {
                
                GameOver();
                PlayerDead = true;
               
            }
        }
        static void Save()
        {
          using (StreamWriter sw = new StreamWriter("SaveData.txt"))
            {
                saves = saves - 1;
                sw.WriteLine(currentPage.ToString());
                sw.WriteLine(saves.ToString());
                sw.WriteLine(File.GetLastWriteTime("SaveData.txt"));
                Console.WriteLine("You Saved Your Game Sucessfully!");
                
            }
        }
        static void PageChanger()
        {
            
            string choiceA = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 3);

                choiceA = choiceA.Substring(choiceA.Length - 2);
            string choiceB =
                storyTable[currentPage].Substring(storyTable[currentPage].Length - 2);
         
            string pageHider = 
                storyTable[currentPage].Remove(storyTable[currentPage].Length - 5);

            string Text = pageHider.Replace("\\n", "\n");


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
                //Console.WriteLine(storyTable[currentPage].Length);
                int len = Text.Length;
                for (int i = 0; i < len; i++)
                {
                    Console.Write(Text[i]);
                }
                DeathChecks();
                WinChecks();


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
            else if (Input.Key == ConsoleKey.S)
            {
                Console.Clear();
                Save();
                Console.ReadKey(true);
                
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
            Console.WriteLine("                                             A Text Adventure Game                                                   ");
            Console.ResetColor();
            Console.WriteLine("                                          CONTINUE -> PRESS UP ARROW                                                 ");
            Console.WriteLine("                                         NEW GAME -> PRESS DOWN ARROW");
           
           
           
        }

        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     |||||||    ||||     |    |    |||||||     ||||||    |     ||   |||||||   ||||||    ||||");
            Console.WriteLine("    ||||||||   ||||||   |||  |||  |||||| |    |||  |||  ||     ||  |||||| |  |||  |||   ||||");
            Console.WriteLine("    ||        |||   ||  |||  |||  ||    |     ||    ||  ||     ||  ||    |   ||    ||   ||||");
            Console.WriteLine("    ||        ||    ||  ||||||||  ||          ||    ||  ||     ||  ||        ||    ||   ||||");
            Console.WriteLine("    ||  ||||  ||    ||  ||||||||  ||||||||    ||    ||  ||     ||  ||||||||  ||    ||   ||||");
            Console.WriteLine("    ||   |||  ||    ||  || || ||  ||||||||    ||    ||  ||     ||  ||||||||  ||||||||    || ");
            Console.WriteLine("     |    |   ||||||||  ||    ||  ||          ||    ||  ||     ||  ||        |||||||     || ");
            Console.WriteLine("    ||    ||  ||    ||  ||    ||  ||          ||    ||   ||   ||   ||        ||  ||         ");
            Console.WriteLine("    ||||||||  ||    ||  ||    ||   |||||||     |||||||   |||||||    |||||||  ||   ||     || ");
            Console.WriteLine("     |||  |   |      |  ||    ||   |||| ||      |||||     |||       ||||| |  |     ||    || ");
            Console.ResetColor();
           
            
        }

        public static void YouWin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("    |||  |||   ||||||     |     ||    ||    ||   ||   |    ||  ||||");
            Console.WriteLine("    |||  |||  |||  |||   ||     ||    ||    ||   ||  |||   ||  ||||");
            Console.WriteLine("    |||  |||  ||    ||   ||     ||    ||    ||       ||||  ||  ||||");
            Console.WriteLine("    |||  |||  ||    ||   ||     ||    ||    ||   ||  || || ||  ||||");
            Console.WriteLine("     ||  ||   ||    ||   ||     ||    || || ||   ||  || || ||  ||||");
            Console.WriteLine("      ||||    ||    ||   ||     ||    ||||||||   ||  || || ||   || ");
            Console.WriteLine("      ||||    ||    ||   ||     ||    ||||||||   ||  || || ||   || ");
            Console.WriteLine("       ||     ||    ||   ||     ||    |||  |||   ||  || || ||      ");
            Console.WriteLine("       ||      |||||||   ||   ||      |||  |||   ||  ||  ||||   || ");
            Console.WriteLine("       ||       |||||    |||||||       |    |    ||  ||    ||   || ");
            Console.ResetColor();

        }

        

    }
}
