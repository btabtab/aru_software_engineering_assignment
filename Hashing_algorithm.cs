using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics.BigInteger;


namespace Hashing
{

	static int[] checking(int[] array)
    {
		int pos = 0;
		for(int i = 1; i <= array[0] + 10; ++i)
        {
			if (array[i] > 10)
			{
				array[i + 1] = array[i] / 10;
				array[i] %= 10;
			}
			if (array[i] != 0)
			{
				pos = i;
			}
		}
		array[0] = pos;
		return array;
	}

	static int[] bigAddition(int[] first, int[] second)
    {
		int[] result = new int[first[0] + second[0]];
		for(int i = 1;i <= int.MaxValue(first[0], second[0]) + 3; ++i)
        {
			result[i] += first[i] + second[i];
        }
		return checking(result);
    }

	static int[] multiplication(int[] first,int second)
	{
		int[] result = new int[first[0] + 10];
		for (int i = 1;i <= first[0]; ++i)
        {
			result[i] = first[i] * second;
        }
		return checking(result);
	}

	static int[] hashingAlgorithm(string password)
	{
		int[] newPassword = new int[1000];
		int[] primePow = new int[1000];
		int prime = 107;
		newPassword[0] = password.Length;
		for(int i = 0;i < password.Length; ++i)
        {
			newPassword[i + 1] = password[i];
        }
		newPassword = checking(newPassword);
		primePow[0] = 1;
		primePow[1] = prime;
		primePow = checking(primePow);
		int[] encryptedPassword = new int[1000];
		encryptedPassword[0] = 1000;
		for(int i = 1;i <= newPassword[0]; ++i)
        {
			encryptedPassword = checking(bigAddition(encryptedPassword, multiplication(primePow,newPassword[i])));
			primePow = checking(multiplication(primePow,prime));
        }
		return encryptedPassword;
	}
}
