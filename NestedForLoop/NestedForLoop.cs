using System;

namespace PCPS.NestedForLoop
{
    public class NestedForLoopExample
    {
        public static void Run()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}