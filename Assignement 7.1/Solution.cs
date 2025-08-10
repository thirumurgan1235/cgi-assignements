using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_7._1
{
    internal class Solution
    {
        public int solution(int[] A)
        {
            int sum = 0;

            foreach (int num in A)
            {
                if (num == 0)
                    break; 

                if (num > 0)
                    sum += num; 
            }

            return sum;
        }
    }
}
