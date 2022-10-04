using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static int[] Merge_sorting_algorithm(int [] Array,int LeftPointer,int RightPointer)
        {
            if(LeftPointer == RightPointer)
            {
                return Array;
            }
            if(LeftPointer + 1 == RightPointer)
            {
                if((int)Array[RightPointer] < (int)Array[LeftPointer])
                {
                    int swapping_parameter = (int)Array[RightPointer];
                    Array[RightPointer] = (int)Array[LeftPointer];
                    Array[LeftPointer] = swapping_parameter;
                }
                return Array;
            }
            int MiddlePointer = (LeftPointer + RightPointer) / 2;
            int NewLeftPointer = LeftPointer, NewRightPointer = MiddlePointer;
            int[] NewArray = new int[30];
            int[] NewArrayLeft = new int[30];
            int[] NewArrayRight = new int[30];
            NewArrayLeft = Merge_sorting_algorithm(Array, LeftPointer, MiddlePointer);
            NewArrayRight = Merge_sorting_algorithm(Array, MiddlePointer + 1, RightPointer);
            for(int Counter = LeftPointer;Counter <= RightPointer; ++Counter)
            {
                if(NewLeftPointer > MiddlePointer)
                {
                    NewArray[Counter] = (int)NewArrayRight[NewRightPointer];
                    NewRightPointer++;
                }
                else if (NewRightPointer > RightPointer)
                {
                    NewArray[Counter] = (int)NewArrayLeft[NewLeftPointer];
                    NewLeftPointer++;
                }
                else
                {
                    if (Array[NewRightPointer] < Array[NewLeftPointer])
                    {
                        NewArray[Counter] = (int)NewArrayRight[NewRightPointer];
                        NewRightPointer++;
                    }
                    else
                    {
                        NewArray[Counter] = (int)NewArrayLeft[NewLeftPointer];
                        NewLeftPointer++;
                    }
                }
            }
            for (int Counter = 0; Counter <= (RightPointer - LeftPointer); ++Counter)
            {
                Array[LeftPointer + Counter] = NewArray[Counter];
            }
            return Array;
        }
        static void Main(string[] args)
        {
            int[] TestArray = new int[30];
            Random rand = new Random();
            for(int Counter = 1;Counter <= 20; ++Counter)
            {
                TestArray[Counter] = rand.Next() % 100;
                Console.Write(TestArray[Counter]);
                Console.Write(" ");
            }
            Console.WriteLine();
            int [] SortedTestArray = Program.Merge_sorting_algorithm(TestArray, 1, 20);
            for (int Counter = 1; Counter <= 20; ++Counter)
            {
                Console.Write(SortedTestArray[Counter]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
