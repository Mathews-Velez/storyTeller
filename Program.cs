using System;
using System.IO;
using Figgle;

namespace storyTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean loop = true;

            // welcome user to the program
            while (loop)
            {
                Job.addEmptyLines(100);
                string mssg = FiggleFonts.Standard.Render("\n\n\nLovecraft's interactive story teller\n\n\n");
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", mssg));
                Job.addEmptyLines(4);

                //fetch the folder with all the stories inside of it
                string[] dirs = Directory.GetFiles("stories");

                Console.WriteLine("Please select from the following stories available");

                foreach (string dir in dirs)
                {
                    string fileName = Path.GetFileName(dir);
                    Console.WriteLine(Array.IndexOf(dirs, dir) + ". " + fileName);
                }

                //ask user to select which file is theirs
                Job.addEmptyLines(3);
                int fileChoice = 0;
                bool valid = true;
                //validate user input
                while (valid)
                {
                    try
                    {
                        fileChoice = Convert.ToInt32(Console.ReadLine());
                        valid = false;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a valid choice.");
                    }
                }
                Job.addEmptyLines(3);
                String nameOfFile = Path.GetFileNameWithoutExtension(dirs[fileChoice]);
                Console.WriteLine(nameOfFile + " has been selected\n\n\n");

                //tell the user how to use use the readfile method
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Instructions"));
                Console.WriteLine("After each line is printed from the selected story you will be able to enter 'r' (reduce) or 'i' (increase) to manipulate the speed at which the text is being printed otherwise press enter to continue the story. Press any key to continue.");
                Console.ReadKey();
                Job.addEmptyLines(10);
                Job.readFile(dirs[fileChoice], 10);
                Job.addEmptyLines(5);

                Console.WriteLine("Would you like to read another story?(y or n)");
                char usersChoice = Console.ReadLine()[0];

                if (usersChoice == 'n')
                {
                    loop = false;
                }

            }
        }
    }
}
