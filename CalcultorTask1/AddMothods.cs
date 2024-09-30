using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcultorTask1
{
    public class AddMothods
    {
       public int calculte_Math(int var1, int var2 , int sign)
        {
            int Result = 0;
            if (sign == 1)
            {
                Result = var1 + var2;
            }
            else if (sign == 2)
            {
                Result = var1 - var2;
            }
            else if (sign == 3)
            {
                Result = var1 * var2;
            }
            else if (sign == 4)
            {
                Result = (var2 / var1);
            }

            return Result;

        }
    }
}
