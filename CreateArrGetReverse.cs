//
int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max);
	}

	return array;
}

int[] GetReverseArray(int[] array)
{
	int[] reversedArray = new int[array.Length];

	for (int i = 0; i < array.Length; i++)
	{
		reversedArray[i] = -array[i];
	}

	return reversedArray;
}

string ArrayToString(int[] array)
{
	string result = "[";

	foreach (int item in array)
	{
		result += $"{item}, ";
	}

	result.Trim(',');
	result += "]";

	return result;
}

int[] array = CreateArray(10, -10, 10);

Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(GetReverseArray(array)));
