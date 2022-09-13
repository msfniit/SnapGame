/*© 2022 Mohammad Saleem
*/
using System;
using System.Collections.Generic;

namespace SnapGame
{
    /// <summary>
    /// Extention method for randamizing the list of cards 
    /// </summary>
   public static class RandomShuffle
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
