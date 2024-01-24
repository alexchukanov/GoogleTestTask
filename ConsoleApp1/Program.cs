// Google test task:
// Convert array int[] arr = { 1, 2, 3} to digit 123
// add 123+1 = 124
// get int[] arr = { 1, 2, 4}
// 30 min

using System;

int[] arr = { 1, 2, 3};  

Console.WriteLine($"arr = [{string.Join(",", arr)}]");

int sum = GetNumFromArr(arr);

sum++;

int[] arr2 = GetArrFromNum(sum);

Console.WriteLine($"arr2 = [{string.Join(",", arr2)}]");

Console.ReadLine();

int GetNumFromArr(int[] arr)
{ 
	double sum = 0;

	for (int i = 0; i < arr.Length; i++)
	{
		double s = Math.Pow(10, arr.Length - i - 1);
		sum += arr[i] * s;
	}

	return (int)sum;
}

int[] GetArrFromNum(int num)
{
	int numLength = num.ToString().Length;

	int[] arr = new int[numLength];
	double mod = 0;

	for (int i = 0; i < numLength; i++)
	{
		mod = num % 10;
		arr[numLength - i - 1] = (int)mod;
		num = num/10;
	}

	return arr;
}


{ }
