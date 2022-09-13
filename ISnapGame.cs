/*© 2022 Mohammad Saleem
*/

using System.Collections.Generic;

namespace SnapGame
{
    /// <summary>
    /// Mention All the functions for playing the game. 
    /// </summary>
    interface ISnapGame
    {
        void Play(List<Player> list, int caseType);
        List<Player> DistributeCards(int packs, List<SnapList> list);
        List<SnapList> CreateSnapCardList();
        void CallSnapCase1(List<Player> list);
        void CallSnapCase2(List<Player> list);

        void CallSnapCase3(List<Player> list);




    }
}
