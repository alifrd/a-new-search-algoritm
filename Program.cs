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
            while(j<word.Length)
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
           
            string str1, str2;
            int lng1, lng2,drumT=0;
            float answer=0;
            int[] arrstr1=new int[26];
            int[] arrstr2 = new int[26];
            Console.WriteLine("name 1:");
            str1 = Console.ReadLine();
            Console.WriteLine("name 2:");
            str2 = Console.ReadLine();
            arrstr1= enumrate(str1);
            arrstr2 = enumrate(str2);
            drumT = examable(arrstr1, arrstr2);
            lng1 = length(arrstr1);
            lng2 = length(arrstr2);
            answer = (float)drumT / (float)Math.Sqrt(lng1 * lng2);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
      
    }
}
