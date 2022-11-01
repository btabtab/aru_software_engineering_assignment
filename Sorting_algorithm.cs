using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aru_software_eng_UI
{
	static int[] mergeSortingAlgorithm(int [] array, int left_pointer, int right_pointer)
	{
		if(left_pointer == right_pointer)
		{
			return array;
		}
		if(left_pointer + 1 == right_pointer)
		{
			if((int)array[right_pointer] < (int)array[left_pointer])
			{
				int swapping_parameter = (int)array[right_pointer];
				array[right_pointer] = (int)array[left_pointer];
				array[left_pointer] = swapping_parameter;
			}
			return array;
		}
		int middle_pointer = (left_pointer + right_pointer) / 2;
		int new_left_pointer = left_pointer, new_right_pointer = middle_pointer;
		int[] new_array = new int[30];
		int[] new_array_left = new int[30];
		int[] new_array_right = new int[30];
		new_array_left = Merge_sorting_algorithm(array, left_pointer, middle_pointer);
		new_array_right = Merge_sorting_algorithm(array, middle_pointer + 1, right_pointer);
		for(int counter = left_pointer; counter <= right_pointer; ++counter)
		{
			if(new_left_pointer > middle_pointer)
			{
				new_array[counter] = (int)new_array_right[new_right_pointer];
				new_right_pointer++;
			}
			else if (new_right_pointer > right_pointer)
			{
				new_array[counter] = (int)new_array_left[new_left_pointer];
				new_left_pointer++;
			}
			else
			{
				if (array[new_right_pointer] < array[new_left_pointer])
				{
					new_array[counter] = (int)new_array_right[new_right_pointer];
					new_right_pointer++;
				}
				else
				{
					new_array[counter] = (int)new_array_left[new_left_pointer];
					new_left_pointer++;
				}
			}
		}
		for (int counter = 0; counter <= (right_pointer - left_pointer); ++counter)
		{
			array[left_pointer + counter] = new_array[counter];
		}
		return array;
	}
	static void mergeSortTest()
	{
		int[] test_array = new int[30];
		Random rand = new Random();
		for(int counter = 1; counter <= 20; ++counter)
		{
			test_array[counter] = rand.Next() % 100;
			Console.Write(test_array[counter]);
			Console.Write(" ");
		}
		Console.WriteLine();
		int [] sorted_test_array = mergeSortingAlgorithm(test_array, 1, 20);
		for (int counter = 1; counter <= 20; ++counter)
		{
			Console.Write(sorted_test_array[counter]);
			Console.Write(" ");
		}
		Console.ReadKey();
	}
}
