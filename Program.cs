﻿using System;
using System.IO;
using Figgle;

namespace storyTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome user to the program

            Job.addEmptyLines(100);
            string mssg = FiggleFonts.Standard.Render("\n\n\nStory Teller Companion\n\n\n");
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}",mssg));
            Job.addEmptyLines(4);

            //fetch the folder with all the stories inside of it
            string[] dirs = Directory.GetFiles("stories");

            //ask user to pick from the stories available in the stories folder
            int fileChoice;
            

            Console.WriteLine("Please select from the following stories available");

            //list the current contents of the stories folder
            int spot = 0;

            foreach(string dir in dirs){
                string fileName= Path.GetFileName(dir);
                Console.WriteLine(spot+". "+fileName);
                spot++;
            }

            //ask user to select which file is theirs
            Job.addEmptyLines(3);
            fileChoice = Convert.ToInt32(Console.ReadLine());
            Job.addEmptyLines(3);
            String nameOfFile = Path.GetFileNameWithoutExtension(dirs[fileChoice]);
            Console.WriteLine(nameOfFile+" has been selected\n\n\n");

            //tell the user how to use use the readfile method
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}","Instructions"));
            Console.WriteLine("After each line is printed from the selected story you will be able to enter 'r' (reduce) or 'i' (increase) to manipulate the speed at which the text is being printed otherwise press enter to continue the story. Press any key to continue.");
            Console.ReadKey();
            Job.addEmptyLines(10);
            Job.readFile(dirs[fileChoice], 70);


            

        }
    }
}
