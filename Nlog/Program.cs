using System;


namespace NLogSession
{
  public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Addition problem \n Enter a,b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumber add = new AddNumber();
            Console.WriteLine("Result is"+" " + add.sum(a , b));
        }
    }
}
