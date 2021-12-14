using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_1
{
    public class Practical
    {
        public static void Calculate(int numberK,out string generateNumbers, out int sum, out int amountNambers)
        {
            Random Rnd; Rnd = new Random();
            generateNumbers = "";
            sum = 0;
            amountNambers = 0;
            int maxChapter = 11; ;
            //if (NumberK < 11)
            //{
            //    MaxChapter = NumberK;
            //} 
            do
            {
                int chapter = Rnd.Next(2, maxChapter);
                if (sum + chapter < numberK)
                {
                    generateNumbers += chapter + "  ";
                    sum += chapter;
                    amountNambers++;
                } else return ;
            }
            while (sum < numberK);

        }

    }
}
