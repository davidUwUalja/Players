using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCPlayersLib
{
    public class Orszag
    {
        public int OrszagId { get; init; }
        public string Orszagnev { get; init; }

        public Orszag(int orszagId, string orszagnev)
        {
            OrszagId = orszagId;
            Orszagnev = orszagnev;
        }
    }
}
