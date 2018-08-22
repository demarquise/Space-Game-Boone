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
                

                Console.WriteLine("Welcome to Space Game --------|------|---------|");
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
                Console.WriteLine("Choice:C large ship = $2,000 | Cargo compacity = 15,000 lb | 3 warp speed  ");
                Console.WriteLine("Make a choice?");
                

                bool pickedShip = false;
                do
                {
                    string userChoice = Console.ReadLine();

                    if (userChoice.ToLower() == "a")
                    {
                        Console.WriteLine("You picked small ship.");
                        Console.WriteLine("You have $19,500 left.");
                        pickedShip = true;
                    }
                    else if (userChoice.ToLower() == "b")
                    {
                        Console.WriteLine("You picked medium ship.");
                        Console.WriteLine("You have $19,000 left.");
                        pickedShip = true;
                    }
                    else if (userChoice.ToLower() == "c")
                    {
                        Console.WriteLine("You picked large ship.");
                        Console.WriteLine("You have $18,000.");
                        pickedShip = true;
                    }
                    else
                    {
                        Console.WriteLine("Choose A,B or C ");


                    }
                } while (pickedShip == false);
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You can now tranport Uriuman ");
                Console.WriteLine("The trade value of uriuman is 1lb of uriuman is equal to 1 dallor.");
                Console.WriteLine("You choice of wheight of cargo is dependent on ship size.");
                Console.WriteLine("choice A | 5,000 lbs if you choose small");
                Console.WriteLine("choice B | 10,000 lbs if you choose medium");
                Console.WriteLine("choice C | 15,000 lbs if you choose large");
                Console.WriteLine(" Make a pick?");
                bool choose = false;
                do
                {
                    string userPick = Console.ReadLine();

                    if (userPick.ToLower() == "a")
                    {
                        Console.WriteLine("You picked 5,000 lbs");
                        choose = true;
                    }
                    else if (userPick.ToLower() == "b")
                    {
                        Console.WriteLine("You picked 10,000 lbs");
                        choose = true;
                    }
                    else if (userPick.ToLower() == "c")
                    {
                        Console.WriteLine("You picked 15,000 lbs");
                        choose = true;
                    }
                    else
                    {
                        Console.WriteLine("choose A,B or C");
                    }
                } while (choose == false);
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Now " + playername + " has chosen cargo an a space ship and are ready to travel |--|");
                Console.WriteLine("What planet would you like to go to");
                Console.WriteLine("choice A | planet : BOT");
                Console.WriteLine("choice B | planet : TOPA");
                Console.WriteLine("Choice C | planet : KEWA");
                Console.WriteLine("Enter A,B or C");

                bool myanswer = false;
                do
                {
                    
                    string myplanet = Console.ReadLine();
                    if (myplanet.ToLower() == "a")
                    {
                        Console.WriteLine("You have choosen planet BOT");
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "b")
                    {
                        Console.WriteLine("You choose planet TOPA");
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "c")
                    {
                        Console.WriteLine("You choose planet KEWA");
                        myanswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Choose A,B or C");
                    }

                } while (myanswer == false);
                Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Good luck "+ playername +" on your advernture the time right below is the time it is now ");

                DateTime thetime = DateTime.Now;
                Console.WriteLine(thetime.ToString());
                Console.ReadLine();

                Console.Clear();

                Console.WriteLine("    ---");
                Console.WriteLine("  -------");
                Console.WriteLine("  -------");
                Console.WriteLine("   -----");
                Console.WriteLine("      |  ");
                Console.WriteLine("      |  ");
                Console.WriteLine("      |  ");
                Console.WriteLine("      |  ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("      |  ");
                Console.WriteLine("      |  ");
                Console.WriteLine("      |  ");
                Console.WriteLine("    ---");
                Console.WriteLine("  -------");
                Console.WriteLine("  -------");
                Console.WriteLine("   -----");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("you are at your destination the time is now");
                DateTime timenow = DateTime.Now;
                Console.WriteLine(timenow.AddYears(3));
                
            
                
















            }

        }
    }
}
