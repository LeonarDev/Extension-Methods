using System;
//using Extension_methods.Extensions;

namespace Extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 09, 18, 14, 20, 44);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
