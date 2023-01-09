using System;

class Program {
    static void Main(string[] args) {
        int? a = null;
        int? b = 3;
        // int c = null;  // int에 null 사용불가
        Nullable <int> d = null;
      
        Console.WriteLine(a.GetValueOrDefault());  // 0
        Console.WriteLine(a);  // 아무것도 출력되지 않음
        Console.WriteLine(b + "\t" + b.GetType());  // 3  System.Int32
        Console.WriteLine(a ?? b);  // 3
        Console.WriteLine(d.GetValueOrDefault());  // 0
    }
}
