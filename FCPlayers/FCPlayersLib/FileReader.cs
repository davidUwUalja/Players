using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCPlayersLib
{
    public class FileReader
    {
        public static List<Orszag> OlvassOrszagok(string fajlNev)
        {
            var orszagok = new List<Orszag>();
            var sorok = File.ReadAllLines(fajlNev).Skip(1); // Első sor kihagyása

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                var orszag = new Orszag(int.Parse(adatok[0]), adatok[1]);
                orszagok.Add(orszag);
            }

            return orszagok;
        }

        public static List<Jatekos> OlvassJatekosok(string fajlNev, List<Orszag> orszagok)
        {
            var jatekosok = new List<Jatekos>();
            var sorok = File.ReadAllLines(fajlNev).Skip(1); // Első sor kihagyása

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                var orszag = orszagok.First(o => o.OrszagId == int.Parse(adatok[2]));
                var jatekos = new Jatekos(int.Parse(adatok[0]), adatok[1], orszag, adatok[3], adatok[4]);
                jatekosok.Add(jatekos);
            }

            return jatekosok;
        }

        public static List<JatekosAdat> OlvassJatekosAdatokat(string fajlNev)
        {
            var jatekosAdatok = new List<JatekosAdat>();
            var sorok = File.ReadAllLines(fajlNev).Skip(1); // Első sor kihagyása

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                var jatekosAdat = new JatekosAdat(
                    int.Parse(adatok[0]),
                    int.Parse(adatok[1]),
                    int.Parse(adatok[2]),
                    int.Parse(adatok[3]),
                    int.Parse(adatok[4]),
                    int.Parse(adatok[5]),
                    int.Parse(adatok[6])
                );
                jatekosAdatok.Add(jatekosAdat);
            }

            return jatekosAdatok;
        }
    }
}
