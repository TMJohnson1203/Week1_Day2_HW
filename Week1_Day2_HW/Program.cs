using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            // Mike and his 3 friends each paid $13 for their part of the bill
            // $13 is the dividend of total sum divided by 4
            // need to display "bill total = 4 * 13"
            
            int indivTotal = 13;
            int totalPpl = 4;

            Console.WriteLine(indivTotal * totalPpl);

            // needs 7 cups
            // 2 cups already exist
            // need to display "how many more cups she needs if 2 already exist"
            // need to subtract existing (2) from total needed (7)

            int cupsNeed = 7;
            int cupsExist = 2;

            Console.WriteLine(cupsNeed - cupsExist);

            // you have $40
            // diapers are $8 a box
            // need to display "number of boxes you can buy with $40")
            // need to divide 40 by 8 = 40/8

            int totalHave = 40;
            int boxCost = 8;

            Console.WriteLine(totalHave / boxCost);

            // had $29
            // now has $41
            // how much MORE does he have now?
            // $41 - $29

            int hasNow = 41;
            int hadThen = 29;

            Console.WriteLine(hasNow - hadThen);

            // Julia ran 47 miles
            // Julia ran 30 more miles than Pranav
            // how many miles did Pranav run?

            int juliaRan = 47;
            int juliaExcess = 30;

            Console.WriteLine(juliaRan - juliaExcess);

            // envelopes cost $3
            // you have $12
            // how many boxes can you buy?
            // 12/ 3

            int moneyHave = 12;
            int envelCost = 3;

            Console.WriteLine(moneyHave / envelCost);

            //After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            // has 27.10 now
            // spent 5.12 before
            // how much did he have before he spent any $?
            // 27.10 + 5.12 

            float nowHas = 27.10f;
            float hadBefore = 5.12f;

            Console.WriteLine(nowHas + hadBefore);

            //331 students went on a field trip. Six buses were filled and 7 students traveled in cars. How many students were in each bus?
            // 331 students total
            // 7 traveled by car; the remainder traveled by bus
            // there were 6 busses
            // how many students were on each bus?
            // (331 - 7) / 6 = 

            int totStudents = 331;
            int carRiders = 7;
            int numofbus = 6;

            Console.WriteLine((totStudents - carRiders) / numofbus);

            //  ''Aliyah had $24 to spend on seven pencils.
            // after buying them she had $10. How much did each pencil cost ?
            // 24-10 = 14 / 7

            int moneyHad = 24;
            int moneyHas = 10;
           
            int pencils = 7;

            Console.WriteLine((moneyHad - moneyHas) / pencils);

            //The sum of three consecutive numbers is 72. What are the smallest of these numbers?
            // x + (x+1) + (x+2) = 72

            int totalSum = 72;


































        }
    }
}
