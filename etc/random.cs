using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNum = rand.Next();
            Console.WriteLine($"랜덤숫자 : {randNum}");


            // 100회
            Random rand_ = new Random();
            //List<int> ranNumList = new List<int>();
            int[] howmany = new int[100+1];

            for (int i = 0; i < 100; i++)
            {   
                int randNum_ = rand_.Next(1, 101);  // 1~100
                howmany[randNum_]++;

                //Console.Write(randNum_ + " ");
            }

            //Console.WriteLine();
            //foreach (int hh in howmany)
            //    Console.Write(hh + " ");
            //Console.WriteLine();

            var m = from hm in howmany
                    orderby hm descending
                    select hm;

            //foreach (int mm in m)
            //    Console.Write(mm + " ");

            //Console.WriteLine();
            //Console.WriteLine(m.Max());
            //Console.WriteLine("가장 많이 나온 숫자 : "+Array.IndexOf(howmany, m.Max()));
            //Console.WriteLine(Array.FindIndex(howmany, x=>x==m.Max()));       // lambda

            Console.Write("[1~100] 가장 많이 나온 숫자 : ");

            int i_ = 0, j = 0;

            while(j!=-1)
            {
                j = Array.IndexOf(howmany, m.Max(), i_);
                if (j == -1)
                    break;

                Console.Write(j+" ");
                i_ = j+1;
            }

            Console.WriteLine($" / {m.Max()}번");
        }
    }
}
