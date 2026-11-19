using SzabaduloszobaKezelo;
List<Jatek> Adatok=new List<Jatek>();
foreach(string sor in File.ReadAllLines("foglalasok.txt").Skip(1))
{
    Adatok.Add(new Jatek(sor));
}
Console.WriteLine("Rögzített szabadulószoba játékok:");
foreach (Jatek aktualis in Adatok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Szabadulószoba teljes bevétele: {Adatok.Sum(x => x.FizetendoOsszeg())} Ft");
Console.WriteLine($"Összes játékos létszáma: {Adatok.Sum(x => x.JatekosokSzama)} fő");
Console.WriteLine($"Átlagos kijutási idő: {((Adatok.Sum(x => x.IdotartamPerc)) / Adatok.Count):F0} perc");
Jatek legjobb = Adatok.MaxBy(x => x.FizetendoOsszeg());
Console.WriteLine($"Legtöbbet fizető csapat: {legjobb.CsapatNev} ({legjobb.FizetendoOsszeg()} Ft)");
