using System;

namespace delete_me
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            do
            {
                Console.Write("enter num");
                num = int.Parse(Console.ReadLine());
            } while (num != null);
        }
    }
}
