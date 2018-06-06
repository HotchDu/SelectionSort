using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 44, 3, 76, 98, 11, 66, 9, 7 };
            Console.WriteLine("需要排序的数组为：");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //选择排序：种简单直观的排序算法。它的工作原理是每一次从待排序的数据元素中选出最小（或最大）的一个元素，
            //存放在序列的起始位置，直到全部待排序的数据元素排完。
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                int minVal = arr[i]; //默认第一个是最小的数字，记录value和index；
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(minVal > arr[j])
                    {
                        //只需记录位置，无需变换位置；
                        minVal = arr[j];
                        minIndex = j;
                    }
                    else
                    {
                        continue;
                    }
                }
                //循环结束，得到最小值的value和index，根据index进行放置
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("排序后的数组为：");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
