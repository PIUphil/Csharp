using System;

class Program 
{
  static void Main(string[] args) 
  {      
    int a = 3;

    Func<int, int> z = x => x*x;
    
    Console.WriteLine(z(a));
  }
}
