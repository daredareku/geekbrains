int[,] GetDictionary(int[] array)
{
	int[] uniqueArray = GetUniqueValuesCount(array);
	int[,] dictionary = new int[uniqueArray.Length, 2];

	for (int i = 0; i < uniqueArray.Length; i++)
	{
		dictionary[i, 0] = uniqueArray[i];
	}

	for (int i = 0; i < array.Length; i++)
	{
		dictionary[IndexOf(dictionary, array[i]), 1]++;
	}

	return dictionary;
}


// 1 1 2 3 2 1 4 5 5 6 7
int[] GetUniqueValuesCount(int[] array)
{
	List<int> uniqueValues = new List<int>();

	for (int i = 0; i < array.Length; i++)
	{
		if (!uniqueValues.Contains(array[i]))
		{
			uniqueValues.Add(array[i]);
		}
	}

	return uniqueValues.ToArray();
}

int IndexOf(int[,] array, int number)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		if (array[i, 0] == number)
		{
			return i;
		}
	}

	return -1;
}

int[] CreateArray(int length)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < length; i++)
	{
		array[i] = random.Next(1, 11);
	}

	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

void PrintOneDimensionArray(int[] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write(array[i] + " ");
	}
	Console.WriteLine();
}

int[] array = CreateArray(10);
PrintOneDimensionArray(array);

PrintArray(GetDictionary(array));
