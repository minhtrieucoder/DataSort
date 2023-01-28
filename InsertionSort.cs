using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_ProjectSort
{
    class InsertionSort
    {
        private static string strQtr;
        public static int[] insertionSort(int[] A, int nA)
        {
            int indexStep = 1;
            strQtr = "";
            for (int i = 1; i < nA; i++)
            {
                int temp = A[i], pos = i;
                for (int j = i; j > 0; j--)
                {
                    if (A[j - 1] > temp)
                    {
                        A[j] = A[j - 1];
                        pos = j - 1;
                    }
                    strQtr += $"\r\n Step {indexStep++}: ";
                    for (int x = 0; x < nA; x++)
                    {
                        int tempp = A[x];
                        strQtr += Convert.ToString(tempp) + " ";
                    }
                }
                A[pos] = temp;
                strQtr += $"\r\n Step {indexStep++}: ";
                for (int x = 0; x < nA; x++)
                {
                    int tempp = A[x];
                    strQtr += Convert.ToString(tempp) + " ";
                }
            }
            return A;
        }

        public static string getQuaTrinh()
        {
            return strQtr;
        }
    }
}
