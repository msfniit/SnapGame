/*© 2022 Mohammad Saleem
*/

using System;
using System.Collections.Generic;

namespace SnapGame
{
    /// <summary>
    /// Implement all the required functions.
    /// </summary>
    class SnapGameStart : ISnapGame
    {
        public List<Player> DistributeCards(int packs, List<SnapList> list)
        {
            List<Player> players = new List<Player>();
            // added playes
            for (int i = 0; i < packs; i++)
            {
                Player pl = new Player();
                players.Add(new Player() { PlayerName = "Player_" + i });

            }

            int playerCounter = 0;
            // distribute cards
            for (int i = 0; i < list.Count; i++)
            {
                if (players[playerCounter].list == null)
                    players[playerCounter].list = new List<SnapList>();
                players[playerCounter].list.Add(new SnapList()
                { CardValue = list[i].CardValue, SuiteShape = list[i].SuiteShape });
                playerCounter++;
                if ((i + 1) % players.Count == 0) playerCounter = 0;
            }

            return players;

        }

        public void Play(List<Player> list, int caseType)
        {
            switch (caseType)
            {
                case 1:
                    {
                        CallSnapCase1(list);

                        break;
                    }
                case 2:
                    {
                        CallSnapCase2(list);
                        break;
                    }
                case 3:
                    {
                        CallSnapCase3(list);
                        break;
                    }

            }
        }

        public List<SnapList> CreateSnapCardList()
        {
            List<SnapList> snapList = new List<SnapList>();
            string[] cardsShape = new string[] { "SPADES", "HEARTS", "DIAMONDS", "CLUBS" };

            int[] cardsValue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 0; i < cardsShape.Length; i++)
            {
                string shape = cardsShape[i];
                for (int j = 0; j < cardsValue.Length; j++)
                {
                    int value = cardsValue[j];
                    snapList.Add(new SnapList() { SuiteShape = shape, CardValue = value });
                }

            }
            return snapList;
        }

        /// <summary>
        /// Case 1 
        /// </summary>
        /// <param name="list"></param>
        public void CallSnapCase1(List<Player> list)
        {
            List<SnapList> playList = new List<SnapList>();

            while (list[0].list.Count > 0 && list[1].list.Count > 0)
            {
                // Add into the play list
                playList.Add(list[0].list[0]);

                // Remove item from player 1
                list[0].list.RemoveAt(0);

                // Check Snap..
                if (playList.Count >= 2 && playList[playList.Count - 1].CardValue == playList[playList.Count - 2].CardValue)
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 2);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();
                }

                // Add into the play list
                playList.Add(list[1].list[0]);

                // Remove item from player 2
                list[1].list.RemoveAt(0);

                // Check Snap..
                if ((playList.Count >= 2) && (playList[playList.Count - 1].CardValue == playList[playList.Count - 2].CardValue))
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 2);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();

                }

            }

            if (list[0].list.Count > 0)
            {
                Console.WriteLine("Player 1 has won with " + list[0].list.Count + " Cards. Congrats!");
            }
            else if (list[1].list.Count > 0)
            {
                Console.WriteLine("Player 2 has won with " + list[1].list.Count + " Cards. Congrats!");
            }
            else
                Console.WriteLine("No one has won the game");

        }

        /// <summary>
        /// Case 2
        /// </summary>
        /// <param name="list"></param>
        public void CallSnapCase2(List<Player> list)
        {
            List<SnapList> playList = new List<SnapList>();

            while (list[0].list.Count > 0 && list[1].list.Count > 0)
            {
                // Add into the play list
                playList.Add(list[0].list[0]);

                // Remove item from player 1
                list[0].list.RemoveAt(0);

                // Check Snap..
                if (playList.Count >= 2 && playList[playList.Count - 1].SuiteShape == playList[playList.Count - 2].SuiteShape)
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 1);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();
                }

                // Add into the play list
                playList.Add(list[1].list[0]);

                // Remove item from player 2
                list[1].list.RemoveAt(0);

                // Check Snap..
                if ((playList.Count >= 2) && (playList[playList.Count - 1].SuiteShape == playList[playList.Count - 2].SuiteShape))
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 1);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();

                }

            }

            if (list[0].list.Count > 0)
            {
                Console.WriteLine("Player 1 has won with " + list[0].list.Count + " Cards. Congrats!");
            }
            else if (list[1].list.Count > 0)
            {
                Console.WriteLine("Player 2 has won with " + list[1].list.Count + " Cards. Congrats!");
            }
            else
                Console.WriteLine("No one has won the game");

        }

        /// <summary>
        /// Case 3
        /// </summary>
        /// <param name="list"></param>
        public void CallSnapCase3(List<Player> list)
        {
            List<SnapList> playList = new List<SnapList>();

            while (list[0].list.Count > 0 && list[1].list.Count > 0)
            {
                // Add into the play list
                playList.Add(list[0].list[0]);

                // Remove item from player 1
                list[0].list.RemoveAt(0);

                // Check Snap..
                if (playList.Count >= 2 && (playList[playList.Count - 1].SuiteShape == playList[playList.Count - 2].SuiteShape) &&
                    (playList[playList.Count - 1].CardValue == playList[playList.Count - 2].CardValue))
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 1);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();
                }

                // Add into the play list
                playList.Add(list[1].list[0]);

                // Remove item from player 2
                list[1].list.RemoveAt(0);

                // Check Snap..
                if ((playList.Count >= 2) && (playList[playList.Count - 1].SuiteShape == playList[playList.Count - 2].SuiteShape) &&
                    (playList[playList.Count - 1].CardValue == playList[playList.Count - 2].CardValue))
                {
                    var random = new Random();
                    int randomPlayer = random.Next(0, 1);
                    list[randomPlayer].list.AddRange(playList);
                    playList.Clear();

                }

            }

            if (list[0].list.Count > 0)
            {
                Console.WriteLine("Player 1 has won with " + list[0].list.Count + " Cards. Congrats!");
            }
            else if (list[1].list.Count > 0)
            {
                Console.WriteLine("Player 2 has won with " + list[1].list.Count + " Cards. Congrats!");
            }
            else
                Console.WriteLine("No one has won the game");

        }
       
    }
}
