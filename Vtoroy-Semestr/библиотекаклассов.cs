using System;
using ClassLibraryTEST;


namespace ConsoleApptest1
{
    class Program
    {
       static double MinAVG(string[] marks)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            string[] marks = { "5", "4", "3" };
            Class1.test_function();
            Console.WriteLine();
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            MinAVG(marks);
            
        }
    }
}
