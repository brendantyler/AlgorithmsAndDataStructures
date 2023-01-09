using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Transactions;

Console.WriteLine("Please enter a number:");
int wordAmount = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Please Enter {wordAmount} words");

string[] enteredWords = new string[wordAmount];

for (int i = 0; i < enteredWords.Length; i++)
{
    enteredWords[i] = Console.ReadLine();
}

string joinWords = string.Join("", enteredWords);

char[] separateChars = joinWords.ToCharArray();


Console.WriteLine("Please enter a character");
char letterToCheck = Console.ReadKey().KeyChar;

int letterOccurences = 0;

foreach (char letter in separateChars)
{
    if (letterToCheck == letter)
    {
        letterOccurences++;
    }
    else
    {
        continue;
    }
}

double occurancePercent = ((double)letterOccurences / (double)separateChars.Length) * 100;

Console.WriteLine("");
Console.WriteLine($"The letter '{letterToCheck}' appears {letterOccurences} times in the array.");
Console.WriteLine($"This letter makes up {occurancePercent}% of the total number of characters");

Console.ReadLine();




