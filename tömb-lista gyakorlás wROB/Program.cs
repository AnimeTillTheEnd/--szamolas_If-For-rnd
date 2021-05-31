using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb_lista_gyakorlás_wROB
{
    class Program
    {
        static void Main(string[] args)
        {

            //Írjunk oktatóprogramot, amely az összeadást és a kivonást gyakoroltatja!Az egész számokat
            //véletlenszerűen állítsuk elő! A felhasználó csak - 5 és + 15 között képes a műveleteket
            //elvégezni.Adjunk 10 feladatot, és a felhasználó minden helyes megoldása 1 pontot érjen!
            //Osztályozzuk le a feladatsort, és az osztályzatot írjuk ki a képernyőre úgy, hogy 0 - 2 - ig
            //elégtelen, 3 - 4 - ig elégséges, 5 - 6 - ig közepes, 7 - 8 - ig jó, e fölött pedig jeles legyen!
            Console.WriteLine("Ebben a feladatban Ön 10 feladaton keresztül kivonni és összeadni fog!");
            Random rnd = new Random();
            int pontok = 0;
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(-5, 16);
                int b = rnd.Next(-5, 16);
                Console.WriteLine("Első szám: " + a + " második szám: " + b + ", vonja ki az elsőből a másodikat!");
                int c = int.Parse(Console.ReadLine());
                if (c == a - b)
                {
                    pontok += 1;
                    Console.WriteLine("Helyes, +1pont!");
                };
            }
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(-5, 16);
                int b = rnd.Next(-5, 16);
                Console.WriteLine("Első szám: " + a + " második szám: " + b + ", adja hozzá az elsőből a másodikat!");
                int c = int.Parse(Console.ReadLine());
                if (c == a + b)
                {
                    pontok += 1;
                    Console.WriteLine("Helyes, +1pont!");
                };
            }


            Console.WriteLine("Össz pontszámaid: " + pontok + "pontok");
            if (pontok >= 0 && pontok <= 2)
            {
                Console.WriteLine("Elégtelen az elért eredmény!");
            };
            if (pontok >= 3 && pontok <= 4)
            {
                Console.WriteLine("Elégséges az elért eredmény!");
            }
            if (pontok >= 5 && pontok<=6)
            {
                Console.WriteLine("Közepes az elért eredmény!");
            }
            if (pontok >= 7 && pontok <= 8)
            {
                Console.WriteLine("Jó az elért eredmény!");
            }
            if (pontok >=8 && pontok <=10)
            {
                Console.WriteLine("Jeles az elért eredmény!");
            }










            Console.ReadKey();

        }
    }
}
