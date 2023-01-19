int[] arr1 = { 1, 2, 3, 4, 5 };
int[] arr2 = { 2, 5, 7, 9, 13 };
// Program should return { 1, 2, 2, 3, 4, 5, 5, 7, 9, 13}

// Combine strings 
int[] arrFinal = arr1.Concat(arr2).ToArray();

Console.WriteLine(string.Join( " ", arrFinal));

int holdNumber = 0;

// Compare 
for (int i = 0; i < arrFinal.Length; i++)
{
    for (int j = i + 1; j < arrFinal.Length; j++)
    {
    }
}

Console.WriteLine(string.Join(" ", arrFinal));

