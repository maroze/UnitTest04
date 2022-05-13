using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR04
{
    public static class ArrayFind
    {
        public static int FindMin(int[] a)
        {//0
            int min = 0;//1

            for (int i = 0; i < a.Length; i++)//2
            {
                if (a[i]< min)//3
                {
                    min = a[i];//4
                }
            }
            return min;//5
        }//6
    }
}
