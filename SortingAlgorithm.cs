using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aru_software_eng_UI
{
	class Sorting
    {

		public void printList(List <int> array)
        {
			for (int counter = 0; counter < array.Count(); ++counter)
			{
				Console.Write(array[counter]);
				Console.Write(" ");
			}
			Console.WriteLine();
			return;
		}

		public List<int> merge(List <int> array,int left,int middle,int right)
        {
			int subArrayOne = middle - left + 1;
			int subArrayTwo = right - middle;

			List<int> arrayOne = new List<int>();
			List<int> arrayTwo = new List<int>();

			for(int i = 0;i < subArrayOne; ++i)
            {
				arrayOne.Add(array[left + i]);
            }

			for (int i = 0; i < subArrayTwo; ++i)
			{
				arrayTwo.Add(array[middle + i + 1]);
			}

			int indexOne = 0, indexTwo = 0;
			int indexMergedArray = left;

			while(indexOne < subArrayOne && indexTwo < subArrayTwo)
            {
				if(arrayOne[indexOne] <= arrayTwo[indexTwo])
                {
					//array.Add(arrayOne[indexOne]);
					array[indexMergedArray] = arrayOne[indexOne];
					//Console.WriteLine(arrayOne[indexOne]);
					indexOne++;
                }
                else
                {
					//array.Add(arrayTwo[indexTwo]);
					array[indexMergedArray] = arrayTwo[indexTwo];
					//Console.WriteLine(arrayTwo[indexTwo]);
					indexTwo++;
				}
				indexMergedArray++;
            }

			while(indexOne < subArrayOne)
            {
				//array.Add(arrayOne[indexOne]);
				array[indexMergedArray] = arrayOne[indexOne];
				//Console.WriteLine(arrayOne[indexOne]);
				indexOne++;
				indexMergedArray++;
			}

			while(indexTwo < subArrayTwo)
            {
				//array.Add(arrayTwo[indexTwo]);
				array[indexMergedArray] = arrayTwo[indexTwo];
				//Console.WriteLine(arrayTwo[indexTwo]);
				indexTwo++;
				indexMergedArray++;
			}

			return array;
        }

		public List<int> mergeSortingAlgorithm(List<int> array, int leftPointer, int rightPointer)
        {
			if (leftPointer < rightPointer)
			{
				int middlePointer = leftPointer + ((rightPointer - leftPointer) / 2);

				mergeSortingAlgorithm(array, leftPointer, middlePointer);
				mergeSortingAlgorithm(array, middlePointer + 1, rightPointer);

				//printList(arrayOne);
				//printList(arrayTwo);

				//array.Clear();

				array = merge(array, leftPointer, middlePointer, rightPointer);

				//arrayOne.Clear();
				//arrayTwo.Clear();
			}

			return array;
		}

		public void mergeSortTest()
        {
			List<int> testArray = new List<int>();
			Random rand = new Random();
			int testSize = rand.Next() % 100 + 1;
			for (int counter = 0; counter < testSize; ++counter)
			{
				testArray.Add(rand.Next() % 100);
			}

			printList(testArray);

			List<int> sortedTestArray = mergeSortingAlgorithm(testArray, 0, testSize - 1);

			printList(sortedTestArray);

			return;
		}
	}
}