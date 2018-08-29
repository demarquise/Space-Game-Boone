using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Space_Game
{
    class Program
    {

        static readonly int cargo1 = 5000;
        static readonly int cargo2 = 10000;
        static readonly int cargo3 = 15000;
        static int main = 20000;
        static readonly int a = 500;
        static readonly int b = 1000;
        static readonly int c = 2000;
        static string playername = "";
        static readonly int fuel1 = 2000;
        static readonly int fuel2 = 4000;


        static void Main(string[] args)
        {


            Gamename();
            Ship();
            Cargo();

            do
            {
                Planet();
                Nextplanet();

            }
            while (main > 0);

            Exit();

        }


        public static void Gamename()
        {


            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "ASCII Art";
            string title = @"

─────────────────────────▄▀█▀█▀▄
────────────────────────▀▀▀▀▀▀▀▀▀
─────────█──────────────▄─░░░░░▄
─▄─█────▐▌▌───█──▄─▄───▐▌▌░░░░░▌▌
▐█▐▐▌█▌▌█▌█▌▄█▐▌▐█▐▐▌█▌█▌█░░░░░▌▌
█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
█░█░░░█ █▀▀ █░░ █▀▀ █▀▀█ █▀▄▀█ █▀▀ ░█                       By Demarquise & Derrick |Games|
█░█▄█▄█ █▀▀ █░░ █░░ █░░█ █░▀░█ █▀▀ ░█
█░░▀░▀░ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀░░░▀ ▀▀▀ ░█
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                              
                                    Press Enter To Continue             ";

            Console.WriteLine(title);
            Console.Read();

            Console.WriteLine("Welcome to Space Game --------|------|---------|");
            Console.ReadLine();

            Console.Write("Enter your playername and press enter: ");
            playername = Console.ReadLine();
            Console.WriteLine("Welcome: " + playername);
            Console.WriteLine("                                    Press Enter To continue                               ");


            Console.ReadLine();
            Console.WriteLine("This is the story line of:  " + playername);
            Console.WriteLine("This space game is about a space traveler named " + playername + " who was from a destroyed  planet named Z22." +
                "The inner core of his planet blew up causing  everything and everyone on his planet to parish." +
                playername + " was the only survivor on his planet to make it out from a small 1 passenger space capsule" +
                "that his dad built. His dad before he died was able to put him in it before the planet blew. his dad left him 20,000$ an set the ship" +
                "to go to the nearest human livable planet witch happen to be planet earth." + playername + " lived on earth secretly" +
                "without ever being seen staying on a deserted island. Here he was able to build a boat and sail to the nearest" +
                "mainland" + playername + " quickly takes notice to the G market trading post which is a  international space trading center." +
                "Here you can buy space ships an cargo." + playername + " has 20,000$ and wants a ship an cargo to get to another planet to trade cargo" +
                "                                     " +
                "Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You are now at planet Earth trading post, you have $20,000 earth dollars you neeed a space ship and cargo frist pick ship" +
                " then cargo ");
            Console.WriteLine("Press Enter To continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Good luck");
            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.Title = "ASCII Art";
            string sign = @"




$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
$$$$$$$$$$$$$$$$$$$$$$$$_____$$$$
$$$$_____$$$$$$$$$$$$$$$_____$$$$
$$$$_____$$$$$$$$$$$$$$$_____$$$$
$$$$_____$$____$$$____$$_____$$$$
$$$$_____$______$______$_____$$$$
$$$$_____$______$______$_____$$$$
$$$$_____$____$$$$$$$$$$$$$$$$$$$
$$$$_____$___$$___________$$$$$$$
$$$$_____$__$$_______________$$$$
$$$$__________$$_____________$$$$
$$$$___________$$___________$$$$$
$$$$_____________$_________$$$$$$
$$$$$_____________________$$$$$$$
$$$$$$___________________$$$$$$$$
$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                              
                                 Press Enter To Continue                           ";

            Console.WriteLine(sign);
            Console.Read();
            Console.ReadLine();
            Console.Clear();


        }
        public static void Ship()
        {
            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Choice:A small ship = $500   | Cargo compacity = 5,000 lb  | 1 warp speed  ");
            Console.WriteLine("Choice:B medium ship = $1000 | Cargo compacity = 10,000 lb | 2 warp speed  ");
            Console.WriteLine("Choice:C large ship = $2,000 | Cargo compacity = 15,000 lb | 3 warp speed  ");
            Console.WriteLine("Make a choice?");
            Console.WriteLine("                   Press Enter To Continue                 ");

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
                    Console.WriteLine("you have " + main + " left");
                    pickedShip = true;
                }
                else
                {
                    Console.WriteLine("Choose A,B or C ");


                }
            } while (pickedShip == false);
            Console.WriteLine("                            Press Enter To Continue                 ");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Cargo()
        {
            
            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("You can now tranport Uriuman ");
            Console.WriteLine("The trade value of uriuman is 1lb of uriuman is equal to 1 dallor.");
            Console.WriteLine("You choice of wheight of cargo is dependent on ship size.");
            Console.WriteLine("choice A | 5,000 lbs if you choose small");
            Console.WriteLine("choice B | 10,000 lbs if you choose medium");
            Console.WriteLine("choice C | 15,000 lbs if you choose large");
            Console.WriteLine(" Make a pick?");
            Console.WriteLine("                            Press Enter To Continue                 ");
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
            Console.WriteLine("                            Press Enter To Continue                 ");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Planet()
        {
            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Now " + playername + " has chosen cargo an a space ship and are ready to travel |--|");
            Console.WriteLine("What planet would you like to go to");
            Console.WriteLine("choice A | planet : BOT");
            Console.WriteLine("choice B | planet : TOPA");
            Console.WriteLine("Choice C | planet : KEWA");
            Console.WriteLine("Choice D | planet : DAD");
            Console.WriteLine("Choice E | planet : MOM");
            Console.WriteLine("Choice F | planet : HAM");
            Console.WriteLine("Choice G | planet : BAT");
            Console.WriteLine("Choice H | planet : GOD");
            Console.WriteLine("Enter one from the list above");
            Console.WriteLine("                            Press Enter To Continue                 ");



            bool myanswer = false;
            do
            {

                string myplanet = Console.ReadLine();
                if (myplanet.ToLower() == "a")
                {
                    Planet planet = new Planet();
                    planet.Name = "BOT";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;

                }
                else if (myplanet.ToLower() == "b")
                {
                    Planet planet = new Planet();
                    planet.Name = "TOPA";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "c")
                {
                    Planet planet = new Planet();
                    planet.Name = "KEWA";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "d")
                {
                    Planet planet = new Planet();
                    planet.Name = "DAD";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "e")
                {
                    Planet planet = new Planet();
                    planet.Name = "MOM";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "f")
                {
                    Planet planet = new Planet();
                    planet.Name = "HAM";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "g")
                {
                    Planet planet = new Planet();
                    planet.Name = "BAT";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else if (myplanet.ToLower() == "h")
                {
                    Planet planet = new Planet();
                    planet.Name = "GOD";
                    Console.WriteLine("You choose planet " + planet.Name);
                    myanswer = true;
                }
                else
                {
                    Console.WriteLine("Choose Again");
                }

            } while (myanswer == false);
            Console.WriteLine("                            Press Enter To Continue                 ");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Good luck " + playername + " on your advernture the time right below is the time it is now ");

            DateTime thetime = DateTime.Now;
            Console.WriteLine(thetime.ToString());
            Console.WriteLine("                            Press Enter To Continue                 ");
            Console.ReadLine();

            Console.Clear();

            Console.Title = "ASCII Art";
            string pic = @"

                    ──────────────▄▀█▀█▀▄
─────────────▀▀▀▀▀▀▀▀▀ 
─────────────▄─░░░░░▄
───█──▄─▄───▐▌▌░░░░░▌▌
▌▄█▐▌▐█▐▐▌█▌█▌█░░░░░▌▌

                              
                                 Press Enter To Continue                           ";

            Console.WriteLine(pic);
            Console.Read();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("you have a arived at your destination");
            DateTime timenow = DateTime.Now;
            Console.WriteLine(timenow.AddYears(3));
            Console.WriteLine("                            Press Enter To Continue                 ");
            Console.ReadLine();
            Console.Clear();

            
            Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("How much urianium would you like to trade for money");
            Console.Write("Enter your number and press enter to continue:");
            string choice = "";
            choice = Console.ReadLine();
            main = main + Convert.ToInt32(choice);


            Console.WriteLine("you have traded " + choice);
            Console.WriteLine("you have " + main + " now");
            Console.ReadLine();
            Console.WriteLine("                            Press Enter To Continue                 ");
            Console.Clear();






        }
        public static void Nextplanet()
        {


            Console.WriteLine("Good job " + playername + " on your urianiam trade");
            Console.WriteLine("You have " + main + " left");
            Console.WriteLine("You should go to another planet now witch planet would you like to go to now");
            Console.WriteLine("                            Press Enter To Continue                 ");
            do
            {
                Console.WriteLine("choice A | planet : BOT");
                Console.WriteLine("choice B | planet : TOPA");
                Console.WriteLine("Choice C | planet : KEWA");
                Console.WriteLine("Choice D | planet : DAD");
                Console.WriteLine("Choice E | planet : MOM");
                Console.WriteLine("Choice F | planet : HAM");
                Console.WriteLine("Choice G | planet : BAT");
                Console.WriteLine("Choice H | planet : GOD");
                Console.WriteLine("Enter one from the list above");
                Console.WriteLine("                            Press Enter To Continue                 ");


                bool myanswer = false;
                do
                {

                    string myplanet = Console.ReadLine();
                    if (myplanet.ToLower() == "a")
                    {
                        Planet planet = new Planet();
                        planet.Name = "BOT";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "b")
                    {
                        Planet planet = new Planet();
                        planet.Name = "TOPA";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "c")
                    {
                        Planet planet = new Planet();
                        planet.Name = "KEWA";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "d")
                    {
                        Planet planet = new Planet();
                        planet.Name = "DAD";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "e")
                    {
                        Planet planet = new Planet();
                        planet.Name = "MOM";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "f")
                    {
                        Planet planet = new Planet();
                        planet.Name = "HAM";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "g")
                    {
                        Planet planet = new Planet();
                        planet.Name = "BAT";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else if (myplanet.ToLower() == "h")
                    {
                        Planet planet = new Planet();
                        planet.Name = "GOD";
                        Console.WriteLine("You choose planet " + planet.Name);
                        myanswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Choose Again");
                    }

                } while (myanswer == false);
                Console.ReadLine();
                Console.WriteLine("                            Press Enter To Continue                 ");
                Console.Clear();

                Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
                Console.WriteLine("");
                Console.WriteLine("the current time now is");

                DateTime thetime = DateTime.Now;
                Console.WriteLine(thetime.ToString());

                Console.WriteLine("Goodluck on your trip");
                Console.WriteLine("                            Press Enter To Continue                 ");
                Console.ReadLine();
                Console.WriteLine("                            Press Enter To Continue                 ");
                Console.Clear();

                Console.Title = "ASCII Art";
                string pic = @"

                      ──────────────▄▀█▀█▀▄
─────────────▀▀▀▀▀▀▀▀▀ 
─────────────▄─░░░░░▄
───█──▄─▄───▐▌▌░░░░░▌▌
▌▄█▐▌▐█▐▐▌█▌█▌█░░░░░▌▌

                              
                                         Press Enter To Continue                   ";

                Console.WriteLine(pic);
                Console.Read();
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
                Console.WriteLine("");
                DateTime timenow = DateTime.Now;
                Console.WriteLine(timenow.AddYears(3));
                Console.WriteLine("                            Press Enter To Continue                 ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("-------------------------money-> " + main + " <-money---------------------------------");
                Console.WriteLine("");
                Console.WriteLine("looks like you are going to need some fuel now");
                Console.WriteLine("how much would you like");
                Console.WriteLine("1/2 full 2000$ select : A | full 4000$ select : B");
                Console.WriteLine("                                                            Press Enter To Continue                 ");
                
                string choose = Console.ReadLine();
                switch (choose)

                {
                    case "a":
                        main = main - fuel1;
                        Console.WriteLine("you picked 1/2 full");
                        Console.WriteLine("you have " + main + " left");
                        break;

                    case "b":
                        main = main - fuel2;
                        Console.WriteLine("you picked 1/2 full");
                        Console.WriteLine("you have " + main + " left");
                        break;

                    default:
                        Console.WriteLine("Choose Again");
                        break;

                }
                Console.WriteLine("                            Press Enter To Continue                 ");

                Console.ReadLine();
                Console.Clear();
                if (main > 0)
                    break;
            } while (false);

        }
        public static void Exit()
        {


            Console.WriteLine("OOO NOOOO LOOKS LIKE YOU ARE OUT OF Money");
            Console.WriteLine("                            Press Enter To Continue                 ");

            Console.Title = "ASCII Art";
            string bye = @"


░░░░░░░░░░░░░░░░░░
░░░│▒./▒/░░░░░░░░░
░░░│▒│/▒/░░░░░░░░░░
░░░│▒ /▒/.░░░░░░
░░░│▒│▒|▒│▒│░░░░░░░
░░░┌┴─┴─┐┘─┘░░░░░░
░░░│▒┌──┘▒▒▒│░░░░░
░░░└┐▒▒▒▒▒▒┌┘░░░░░
░░░░└┐▒▒▒▒┌┘░░░░░░
░░░░░░░░░░░░░░░░░░
░█▀█░██░█▀█░█▀░██░
░█░█░█■░█▀█░█░░█➨░
░█▀▀░█▄░█░█░█▄░█▄░
░░░░░░░░░░░░░░░░░░
                
                                                            ";


            Console.WriteLine(bye);
            Console.Read();
        }
        
        private static double Distance(double x1, double x2, double y1, double y2)
        {

            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);

            return result;
        }

    }
}

