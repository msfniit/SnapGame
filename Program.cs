/* Design this snap game for two players as of now.
 *  We can generalize this with more players.
 * 
 *
*© 2022 Mohammad Saleem
*/

using System;
using System.Collections.Generic;


namespace SnapGame
{
    class Program
    {
        static int caseType = 0;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many packs to use?");
                int packs = Convert.ToInt32(Console.ReadLine());
                if (packs != 2)
                {
                    Console.WriteLine("Wrong Input ! Only two players can play");
                    return;
                }

                Console.WriteLine("Which of the three matching conditions to use?");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Press 1 for matching condition can be the face value of the card");
                Console.WriteLine("Press 2 matching condition can be the suite value of the card");
                Console.WriteLine("Press 3 matching condition can be the face and suite value of the card");
                caseType = Convert.ToInt32(Console.ReadLine());

                SnapGameStart game = new SnapGameStart();

                // Create snap cards list
                List<SnapList> snapList = game.CreateSnapCardList();

                // Randomize the List
                snapList.Shuffle();

                // Distribute cards to the palyers
                List<Player> players = game.DistributeCards(packs, snapList);

                // Play the game and declare the winner..
                game.Play(players, caseType);

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
            Console.ReadLine();

        }

    }





}
