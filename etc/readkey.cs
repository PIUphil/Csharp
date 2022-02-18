using System;

namespace readkey
{
    class Program
    {
        static void Main(string[] args)
        {
            // 엔터없이 입력 후 출력
            Console.Write("키 입력 : ");
            ConsoleKeyInfo cskey = Console.ReadKey();
            Console.WriteLine("\n"+cskey.KeyChar+"\n");
                        
            // 엔터치면 입력값(문장) 출력
            Console.Write("키 입력 (+엔터): ");
            string readline = Console.ReadLine();
            Console.WriteLine(readline +"\n");
        }
    }
}
