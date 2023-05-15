using System.Threading;
using System.IO;
using System;
namespace storyTeller
{
    public class Job
    {
        //add multiple empty lines
        public static void addEmptyLines(int amount = 100)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
            }

        }
        //read each line from a file
        public static void readFile(string fileName, int delay = 40)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                int lineCounter = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    //for char loop in string line
                    foreach (char c in line)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(delay);
                    }
                    //depending at the line we are at, print the corresponding image depending on the story 
                    generateImage(fileName, lineCounter);
                    lineCounter++;
                    int speed = Console.ReadKey(true).KeyChar;
                    if (speed == 'i')
                    {
                        delay = delay - 20;
                        addEmptyLines(2);
                        Console.WriteLine("Speed of text print has been set to {0}", delay);
                    }
                    else if (speed == 'r')
                    {
                        delay = delay + 20;
                        addEmptyLines(2);
                        Console.WriteLine("Speed of text print has been set to {0}", delay);

                    }
                    addEmptyLines(1);

                    //got to third base with c# today -Sasha ^
                }
            }
        }
        /// <summary>
        /// This function generates an image with a specified filename and line number.
        /// </summary>
        /// <param name="filename">The filename parameter is a string that represents the name of the
        /// image file that will be generated.</param>
        /// <param name="line">The line parameter is an integer that represents the line number in the
        /// story where the image will be generated for.</param>
        public static void generateImage(string filename, int line)
        {
            addEmptyLines(1);
            //fetch all the image txt files and store them in an array 
            string[] images = Directory.GetFiles("images");
            //note: line 12 for dagon to render the monolith 1 index
            //note: line 15 for dagon to render the creature 2 inddex
            //note: line 4  for dagon to render the landscape of black slime
            if (line == 12)
            {
                string[] display = File.ReadAllLines(images[1]);
                foreach (string row in display)
                {
                    Console.WriteLine(row);
                }
            }
            else if (line == 15)
            {
                string[] display = File.ReadAllLines(images[2]);
                foreach (string row in display)
                {
                    Console.WriteLine(row);
                }
            }

        }
    }
}