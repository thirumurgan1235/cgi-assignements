using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_7
{
    internal class Solution
    {
        public int solution(int[] A)
        {
            int minPositive = int.MaxValue;
            bool found = false;

            foreach (int num in A)
            {
                if (num > 0 && num < minPositive)
                {
                    minPositive = num;
                    found = true;
                }
            }

            if (found)
            {
                return minPositive * minPositive;
            }
            else
            {
                return 0;
            }
        }
    }
}
