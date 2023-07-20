using DungeonLibrary;
using System.Threading;

namespace DungeonApp
{
    internal class DungeonIndex
    {
        static void Main(string[] args)
        {


            #region Introduction
            Console.WriteLine("Hello, Hello..... are you awa?!?");
            Console.WriteLine("Hello, hello? Are you awake? Can you hear the alarm? You seem to have been awaken from the cryo-sleep ahead of schedule. As you look around you see a large room filled with many Cryo-sleep chambers in varius conditions.  Yours has been opened, but seems otherwise undamaged.  As you stumble through the door from the room full of cryo chambers, you enter what appears to be a maintenance room for the chambers.  You try to remember where you are and who you are.   ");
            #endregion

            #region Player Creation
            //Prompt the user to input their name: 
            Console.WriteLine("Can you remember what your name is?");

            //Store the user input in a string.
            string playerName = Console.ReadLine();

            Console.WriteLine("As you look around the maintenance room you see a variety of tools that you could use to try and defend yourself while you figure out what happened.");

            /*BONUS: Customizing the weapons.
             * 
             * 1) Construct custom weapon objects.
             * 2) Prompt user input.
             * 3) Surround customization in a menu of its own.
             * 4) Assign EquippedWeapon property based on user input.
             */
            
            //1) Construct the weapon objects:
            Weapon sword1 = new Weapon("Chainsaw", 5, 40, 30, true, WeaponType.Sword);
            Weapon bow1 = new Weapon("Nail Gun", 20, 30, 20, false,  WeaponType.Bow);
            Weapon axe1 = new Weapon("Fireman's Axe", 15, 60, 50, true,  WeaponType.Axe);
            Weapon torch1 = new Weapon("Welding Torch", 20, 50, 35, false,  WeaponType.Torch);
            Weapon club1 = new Weapon( "Crowbar", 25, 30, 20, false, WeaponType.Club);

            //3a) COUNTER
            bool playerIsChoosingWeapon = true;

            Weapon chosenWeapon;//Weapon object to store user choice.
            
            Player player = new Player(playerName, 70, 5, 100, 100, Race.Human, sword1);

            do
            {
                //2a) Prompt user input
                Console.WriteLine("\nChoose your weapon:\n" +
                    "(S) Chainsaw\n" +
                    "(L) Nail Gun\n" +
                    "(A) Fireman's Axe\n" +
                    "(T) Welding Torch\n" +
                    "(C) Crowbar\n");
                //Input prompt is a key instead of a line.
                //That way the user just has to press the key
                //instead of typing out a line and pressing enter.
                ConsoleKey userKey = Console.ReadKey().Key;
                Console.Clear();//2b)Clear the console after registering input.

                switch (userKey)//Read user input
                {
                    case ConsoleKey.S://Values are the enumerated values of ConsoleKey
                        playerIsChoosingWeapon = false;//3c) UPDATE
                        player.EquippedWeapon = sword1;//4a)Assign to sword object.
                        break;

                    case ConsoleKey.L:
                        playerIsChoosingWeapon = false;//3c) UPDATE
                        player.EquippedWeapon = bow1;//4b)Assign to bow object.
                        break;

                    case ConsoleKey.A:
                        playerIsChoosingWeapon = false;//3c) UPDATE
                        player.EquippedWeapon = axe1;//4c)Assign to axe object.
                        break;

                    case ConsoleKey.T:
                        playerIsChoosingWeapon = false;//3c) UPDATE
                        player.EquippedWeapon = torch1;//4c)Assign to torch object.
                        break;

                    case ConsoleKey.C:
                        playerIsChoosingWeapon = false;//3c) UPDATE
                        player.EquippedWeapon = club1;//4c)Assign to club object.
                        break;

                    default://If they did not press one of the keys we prompted them to, reload loop
                        Console.WriteLine("Input was invalid. Please press (S), (L), (A), (T), or (C).");
                        break;
                }

            } while (playerIsChoosingWeapon);//3b) CONDITION

            /*BONUS: Customizing the players race.
             * 1) Prompt user input
             * 2) Surround in a loop
             * 3) Assign the Race property based on player's choice.              
             */

            Console.Clear();//Clear text from weapon customization

            //2a) COUNTER
            bool playerIsChoosingRace = true;
            do
            {
                //1)Prompt user input
                Console.WriteLine("Having the security of a weapon to defend yourself now, you begin to calm a bit.  More memories begin to come back, feeling the tool back in your hands reminds you that you are the mechanic for this ship and eventually the colony on Mars");
                Console.WriteLine("\nOut in space there are many races on many planets. Can you remember what your race is? " +
                    "\n(H) Human" +
                    "\n(M) Mustafarian" +
                    "\n(N) Nautolan" +
                    "\n(W) Wookie" +
                    "\n(Z) Zabrak" +
                    "\n(C) Cyborg");

                //Store key input
                ConsoleKey raceChoice = Console.ReadKey().Key;                
                Console.Clear();//Clear the input from the console.

                switch (raceChoice)
                {
                    case ConsoleKey.H:
                        player.PlayerRace = Race.Human;//3) Assign based on player input
                        playerIsChoosingRace = false;//2c) UPDATE
                        break;

                    case ConsoleKey.M:
                        player.PlayerRace = Race.Mustafarian;//3) Assign based on player input
                        player.MaxLife = 180;//Custom properties based on race
                        player.Life = 180;//Custom properties based on race
                        player.HitChance = 55;
                        player.Block = 15;
                        playerIsChoosingRace = false;
                        break;

                    case ConsoleKey.N:
                        player.PlayerRace = Race.Nautolan;//3) Assign based on player input
                        player.MaxLife = 125;//Custom properties based on race
                        player.Life = 125;//Custom properties based on race
                        player.Block = 35;//Custom properties based on race
                        playerIsChoosingRace = false;//2c) UPDATE
                        break;

                    case ConsoleKey.W:
                        player.PlayerRace = Race.Wookie;//3) Assign based on player input
                        player.MaxLife = 200;//Custom properties based on race
                        player.Life = 200;//Custom properties based on race
                        player.HitChance = 85;
                        playerIsChoosingRace = false;
                        break;

                    case ConsoleKey.Z:
                        player.PlayerRace = Race.Zabrak;//3) Assign based on player input
                        player.MaxLife = 150;//Custom properties based on race
                        player.Life = 150;//Custom properties based on race
                        player.HitChance = 75;
                        player.Block = 20;
                        playerIsChoosingRace = false;
                        break;

                    case ConsoleKey.C:
                        player.PlayerRace = Race.Cyborg;//3) Assign based on player input
                        player.MaxLife = 160;//Custom properties based on race
                        player.Life = 160;//Custom properties based on race
                        player.HitChance = 65;
                        player.Block = 25;
                        playerIsChoosingRace = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please press (H), (M), (N), (W) , (Z) or (C).");
                        break;
                }


            } while (playerIsChoosingRace);//2b) CONDITION


            player.Score = 0;
            #endregion


            //Outer Loop
            bool quit = false;
            do
            {
                #region Monster and Room Generation
                //We need to generate a new monster and a new room for each encounter.

                //TODONE Generate a room - ramdom string description
                Console.WriteLine(GetRoom());
                //Generate a Monster (custom datatype) 
                Monster monster = Monster.GetMonster();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nIn this room is a " + monster.Name);
                Console.ResetColor();
                #endregion

                #region Encounter Loop
                //This runs until either the monster dies or the player quits, dies, or runs away.
                bool reload = false;//set to true to "reload" the monster & the room 
                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "1) Attack\n" +
                        "2) Run away\n" +
                        "3) Player Info\n" +
                        "4) Monster Info\n" +
                        "5) Exit\n");

                    char action = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    switch (action)
                    {
                        case '1':
                            Console.WriteLine("Attack!");
                            reload = Combat.DoBattle(player, monster);
                            break;
                        case '2':
                            Console.WriteLine("Run Away!!");
                            //TODO Give the monster a free attack chance
                            Combat.DoAttack(monster, player);
                            //Leave the inner loop (reload the room) and get a new room & monster.
                            reload = true;
                            break;
                        case '3':
                            Console.WriteLine("Player info: ");
                            //TODO print player details to the screen
                            Console.WriteLine(player);
                            break;

                        case '4':
                            Console.WriteLine("Monster info: ");
                            //TODO print monster details to the screen
                            Console.WriteLine(monster);
                            break;

                        case '5':
                            //quit the whole game. "reload = true;" gives us a new room and monster, "quit = true" quits the game, leaving both the inner AND outer loops.
                            Console.WriteLine("No one likes a quitter!");
                            quit = true;
                            break;

                        default:
                            Console.WriteLine("Do you think this is a game?? Quit playing around!");
                            break;
                    }//end switch
                    #endregion
                    //TODO Check Player Life. If they are dead, quit the game and show them their score.
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude... You died!\a");
                        quit = true;//leave both loops.
                    }

                } while (!reload && !quit);//While reload and quit are both FALSE (!true), keep looping.
                                           //If either becomes true, leave the inner loop.
                #endregion


            } while (!quit);//While quit is NOT true, keep looping.

            #region Exit
            Console.WriteLine("You defeated " + player.Score +
           " monster" + (player.Score == 1 ? "." : "s."));
            #endregion

        }//end main()
        private static string GetRoom()
        {
            //Requirements:
            /*
             *  1. Create a collection of room descriptions.
             *  2. Randomly print one of those room descriptions to the Console.
             */


            string[] roomDescriptions =
            {
                 "You have found what appears to be one of the ship's barracks",
                 "Some may call it a torture chamber, others just call it the Gym",
                 "This room seems to ba another of the many storage rooms on the ship",
                 "Even though it probably should be locked you have founs you way into the armoury",
                 "The smell of the medical cleaners and the bright lights means this must be the Infirmary",
                 "Every ship in the galaxy has one, but they may not smell as bad as this mess hall",
                 "To big to be cockpit, but to small to be considered the bridge, this is where the ship was being piloted from",
                 "The volume of noise and the smell of fuel means this must be the egine room",
                 "Though not much bigger than a closet, this is one of several electrical junction rooms",
                 "No one wants to end up in the ship's brig, or jail",
                 "They come in many shapes and sizes, but for a bathroom this one is rather nice and roomy",
                 "Different tools and equipment, same idea, you found another storage room",

                };

            Random roomPick = new Random();
            int room = roomPick.Next(roomDescriptions.Length);
            string roomDescripts = roomDescriptions[room];
            return roomDescripts;
            
           
        }//end GetRoom()

    }//end class
}//end namespace