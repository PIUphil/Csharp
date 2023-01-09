using System;

class Program {
    static void Main(string[] args) 
    {
      var a = 2; 
      var aa = 2.0;
      var aaa = 2f;
      var b = '3';
      var c = "A";
      
      
      Console.WriteLine(a + "\t"+ a.GetType());   // 2  System.Int32
      Console.WriteLine(aa + "\t"+ aa.GetType());   // 2  System.Double
      Console.WriteLine(aaa + "\t"+ aaa.GetType());   // 2  System.Single
      Console.WriteLine(b + "\t"+ b.GetType());   // 3  System.Char
      Console.WriteLine(c + "\t"+ c.GetType());   // A  System.String
      
      Console.WriteLine(a+b + "\t" + (a+b).GetType());   // 53  System.Int32
      Console.WriteLine(a+c + "\t" + (a+c).GetType());   // 2A  System.String
      Console.WriteLine(c+b + "\t" + (c+b).GetType());   // A3  System.String
      
      Console.WriteLine(b/a + "\t" + (b/a).GetType());   // 25  System.Int32
      Console.WriteLine(b/aa + "\t" + (b/aa).GetType());   // 25.5  System.Double
      Console.WriteLine(b/aaa + "\t" + (b/aaa).GetType());   // 25.5  System.Single
      
      Console.WriteLine(a+aa + "\t"+ (a+aa).GetType());   // 4  System.Double
      Console.WriteLine(a+aaa + "\t"+ (a+aaa).GetType());   // 4  System.Single
      Console.WriteLine(aa+aaa + "\t"+ (aa+aaa).GetType());   // 4  System.Double
    }
}
