int[] numArray = { 1, 2, 3, 4, 2, 9, 2, 4, 7};
Array.Sort(numArray);

//should return [2, 4]

foreach (int num in numArray)
{
    int i = num - 1;

    if (numArray[i] == 0)
    {
        numArray[i] = num;
        Console.WriteLine(num);
    }
    else
    {
        numArray[i] = num - num;
    }

}