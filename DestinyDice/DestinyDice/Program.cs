using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20'ye kadar sayi olan bir d&d zarımız var
            // 15-20 arası gelirse büyük zarar 
            // 10-15 arası gelirse orta boyutta zarar
            // 5-10 arası gelirse zarar yok nötr
            // 0-5 arası gelirse kendimize zarar


            //Bunu yapmak için Random classı kullanılır. statik değil bu class, bunu kullanmak için:

            Random dice = new Random();

            dice.Next(1, 21); // belirli aralıkta sayı döndürür (min, max)

            //arka arkaya 5 zar attık diyelim:
            int firstRoll = dice.Next(1, 21);
            int secondRoll = dice.Next(1, 21);
            int thirdRoll = dice.Next(1, 21);
            int fourthRoll = dice.Next(1, 21);
            int fifthRoll = dice.Next(1, 21);

            //ilk 3 atış ortalamasını alıp karar verelim:
            float mean = (firstRoll + secondRoll + thirdRoll) / 3f;

            if (mean > 15)
            {
                Console.WriteLine("Big Damage");
            }
            if (mean > 10 && mean <= 15) //iki olasılık karşılaştırmak istiyorsak ayrı ayrı yazmamız gerek
            {
                Console.WriteLine("Damage");
            }
            if(mean > 5 && mean <= 10)
            {
                Console.WriteLine("No Damage");
            }
            if(mean <= 5)
            {
                Console.WriteLine("Self Damage");
            }

            // 4. ve 5. zar 18 üstünde gelirse ek zarar verilecek

            if (fourthRoll >= 18 || fifthRoll >= 18)
            {
                Console.WriteLine("Extra Damage");
            }

            Console.WriteLine(firstRoll + " " + secondRoll + " " + thirdRoll + " " + fourthRoll + " " + fifthRoll);
            Console.ReadLine();

        }
    }
}
