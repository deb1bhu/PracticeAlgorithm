using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAlgorothm
{
    public static class PracticeAlgoriithm // Default Access modifier of a class is internal
    {
        public static void MethodA()
        {
            Console.WriteLine("Accessible");
        }

        public static string onceInATram(int v)
        {
            // Complete this function
            if (v.ToString().Length != 6)
                return "";

            if (v.ToString().Equals("000000") || v.ToString().Equals("999999"))
                return "";

            int copyNum2 = v / 1000;
            int copyNum3 = v % 1000;

            //if (CalculateSum(copyNum2) == CalculateSum(copyNum3))
            //    return v.ToString();

            //if (CalculateSum(copyNum2) < CalculateSum(copyNum3))
            //{
            //    int sum = CalculateSum(copyNum3);

            //    for (int i = 0; ; i++)
            //    {
            //        int calculateSum = CalculateSum(++copyNum2);
            //        if (sum == calculateSum)
            //            break;
            //        else
            //            continue;
            //    }

            //    string nextNum = copyNum2.ToString() + copyNum3.ToString();
            //    return nextNum;
            //}
            //else
            //{
            int sum = CalculateSum(copyNum2);

            for (int i = 0; ; i++)
            {
                //int calculateSum = CalculateSum(++copyNum3);
                int temp = ++copyNum3;
                int calculateSum = 0;

                if (temp == 1000)
                {
                    copyNum3 = v % 1000;
                    sum = CalculateSum(copyNum3);
                    calculateSum = CalculateSum(copyNum2++);
                }
                else
                    calculateSum = CalculateSum(temp);

                if (sum == calculateSum)
                {
                    if (temp == 1000)
                        copyNum2--;
                    break;
                }
                else
                    continue;
            }

            string nextNum = copyNum2.ToString() + copyNum3.ToString();
            return nextNum;
            //}

        }

        public static void insertionSort(int[] ar, int index)
        {
            Console.WriteLine();
            int len = ar.Length;
            int temp = ar[len - index];

            for (int i = len - 1; ; i--)
            {
                if (i != 0 && ar[i - 1] < temp)
                {

                    ar[i] = temp;
                    displayArray(ar);
                    Console.WriteLine();
                    break;
                }
                else if (i == 0)
                {
                    ar[i] = temp;
                    displayArray(ar);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    ar[i] = ar[i - 1];
                    displayArray(ar);
                    Console.WriteLine();
                }
            }
        }

        static void displayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }

        private static int CalculateSum(int v)
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                int t = v % 10;
                sum += t;
                v = v / 10;
            }
            return sum;
        }

        /// 
        public static int[] Solve(int[] grades)
        {
            int[] newArr = new int[grades.Length];
            // Complete this function
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] / 5 >= 7)
                {
                    if (5 - (grades[i] % 5) <= 2)
                    {
                        int temp = grades[i] / 5;
                        newArr[i] = ++temp * 5;
                    }
                    else
                        newArr[i] = grades[i];
                }
                else
                {
                    newArr[i] = grades[i];
                }

            }

            return newArr;
        }


        public static int MaximumElementInStack()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<long> outputList = new List<long>();

            for (long i = 0; i < n; i++)
            {
                string val = Console.ReadLine();
                if (val.Contains("1"))
                {
                    string[] strSplit = val.Split(' ');
                    outputList.Add(Convert.ToInt64(strSplit[1]));
                }
                else if (Convert.ToInt64(val) == 2)
                {
                    outputList.RemoveAt(outputList.Count - 1);
                }
                else
                {
                    if (outputList.Count > 1)
                    {
                        outputList.Sort();
                        Console.WriteLine(outputList[outputList.Count - 1]);
                    }
                    else if (outputList.Count == 1)
                    {
                        Console.WriteLine(outputList[0]);
                    }
                }
            }


            return 0;

        }

    }
}
