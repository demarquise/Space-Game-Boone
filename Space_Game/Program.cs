using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string playername = "";


            {
                Console.WriteLine("Welcome to Space Game");
                Console.ReadLine();
                Console.Write("Enter your playername : ");
                playername = Console.ReadLine();
                Console.WriteLine("Welcome: " + playername);

                Console.ReadLine();
                Console.WriteLine("This is the story line of:  " + playername);
                Console.WriteLine("This space game is about a space traveler named " + playername + " who was from a destroyed  planet named Z22." +
                    "The inner core of his planet blew up causing  everything and everyone on his planet to parish." +
                    playername + " was the only survivor on his planet to make it out from a small 1 passenger space capsule" +
                    "that his dad built. His dad before he died was able to put him in it before the planet blew. his dad left him 20,000$ an set the ship" +
                    "to go to the nearest human livable planet witch happen to be planet earth." + playername + " lived on earth secretly" +
                    "without ever being seen staying on a deserted island. Here he was able to build a boat and sail to the nearest" +
                    "mainland" + playername + " quickly takes notice to the G market trading post which is a  international space trading center." +
                    "Here you can buy space ships an cargo." + playername + " has 20,000$ and wants a ship an cargo to get to another planet to trade cargo");
                Console.ReadLine();
                Console.WriteLine("You are now at planet Earth trading post, you have $20,000 earth dollars you neeed a space ship and cargo frist pick ship" +
                    " then cargo ");
                Console.ReadLine();
                Console.WriteLine("Choice:A small ship = $500   | Cargo compacity = 5,000 lb  | 1 warp speed  ");
                Console.WriteLine("Choice:B medium ship = $1000 | Cargo compacity = 10,000 lb | 2 warp speed  ");
                Console.WriteLine("Choice:C large ship = $2,000 | Cargo compacity = 20,000 lb | 3 warp speed  ");
                
                Console.WriteLine("Make a choice?");
                string userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "a")
                {
                    Console.WriteLine("You picked small ship.");
                    
                }
                else if (userChoice.ToLower() == "b")
                {
                    Console.WriteLine("You picked medium ship.");
                }
                else if(userChoice.ToLower() == "c")
                {
                    Console.WriteLine("You picked large ship.");
                }

            }

        }
    }
}
