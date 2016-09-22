using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication2
{

    class Program
    {
        public static int[] enumrate(string word)
        {
            int[] arr = new int[26];
            int j = 0;
            word = word.ToLower();
            while (j < word.Length)
            {
                for (int i = 97; i <= 122; i++)
                    if ((char)i == word[j])
                        arr[i - 97]++;
                j++;
            }

            return (arr);
        }
        public static int examable(int[] code1, int[] code2)
        {
            int sum = 0;
            for (int i = 0; i < 26; i++)
                sum += code1[i] * code2[i];
            return (sum);
        }
        public static int length(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i * i;
            return (sum);
        }

        static void Main(string[] args)
        {

            string str1, str2,str3,str4;
            int lng1, lng2,lng3,lng4, drumT1 = 0, drumT2 = 0, drumT3 = 0;
            float answer = 0;
            int[] arrstr1 = new int[26];
            int[] arrstr2 = new int[26];
            int[] arrstr3 = new int[26];
            int[] arrstr4 = new int[26];
            Console.WriteLine("Please ,Enter a Name That Is Compared With The First Four Others ");
            Console.Write("Name 1:");
            str1 = Console.ReadLine();
            Console.Write("Name 2:");
            str2 = Console.ReadLine();
            Console.Write("Name 3:");
            str3 = Console.ReadLine();
            Console.Write("Name 4:");
            str4 = Console.ReadLine();
            arrstr1 = enumrate(str1);
            arrstr2 = enumrate(str2);
            arrstr3 = enumrate(str3);
            arrstr4 = enumrate(str4);
            lng1 = length(arrstr1);
            lng2 = length(arrstr2);
            lng3 = length(arrstr3);
            lng4 = length(arrstr4);
            drumT1 = examable(arrstr1, arrstr2);
            drumT2 = examable(arrstr1, arrstr3);
            drumT3 = examable(arrstr1, arrstr4);
            Console.Clear();
            answer = (float)drumT1 / (float)Math.Sqrt(lng1 * lng2);
            Console.WriteLine("{0} vs {1}:{2}",str1,str2,answer);
            answer = (float)drumT2 / (float)Math.Sqrt(lng1 * lng3);
            Console.WriteLine("{0} vs {1}:{2}", str1, str3, answer);
            answer = (float)drumT3 / (float)Math.Sqrt(lng1 * lng4);
            Console.WriteLine("{0} vs {1}:{2}", str1, str4, answer);
            Console.ReadLine();
        }

    }
}
