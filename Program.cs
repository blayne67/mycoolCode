using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Explorer you have found a cave. What should we call you?");

        var playerName = Console.ReadLine();

        Console.WriteLine("good luck {0} have fun and try not to die", playerName);

        




        Console.WriteLine("Room Description");

            Console.WriteLine("You are in a cave that ls about 20 ft tall but you look into the ditance and see lt geting smaler and smaller you have. YOU HAVE 5 FLARES, A FLASHLIGHT, FOOD AND WATER");

                Console.WriteLine("");

                Console.WriteLine("do you want to shoot a flare to see what is in front of you");

                Console.WriteLine(": ");

                var command = Console.ReadLine();

                    if(command == "Yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("you shoot the flare and see 2 ways to go. Left or Right!");
                    }
                    else if(command == "No")
                    {
                        Console.WriteLine("you do not know what is infront of you and you fall into a pit full of spikes");
                        Console.WriteLine("you die GAME OVER");
                    }
                    else
                    {
                        Console.WriteLine("THIS IS NOT A COMMAND!");
                    }
        

                Console.WriteLine("");
        
                Console.WriteLine("do you wnat to go down the Left or Right path");

                Console.WriteLine(": ");
        
                var COMMAND = Console.ReadLine();
        
                if(COMMAND == "Left")
                {
                    Console.WriteLine("you walk down the left path and soon realize that this path is getting to small for you to crawl down");
                    Console.WriteLine("you must turn around and go down the Right path");
                }

                else if(COMMAND == "Right")
                {
                    Console.WriteLine("you start walking down the path 3 mins in you find a a man sleeping you woke him up he says ''are you here to try to find gold'' you say GOLD I did not know that there was gold in this cave he say ''yes there is gold but there only a silm chance that you will make it to the gold i can help you but it will cost you your food");
                }

                else
                {
                    Console.WriteLine("THIS IS NOT A COMMAND");
                }
   }
}