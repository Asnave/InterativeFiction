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
        static int x = 0;
        static int y = 0;
        static string[,] story = new string[,]
        {

        {"Title","Page1"},
        {"Page2","Page3"},
        {"Your on page 2","your on page 3" },
        {"Go to page2","Go to page3",},

        };



        static void Main(string[] args)
        {
              // how am I supposed to do this......
             // GameLoops for player interaction
            // I need to make triggers - when button is pressed choice is displayed (if statments)
           // Use string array for story text

            while (gameOver == false)
            {
                Console.WriteLine(story[1, 1]);
                Console.WriteLine("");
                Console.WriteLine(story[1, 2]);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("<A> "+ story[4, 1]);
                Console.WriteLine("<B> " + story[4, 2]);


            }


        }
        static void Inputs()
        {

            ConsoleKeyInfo Input = Console.ReadKey(intercept: true);

            if (Input.Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.Write(story[2, 1]);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(story[3,1]);

            }
            else if (Input.Key == ConsoleKey.B)
            {
                Console.Clear();
                Console.Write(story[2, 2]);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(story[3, 2]);
            }
            else if (Input.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine(story[1, 1]);
                Console.WriteLine("");
                Console.WriteLine(story[1, 2]);

            }

        }





    }
}
