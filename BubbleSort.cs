using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_ProjectSort
{
    class BubbleSort
    {
        private static string strQtr;
        public static int[] bubbleSort(int[] A, int nA)
        {
            int indexStep = 1;
            strQtr = "";
            for (int i = 0; i < nA - 1; i++)
            {
                for (int j = nA - 1; j > i; j--)
                {
                    if (A[j] < A[j - 1])
                    {
                        int temp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = temp;
                    }
                    strQtr += $"\r\n Step {indexStep++}: ";
                    for (int x = 0; x < nA; x++)
                    {
                        int temp = A[x];
                        strQtr += Convert.ToString(temp) + " ";
                    }
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
