using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeAlgorothm;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr;

            // Open in browser
            //https://www.hackerrank.com/challenges/array-left-rotation
            //LeftShiftAnArray(out newArr);

            // Open in browser
            //https://www.hackerrank.com/challenges/sparse-arrays
            //SolveSparseArrayProblem();

            ///https://www.hackerrank.com/contests/w34/challenges/once-in-a-tram/copy-from/1302367126
            //int x = Convert.ToInt32(Console.ReadLine());
            //string result = PracticeAlgoriithm.onceInATram(997998);
            //Console.WriteLine(result);


            //int[] grades = new int[] { 73, 67, 38, 33 };
            //int[] result2 = PracticeAlgoriithm.Solve(grades);
            //Console.WriteLine(String.Join("\n", result2));


#if false
            ///https://www.hackerrank.com/challenges/insertionsort1
            ///
            int _ar_size;
            //_ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[5] { 2, 4, 6, 8, 3 };
            PracticeAlgoriithm.insertionSort(_ar, 1);
            _ar = new int[5] { 2, 5, 8, 10, 1 };
            PracticeAlgoriithm.insertionSort(_ar, 1);
            _ar = new int[5] { 2, 5, 8, 10, 13 };
            PracticeAlgoriithm.insertionSort(_ar, 1);
            _ar = new int[5] { 2, 5, 8, 10, 9 };
            PracticeAlgoriithm.insertionSort(_ar, 1);

            Console.ReadLine();

            ///https://www.hackerrank.com/challenges/insertionsort2
            ///https://www.hackerrank.com/challenges/insertionsort2?h_r=next-challenge&h_v=zen
            ///
            int[] _ar2 = new int[5] { 2, 1, 6, 5, 3 };
            for (int i = 0; i < _ar2.Length; i++)
                PracticeAlgoriithm.insertionSort(_ar2, i + 1); 
#endif


            PracticeAlgoriithm.MaximumElementInStack();
        }

        //static string onceInATram(int v)
        //{
        //    // Complete this function
        //    if (v.ToString().Length != 6)
        //        return "";

        //    if (v.ToString().Equals("000000") || v.ToString().Equals("999999"))
        //        return "";

        //    int copyNum2 = v / 1000;
        //    int copyNum3 = v % 1000;

        //    //if (CalculateSum(copyNum2) == CalculateSum(copyNum3))
        //    //    return v.ToString();

        //    //if (CalculateSum(copyNum2) < CalculateSum(copyNum3))
        //    //{
        //    //    int sum = CalculateSum(copyNum3);

        //    //    for (int i = 0; ; i++)
        //    //    {
        //    //        int calculateSum = CalculateSum(++copyNum2);
        //    //        if (sum == calculateSum)
        //    //            break;
        //    //        else
        //    //            continue;
        //    //    }

        //    //    string nextNum = copyNum2.ToString() + copyNum3.ToString();
        //    //    return nextNum;
        //    //}
        //    //else
        //    //{
        //    int sum = CalculateSum(copyNum2);

        //    for (int i = 0; ; i++)
        //    {
        //        //int calculateSum = CalculateSum(++copyNum3);
        //        int temp = ++copyNum3;
        //        int calculateSum = 0;

        //        if (temp == 1000)
        //        {
        //            copyNum3 = v % 1000;
        //            sum = CalculateSum(copyNum3);
        //            calculateSum = CalculateSum(copyNum2++);
        //        }
        //        else
        //            calculateSum = CalculateSum(temp);

        //        if (sum == calculateSum)
        //        {
        //            if (temp == 1000)
        //                copyNum2--;
        //            break;
        //        }
        //        else
        //            continue;
        //    }

        //    string nextNum = copyNum2.ToString() + copyNum3.ToString();
        //    return nextNum;
        //    //}

        //}

        //private static int CalculateSum(int v)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        int t = v % 10;
        //        sum += t;
        //        v = v / 10;
        //    }
        //    return sum;
        //}

        private static void SolveSparseArrayProblem()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            List<string> parseString = new List<string>();
            List<string> queryString = new List<string>();
            //string[] queryString;
            //parseString.Add("aba");
            //parseString.Add("baba");
            //parseString.Add("aba");
            //parseString.Add("xzxb");

            for (int i = 0; i < n1; i++)
                parseString.Add(Console.ReadLine());

            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n2; i++)
                queryString.Add(Console.ReadLine());

            //queryString.Add("aba");
            //queryString.Add("xzxb");
            //queryString.Add("ab");

            parseArray(parseString, queryString);
            //Console.WriteLine(result);
        }

        static void parseArray(List<string> parse, List<string> query)
        {
            // Complete this function
            int count = 0;
            int[] output = new int[query.Count];

            //for (int i = 0; i < query.Count; i++)
            foreach (var f in query)
            {
                foreach (var q in parse)
                {
                    //if (query[i].Equals(q.ToString()))
                    if (f.Equals(q.ToString()))
                    {
                        output[count]++;
                    }
                }
                count++;
            }

            foreach (var i in output)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }


        private static int LeftShiftAnArray(out int[] newArr)
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(inputStr, Int32.Parse);
            newArr = new int[s.Length];

            int result = 0;
            bool t = int.TryParse(Console.ReadLine(), out result);
            int leftShift = result;

            if (leftShift % inputStr.Length == 0)
            {
                return 0;
            }

            int dummy = s[0];
            foreach (var i in s)
            {
                if (dummy != i)
                {
                    break;
                }
                //return 0;
            }

            int temp = -1;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (s.Length - (s.Length - leftShift - i) == s.Length)
                {
                    temp = 0;
                }
                if (temp >= 0)
                {
                    newArr[i] = s[temp];
                    temp++;
                    continue;
                }

                newArr[i] = s[s.Length - (s.Length - leftShift - i)];
            }

            return 0;
        }
    }
}
