using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_ProjectSort
{
    class InterchangeSort
    {
        private static string strQtr;
        public static int[] interchangeSort (int[] A, int nA)
        {
            int indexStep = 1;
            strQtr = "";
            for (int i = 0; i < nA - 1; i++)
                for (int j = i + 1; j < nA; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                    strQtr += $"\r\n Step {indexStep++}: ";
                    for (int x = 0; x < nA; x++)
                    {
                        int temp = A[x];
                        strQtr += Convert.ToString(temp) + " ";
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
