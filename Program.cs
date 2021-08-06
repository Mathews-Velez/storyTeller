using System;
using System.IO;
using Figgle;

namespace storyTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome user to the program
            Console.WriteLine(FiggleFonts.Standard.Render("\n\n\nStory Teller Companion : 3\n\n\n"));
            Job.addEmptyLines(4);

            //fetch the folder with all the stories inside of it
            string[] dirs = Directory.GetFiles("stories");

            //ask user to pick from the stories available in the stories folder
            int fileChoice;
            Char usersChoice;

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
                Console.WriteLine(dirs[fileChoice]+" has been selected\n\n\n");

                Job.readFile(dirs[fileChoice], 70);


            

        }
    }
}
