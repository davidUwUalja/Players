using FCPlayersLib;

var orszagok = FileReader.OlvassOrszagok("orszag.csv");
var jatekosok = FileReader.OlvassJatekosok("jatekosok.csv", orszagok);
var jatekosAdatok = FileReader.OlvassJatekosAdatokat("jatekosadatok.csv");

// 5. feladat: Bal lábas játékosok száma
Console.WriteLine("5. feladat:");
var balLabasJatekosokSzama = jatekosok.Count(j => j.Lab == "Bal");
Console.WriteLine($"Bal lábas játékosok száma: {balLabasJatekosokSzama}");

// 6. feladat: Játékos adatai keresés név alapján
Console.WriteLine("6. feladat:");
Console.Write("Adja meg a játékos nevét: ");
var keresettNev = Console.ReadLine();
var jatekos = jatekosok.FirstOrDefault(j => j.Nev == keresettNev);

if (jatekos != null)
{
    var atlagosErtekeles = jatekosAdatok
        .Where(ja => ja.JatekosId == jatekos.JatekosId)
        .Select(ja => ja.Atlagertekeles)
        .FirstOrDefault();

    Console.WriteLine($"Név: {jatekos.Nev}, Pozíció: {jatekos.Pozicio}, Ország: {jatekos.Orszag.Orszagnev}, Átlagos értékelés: {atlagosErtekeles}");
}
else
{
    Console.WriteLine("Ilyen néven nem található játékos.");
}

// 7. feladat: Legjobb 4 játékos átlagos értékelés szerint
Console.WriteLine("7. feladat:");
var top4Jatekos = jatekosAdatok
    .GroupBy(ja => ja.JatekosId)
    .Select(g => new
    {
        Jatekos = jatekosok.First(j => j.JatekosId == g.Key),
        Atlagertekeles = g.Average(ja => ja.Atlagertekeles)
    })
    .OrderByDescending(x => x.Atlagertekeles)
    .Take(4);

foreach (var j in top4Jatekos)
{
    Console.WriteLine($"{j.Jatekos.Nev} - Átlagos értékelés: {j.Atlagertekeles}");
}