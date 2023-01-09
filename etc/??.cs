using System;

class Program 
{
  static void Main(string[] args) 
  {      
    string a = "hello";
    string b = null;
    Console.WriteLine(b??a);    // Console.WriteLine(!string.IsNullOrEmpty(b) ? b : a);
  }
}
