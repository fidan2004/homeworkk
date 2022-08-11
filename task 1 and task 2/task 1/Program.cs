using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //task 1
            DateTime dt = new DateTime(2004, 05, 29);
            Console.WriteLine(dt.ToString("dddd"));
           
          //task 2
            DateTime dt2 = DateTime.Now;
            DateTime dt3 = new DateTime(2004, 05, 29);
            var result = DateTime.Now - dt3;
            Console.WriteLine(result);
        }
    }
}
