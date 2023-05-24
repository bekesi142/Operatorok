using System;
using System.Linq;


StreamReader sr = new StreamReader("kifejezesek.txt");


List<int> szam1_lista = new List<int>();
List<string> jel_lista = new List<string>();
List<int> szam2_lista = new List<int>();


int hanysorvan = 0;

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    hanysorvan++;
    int szam1 = int.Parse(sor.Split(" ")[0]);
    string jel = sor.Split(" ")[1];
    int szam2 = int.Parse(sor.Split(" ")[2]);
    szam1_lista.Add(szam1);
    jel_lista.Add(jel);
    szam2_lista.Add(szam2);
    //string utolso = sor[-1];
}

Console.WriteLine("2. feladat:  " + hanysorvan);
Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {jel_lista.Count(x => x == "mod")}");

bool allitas_szam1;
bool allitas_szam2;
List<int> segedLista_1 = new List<int>();
List<int> segedLista_2 = new List<int>();
foreach (int adat in szam1_lista)
{
    if (adat%10==0)
    {
        allitas_szam1 = true;
        segedLista_1.Add(adat);
    }
    else
    {
        allitas_szam1 = false;
        segedLista_1.Add(1);
    } 
}

foreach (int adat in szam2_lista)
{
    if (adat % 10 == 0)
    {
        allitas_szam2 = true;
        segedLista_2.Add(adat);
    }
    else
    {
        allitas_szam2 = false;
        segedLista_2.Add(1);
    }
}
List<int> indexes_lista_1 = new List<int>();
List<int> indexes_lista_2 = new List<int>();

foreach (int adat in segedLista_1)
{
    if (adat != 1)
    {
        indexes_lista_1.Add(segedLista_1.IndexOf(adat));
    }
}

foreach (int adat in segedLista_2)
{
    if (adat != 1)
    {
        indexes_lista_2.Add(segedLista_2.IndexOf(adat));
    }
}

bool seged = false;
for (int index = 0; index < indexes_lista_1.Count(); index++)
{
    if (indexes_lista_1[index] == indexes_lista_2[index])
    {
        seged = true;
        break;
    }
    else if (indexes_lista_1[index] != indexes_lista_2[index])
    {
        seged = false;
    }
   
}

if (seged == true)
{
    Console.WriteLine("4.feladat: Van ilyen kifejezés!");
}
else if (seged == false)
{
    Console.WriteLine("4.feladat: Nincs ilyen kifejezés!");
}

List<string> jelek = new List<string> { "mod", "/", "div", "-", "*", "+" };

int mod_db = 0;
int osztas_db = 0;
int div_db = 0;
int kivonas_db = 0;
int szorzas_db = 0;
int osszeadas_db = 0;

foreach  (string jel in jel_lista)
{
    switch (jel)
    {
        case "mod":
           mod_db++;
            break;
        case "/":
            osztas_db++;
            break;
        case "div":
            div_db++;
            break;
        case "-":
            kivonas_db++;
            break;
        case "*":
            szorzas_db++;
            break;
        case "+":
            osszeadas_db++;
            break;
    }
}

Console.WriteLine("5. feladat: Statisztika \n" + "\t mod -> " + mod_db + "\n \t / -> " + osztas_db + "\n \t div -> " + div_db + "\n \t - -> " + kivonas_db + "\n \t * -> " + szorzas_db + "\n \t + -> " + osszeadas_db);

















