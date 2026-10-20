using IngatlanApp;
using System.ComponentModel;

List<Ingatlan> forras = new List<Ingatlan>();
int hibaSorokSzama = 0;

foreach (var adatok in File.ReadAllLines("ingatlanok.txt").Skip(1)){
    if (string.IsNullOrEmpty(adatok))
    {
        hibaSorokSzama++;
        continue;
    }
    string[] sor = adatok.Split('|');

    if(sor.Length != 4 ){
        hibaSorokSzama++;
        continue;
    }

    if ((sor[0] != "I" && sor[0] != "L") || string.IsNullOrEmpty(sor[1])){
        hibaSorokSzama++;
        continue;
    }
    if (!int.TryParse(sor[2], out int emelet))
    {
        hibaSorokSzama++;
        continue;
    }
    if (sor[0] == "I")
    {
        forras.Add(new Ingatlan(sor[0], emelet));
    }
    string extra = sor[3].Trim();
    if (sor[0] == "L")
    {
        forras.Add(new Lakas(sor[1], emelet,));
    }



}