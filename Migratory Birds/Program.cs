//Complete in 15 minutes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = CalculateMigratoryBirds(arr);
            Console.WriteLine(result);
        }

        static int CalculateMigratoryBirds(List<int> arr)
        {
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 1)
                    count1++;
                else if (arr[i] == 2)
                    count2++;
                else if (arr[i] == 3)
                    count3++;
                else if (arr[i] == 4)
                    count4++;
                else
                    count5++;
            }
            return CalcMax(count1, count2, count3, count4, count5);
        }

        static int CalcMax(int a, int b, int c, int d, int e)
        {
            int max = a;
            int i = 1;
            if (b > max)
            {
                max = b;
                i = 2;
            }
            if (c > max)
            {
                max = c;
                i = 3;
            }
            if (d > max)
            {
                max = d;
                i = 4;
            }
            if (e > max)
            {
                max = e;
                i = 5;
            }
            
            return i;
        }

        
    }
}
