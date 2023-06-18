namespace DungeonApp
{
    internal class DungeonIndex
    {
        static void Main(string[] args)
        {


            #region Introduction
            Console.WriteLine("Hello, Hello..... are you awa?!?");
            //TODO Intro
            #endregion

            #region Player Creation
            //TODO Player Creation, after we've learned how to create custom Datatypes.
            #endregion


            //Outer Loop
            bool quit = false;
            do
            {
                #region Monster and Room Generation
                //We need to generate a new monster and a new room for each encounter.

                //TODONE Generate a room - ramdom string description
                Console.WriteLine(GetRoom());
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
                            //TODO Combat functionality
                            break;
                        case '2':
                            Console.WriteLine("Run Away!!");
                            //TODO Give the monster a free attack chance

                            //Leave the inner loop (reload the room) and get a new room & monster.
                            reload = true;
                            break;
                        case '3':
                            Console.WriteLine("Player info: ");
                            //TODO print player details to the screen
                            break;

                        case '4':
                            Console.WriteLine("Monster info: ");
                            //TODO print monster details to the screen
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

                } while (!reload && !quit);//While reload and quit are both FALSE (!true), keep looping.
                                           //If either becomes true, leave the inner loop.
                #endregion


            } while (!quit);//While quit is NOT true, keep looping.

            #region Exit
                //TODO output the final score
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
            

            //Refactor: return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom()

    }//end class
}//end namespace