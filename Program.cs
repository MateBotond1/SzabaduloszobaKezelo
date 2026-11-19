using SzabaduloszobaKezelo;
List<Jatek> Adatok=new List<Jatek>();
foreach(string sor in File.ReadAllLines("foglalasok.txt").Skip(1))
{
    Adatok.Add(new Jatek(sor));
}
