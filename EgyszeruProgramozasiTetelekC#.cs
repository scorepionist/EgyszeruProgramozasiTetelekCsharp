using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
1. Határozza meg a tömb elemeinek összegét!
(sorozatszámítás tétel)
2. Szerepel-e a tömbben öttel osztható szám?
(eldöntés tétel)
3. Ha tudjuk, hogy szerepel a tömbben öttel osztható szám,
akkor mi az indexe?
(kiválasztás tétel)
4. Szerepel-e a tömbben öttel osztható szám, és ha igen,
akkor mi az indexe? (A metódus visszatérési értéke -1
legyen, ha nincs öttel osztható szám, egyébként pedig a
megfelelő elem indexe.)
(lineáris keresés tétel)
5. Hány darab öttel osztható szám van a tömbben?
(megszámlálás tétel)
6. Határozza meg a tömb legkisebb értékének indexét!
(maximumkiválasztás tétel)
*/

namespace EgyszeruProgramozasiTetelekCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int tombHossza = 20; 
            int[] tomb = FeltoltTomb(tombHossza); 

            Console.Write("A tömb elemei:" + string.Join(" , " , tomb)) ;  
            Console.WriteLine("");

            int osszeg = SorozatSzamitas(tomb, tombHossza); 
            Console.WriteLine("A tömb elemeinek összege: " + osszeg);  

            bool vanEBenneOttelOszthato = EldontesOttelOszthato(tomb, tombHossza); 
            Console.WriteLine( (vanEBenneOttelOszthato) ? "Igaz" : "Hamis");

            int index = KivalasztasOttelOszthatoIndexe(tomb, tombHossza);  
            Console.WriteLine("A tömbben öttel osztható elem indexe: {0}", index);

            int ottelOszthatoDB = MegszamlalasOttelOszthatokSzama(tomb, tombHossza);  
            Console.WriteLine("Öttel oszthatók száma: " + ottelOszthatoDB);

            int mini = MaxMinKivalasztas(tomb, tombHossza);  
            Console.WriteLine("Legkisebb elem: {0}", mini);
        }

        public static int[] FeltoltTomb(int tombHossz)  //tömb feltöltés
        {
            Random rnd = new Random();

            int[] tomb = new int[tombHossz];

            for (int i = 0; i < tombHossz; i++)
            {
                tomb[i] = rnd.Next(1, 100);
            }

            return tomb;
        }

        public static int SorozatSzamitas(int[] tomb, int n)  //sorozatszámítás tétel
        {
            int osszeg = 0;

            for (int i = 0; i < n; i++)
            {
                osszeg += tomb[i];
            }

            return osszeg;
        }

        public static bool EldontesOttelOszthato(int[] tomb, int n)  //eldöntés tétel
        {
            int i = 0;

            while (i <= n && !(tomb[i] % 5 == 0))
            {
                i++;
            }
            
         return i <= n;
        
        
        
              
        }

        public static int KivalasztasOttelOszthatoIndexe(int[] tomb, int n)  //kiválasztás tétel
        {
            int i = 0;

            int index = 0;

            while (i <= n)
            {
                if (tomb[i] % 5 == 0)
                {
                    index = i;
                    break;
                }

                i++;
            }

            return index;
        }

        public static int MegszamlalasOttelOszthatokSzama(int[] tomb, int n) //megszámlálás tétel
        {
            int ottelOszthatoDB = 0;

            for (int i = 0; i < n; i++)
            {
                if (tomb[i] % 5 == 0)
                {
                    ottelOszthatoDB = ottelOszthatoDB + 1;
                }
            }

            return ottelOszthatoDB;
        }

        public static int MaxMinKivalasztas(int[] tomb, int n) //maximumkiválasztás tétel
        {
            int mini = tomb[0];

            for (int i = 1; i < n; i++)
            {
                if (tomb[i] < mini)
                {
                    mini = tomb[i];
                }
            }

            return mini;
        }
    }
}