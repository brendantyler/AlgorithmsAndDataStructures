using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;

Console.WriteLine("Please Provide a string you want to find the longest word of");
string? findLong = Console.ReadLine();

bool checkString = true;

while (checkString)
{
    if (findLong == "" || findLong == null)
    {
        Console.WriteLine("Please Enter a valid string");
        findLong = Console.ReadLine();
    } else
    {
        checkString = false;
    }
}

findLong = Regex.Replace(findLong, @"[^\w\d\s]", "");
string[] toWords = findLong.Split(new[] { ' ' });


int currentLongest = 0;
string longestWord = string.Empty;

foreach (string word in toWords)
{
    if (word.Length > currentLongest)
    {
        currentLongest= word.Length;
        longestWord = word;
    }
}

Console.WriteLine("The longest word in the provided string is...");
Console.ReadLine();
Console.WriteLine(longestWord);