using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAnswer = 0;
            int idx = 0;
            List<List<int>> arr = new List<List<int>>(new List<int>[n]);

            for (int i = 0; i < n; i++) arr[i] = new List<int>();
            
            List<int> res = new List<int>();

            foreach (List<int> query in queries)
            {
                idx = (query[1] ^ lastAnswer) % n;
                if (query[0] == 1) arr[idx].Add(query[2]);
                else
                {
                    int temp = query[2] % arr[idx].Count;
                    lastAnswer = arr[idx][temp];
                    res.Add(lastAnswer);
                }
            }
            return res;
        }
    }
}
