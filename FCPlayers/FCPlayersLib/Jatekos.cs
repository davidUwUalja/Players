namespace FCPlayersLib
{
    public class Jatekos
    {
        public int JatekosId { get; init; }
        public string Nev { get; init; }
        public Orszag Orszag { get; init; }
        public string Pozicio { get; init; }
        public string Lab { get; init; }

        public Jatekos(int jatekosId, string nev, Orszag orszag, string pozicio, string lab)
        {
            JatekosId = jatekosId;
            Nev = nev;
            Orszag = orszag;
            Pozicio = pozicio;
            Lab = lab;
        }
    }
}
