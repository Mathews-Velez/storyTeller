using System.Threading;
using System.IO;
using System;
namespace storyTeller
{
    public class Job
    {
        //add multiple empty lines
        public static void addEmptyLines(int amount=100){
            for (int i = 0; i < amount; i++){
                Console.WriteLine();
            }

        }
        //read each line from a file
        public static void readFile(string fileName, int delay = 40){
            using (StreamReader reader = new StreamReader(fileName)){
                string line;
                while((line = reader.ReadLine()) != null){
                    

                    //for char loop in string line
                    foreach (char c in line){
                        Console.Write(c);
                        System.Threading.Thread.Sleep(delay);
                    }

                    //delay between each line
                    //int miliseconds = 500;
                    //Thread.Sleep(miliseconds);
                    int speed = Console.ReadKey(true).KeyChar;

                    if (speed=='i'){
                        delay = delay - 20;
                        addEmptyLines(2);
                        Console.WriteLine("Speed of text print has been set to {0}",delay);
                    } else if(speed == 'r'){
                        delay = delay +20;
                        addEmptyLines(2);
                        Console.WriteLine("Speed of text print has been set to {0}",delay);

                    } else {
                    }
                    addEmptyLines(1);


                    //got to third base with c# today -Sasha ^
                }
            }
        }    
    }
}