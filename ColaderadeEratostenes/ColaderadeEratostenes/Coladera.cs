using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderadeEratostenes
{
    class Coladera
    {
        private static int[] vec;

        public Coladera()
        {
            vec = new int[999];
        }

        public void llenar()
        {
            for(int i = 1; i< vec.Length; i++)
            {
                vec[i - 1] = i;
            }
        }

        public void Colar()
        {
            for(int i = 1; i < vec.Length; i++)
            {
                if (vec[i-1]%2 == 0 && vec[i-1] > 2)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 3 == 0 && vec[i-1] > 3)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 5 == 0 && vec[i - 1] > 5)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 7 == 0 && vec[i-1] > 7)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 11 == 0 && vec[i - 1] > 11)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 13 == 0 && vec[i - 1] > 13)
                {
                    vec[i - 1] = 0;
                }else if (vec[i - 1] % 17 == 0 && vec[i - 1] > 17)
                {
                    vec[i - 1] = 0;
                }
                else if (vec[i - 1] % 19 == 0 && vec[i - 1] > 19)
                {
                    vec[i - 1] = 0;
                }
                else if (vec[i - 1] % 23 == 0 && vec[i - 1] > 23)
                {
                    vec[i - 1] = 0;
                }
                else if (vec[i - 1] % 29 == 0 && vec[i - 1] > 29)
                {
                    vec[i - 1] = 0;
                }
                else if (vec[i - 1] % 31 == 0 && vec[i - 1] > 31)
                {
                    vec[i - 1] = 0;
                }

            }
        }

        public override string ToString()
        {
            string primos = "";
            for (int i = 1; i < vec.Length; i++)
            {
                if (vec[i - 1] > 0)
                {
                    primos += vec[i - 1] + ", ";
                }
            }

                return primos;
        }
    }
}
