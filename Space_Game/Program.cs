using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Program
    {
        
        static int cargo1 = 5000;
        static int cargo2 = 10000;
        static int cargo3 = 15000;
        static int main = 20000;
        static int a = 500;
        static int b = 1000;
        static int c = 2000;
        static string playername = "";

        static void Main(string[] args)
        {
            
           
            gamename();
            ship();
            cargo();
            planet();

        }

        public static void gamename()
        {


            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "ASCII Art";
            string title = @"
 ____                                     ______    __    ___             
/\  _`\                                  /\__  _\__/\ \__/\_ \            
\ \ \L\_\ __      ___     ___   __  __   \/_/\ \/\_\ \ ,_\//\ \      __   
 \ \  _\/'__`\  /' _ `\  /'___\/\ \/\ \     \ \ \/\ \ \ \/ \ \ \   /'__`\ 
  \ \ \/\ \L\.\_/\ \/\ \/\ \__/\ \ \_\ \     \ \ \ \ \ \ \_ \_\ \_/\  __/ 
   \ \_\ \__/.\_\ \_\ \_\ \____\\/`____ \     \ \_\ \_\ \__\/\____\ \____\
    \/_/\/__/\/_/\/_/\/_/\/____/ `/___/> \     \/_/\/_/\/__/\/____/\/____/
                                    /\___/                                
                                    \/__/                                 
                                                                 ";

            Console.WriteLine(title);
            Console.Read();

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
            Console.Clear();
        }
        public static void ship()
        {

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
                    main = main - a;
                    Console.WriteLine("You picked small ship.");
                    Console.WriteLine("You have " + main + " left");
                    pickedShip = true;
                }
                else if (userChoice.ToLower() == "b")
                {
                    main = main - b;
                    Console.WriteLine("You picked medium ship.");
                    Console.WriteLine("you have " + main + " left");
                    pickedShip = true;
                }
                else if (userChoice.ToLower() == "c")
                {
                    main = main - c;
                    Console.WriteLine("You picked large ship.");
                    Console.WriteLine("you have" + main + "left");
                    pickedShip = true;
                }
                else
                {
                    Console.WriteLine("Choose A,B or C ");


                }
            } while (pickedShip == false);
            Console.ReadLine();
            Console.Clear();

        }

        public static void cargo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

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
                    main = main - cargo1;
                    Console.WriteLine("You picked 5,000 lbs");
                    Console.WriteLine("you have " + main + " left");
                    choose = true;
                }
                else if (userPick.ToLower() == "b")
                {
                    main = main - cargo2;
                    Console.WriteLine("You picked 10,000 lbs");
                    Console.WriteLine("you have " + main + " left");
                    choose = true;
                }
                else if (userPick.ToLower() == "c")
                {
                    main = main - cargo3;
                    Console.WriteLine("You picked 15,000 lbs");
                    Console.WriteLine("you have " + main + " left");
                    choose = true;
                }
                else
                {
                    Console.WriteLine("choose A,B or C");
                }
            } while (choose == false);
            Console.ReadLine();
            Console.Clear();
        }
        public static void planet()
        {
            Console.ForegroundColor = ConsoleColor.Green;

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

            Console.WriteLine("Good luck " + playername + " on your advernture the time right below is the time it is now ");

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

            Console.WriteLine("you have a arived at your destination");
            DateTime timenow = DateTime.Now;
            Console.WriteLine(timenow.AddYears(3));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How much cargo would you like to trade");
            Console.WriteLine("you can only trade 50,100,200");
            Console.WriteLine("choose A for 50");
            Console.WriteLine("choose B for 100");
            Console.WriteLine("choose C for 200");

            

            string pick = Console.ReadLine();

                switch (pick)
                {
                    case "a":
                        main = main + 50;
                        Console.WriteLine("you sold 50 punds of cargo");
                        Console.WriteLine("you have " + main + " left");
                         break;

                    case "b":
                        main = main + 100;
                        Console.WriteLine("you sold  100 pounds of cargo");
                        Console.WriteLine("you have " + main + " left");
                         break;

                    case "c":
                        main = main + 200;
                        Console.WriteLine("you sold 200 pounds of cargo");
                        Console.WriteLine("you have " + main + " left");
                         break;

                    default:
                        Console.WriteLine("choose again");
                        break;

                    

                }

            Console.ReadLine();




        }

















    }
}
