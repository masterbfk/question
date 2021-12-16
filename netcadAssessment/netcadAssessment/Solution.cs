using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcadAssessment
{
    public class Solution
    {
        public int solution(int[] K)
        {
            int smallest = -1;
            for (int i = 0; i < K.Length; i++)
            {
                var leftArr = new int[i+1];
                var rightArr = new int[K.Length - (i+1)];
                Array.Copy(K, leftArr, i + 1);
                Array.Copy(K,i+1, rightArr, 0, K.Length - (i + 1));
                if (rightArr.Length == 0)
                {
                    if (smallest == -1 || leftArr.Max() * leftArr.Length  < smallest)
                    {
                        smallest = leftArr.Max() * leftArr.Length;
                    }
                }
                else
                {
                    if (smallest == -1 || (leftArr.Max() * leftArr.Length) + (rightArr.Max() * rightArr.Length) < smallest)
                    {
                        smallest = (leftArr.Max() * leftArr.Length) + (rightArr.Max() * rightArr.Length);
                    }
                }                
            }
            return smallest;
        }
    }
}
