using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example_02.Services
{
    class CalculationService
    {

        public int Max(List<int> list)
        {
            int max = list[0];

            for (int i = 1; i < list.Count; i++)
            {

                if (list[i] > max)
                {
                    max = list[i];
                }

            }

            return max;
        }

    }
}
