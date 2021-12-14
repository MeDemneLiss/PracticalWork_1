using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_1
{
    public class Practical
    {
        public static void Calculate(int NumberK,out string GenerateNumbers1, out int Sum1, out int AmountNambers1)
        {
            Random Rnd; Rnd = new Random();
            GenerateNumbers1 = "";
            Sum1 = 0;
            AmountNambers1 = 0;
            int MaxChapter = 11; ;
            //if (NumberK < 11)
            //{
            //    MaxChapter = NumberK;
            //} 
            do
            {
                int Chapter = Rnd.Next(2, MaxChapter);
                if (Sum1 + Chapter < NumberK)
                {
                    GenerateNumbers1 += Chapter + "  ";
                    Sum1 += Chapter;
                    AmountNambers1++;
                } else return ;
            }
            while (Sum1 < NumberK);

        }

    }
}
