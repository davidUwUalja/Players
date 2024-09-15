using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCPlayersLib
{
    public class JatekosAdat
    {
        public int JatekosId { get; init; }
        public int Pace { get; init; }
        public int Shooting { get; init; }
        public int Passing { get; init; }
        public int Dribbling { get; init; }
        public int Defending { get; init; }
        public int Physical { get; init; }

        public JatekosAdat(int jatekosId, int pace, int shooting, int passing, int dribbling, int defending, int physical)
        {
            JatekosId = jatekosId;
            Pace = pace;
            Shooting = shooting;
            Passing = passing;
            Dribbling = dribbling;
            Defending = defending;
            Physical = physical;
        }

        public int Atlagertekeles => (Pace + Shooting + Passing + Dribbling + Defending + Physical) / 6;

    }
}
