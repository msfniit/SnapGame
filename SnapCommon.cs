/*© 2022 Mohammad Saleem
*/

using System.Collections.Generic;

/// <summary>
/// Common classes
/// </summary>
namespace SnapGame
{
   
    public class SnapList
    {
        public string SuiteShape { set; get; }
        public int CardValue { set; get; }

    }

    public class Player
    {
        public string PlayerName { set; get; }
        public List<SnapList> list { set; get; }

    }

}
