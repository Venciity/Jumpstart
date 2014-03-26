/*Фермер имал овца, която родила за първи път и агнето било женско. 
 * Всяка следваща година тя раждала по едно женско агне. 
 * Всяко женско агне, когато навършило три години раждало по едно женско агне 
 * и след това продължавало да ражда всяка година по едно женско агне. 
 * Така общият брой на овцете и агнетата през текущата година е 2, 
 * след една година този брой е 3, след две години броят е 4, след 3 години е 6, след 4 години е 9 и т.н. 
 * Напишете програма, която помага на фермера да изчисли, колко агнета и овце ще има след k години, ако всички са живи. 

Вход 
Програмата въвежда от стандартния вход едно цяло положително число k – броя на годините. 
Изход 
Програмата извежда на стандартния изход едно цяло число – общия брой на овцете и агнета. 
Ограничения 3 < k < 113 

Примери:
Вход:4 Изход:9
Вход:5 Изход:13
Вход:6 Изход:19
Вход:7 Изход:28
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SheepsAndLambs
{
    class SheepsAndLambs
    {
        static void Main(string[] args)
        {
            int k;
            do
            {
                Console.Write("k = ");
                k = Int32.Parse(Console.ReadLine());
            } while (k < 4 || k > 112); // ако k < 4 или k > 122 повтаряме цикъла 

            int year = 0;
            long lambsNewBorn = 1;
            long lambs1YearOld = 0;
            long lambs2YearsOld = 0;
            long sheeps = 1;

            while (year < k)
            {
                sheeps += lambs2YearsOld;
                lambs2YearsOld = lambs1YearOld;
                lambs1YearOld = lambsNewBorn;
                lambsNewBorn = sheeps;
                year++;
            }

            long total = sheeps + lambs2YearsOld + lambs1YearOld + lambsNewBorn;
            Console.WriteLine("Total sheeps and lambs = {0}", total);
        }
    }
}
