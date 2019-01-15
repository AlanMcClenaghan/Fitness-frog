using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            double runningTotal = 0;
            bool keepGoing = true;
            

            while (keepGoing) 
            {
                // Prompt user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");
                string entry = System.Console.ReadLine();
                
                if (entry.ToLower() == "quit")
                {
                    keepGoing = false;
                }
                else
                {
   
                // Exception handling
                try
                {
                    double minutes = double.Parse(entry);
                    
                    if(minutes <= 0)
                    {
                        //  input validation
                        Console.WriteLine("That is not an acceptable number!");
                        continue;
                    }
                    else if(minutes <= 10)
                    {
                        Console.WriteLine("You must do better!");
                    }
                    else if(minutes <= 30)
                    {
                        Console.WriteLine("Nice work!");
                    }
                    else if(minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {        
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                    
                    // Add minutes exercised to total 
                
                    runningTotal = runningTotal + minutes;
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("That is not valid input");
                    continue;
                }

                // Display total minutes exercised to the screen 
                Console.WriteLine("You've entered " + runningTotal + " minutes.");  
                }

            }
            
            // Repeat until user quits
            Console.WriteLine("Goodbye");
        
        }
    }
}
