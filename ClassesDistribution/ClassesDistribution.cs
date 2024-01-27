using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class ClassesDistribution
    {
        #region YOUR CODE IS HERE
      
        //Your Code is Here:
        //==================
        /// <summary>
        /// determine if there exists such a lucky class and determine its grade.
        /// </summary>
        /// <param name="N">Size of the array</param>
        /// <param name="array">array containing the grade number in each floor</param>
        /// <returns>if exist: return grade of the lucky class (whose grade is in the same floor number) 
        ///         else: return -1</returns>
        static public int GetLuckyClass(int N, int[] array)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            //base
            if (array[0] > N)
                return -1;
            if (N == 1)
            {
                if (array[0] == 0)
                    return array[0];
            }
            return divide(0, N,array, N);
        }
        static public int divide(int low, int high,int[] array, int N)
        {
            int mid = (low+high) / 2;
            if (low > high)
                return -1;
            if (array[mid] > 0 && array[mid - 1] < 0)
            {
                for (int i = mid; i < N; i++)
                {
                    if (array[i] == i)
                    {
                        return array[i];
                    }
                }
            }
            else if (array[mid] < 0)
                return divide(mid + 1, high, array, N);
            else if (array[mid-1]>0)
                return divide(low, mid - 1, array, N);
            else
                return divide(low, mid - 1, array, N);
            return -1;
        }
        #endregion
    }
}
