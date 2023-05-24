using System;
using System.Linq;


    List<string> lista = new List<string>();
    File.ReadAllLines("kifejezesek.txt").ToList();
    
    string[] felbontottSor = sor.Split(" ");
    int szam1 = int.Parse(felbontottSor[0]);
    string jel = felbontottSor [1];
    int szam2 = int.Parse(felbontottSor [2]);
    


