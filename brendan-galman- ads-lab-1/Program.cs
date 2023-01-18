using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Transactions;

Start: 
Console.WriteLine("Please enter a number:");
int wordAmount = 0;

while (wordAmount <= 0)
{
    try
    {
        wordAmount = Int32.Parse(Console.ReadLine());
        if (wordAmount <= 0)
        {
            Console.WriteLine("Please enter an appropriate value");
        } 
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a numerical value:");
    }

}

Console.WriteLine($"Please Enter {wordAmount} words");

string[] enteredWords = new string[wordAmount];

for (int i = 0; i < enteredWords.Length;)
{
    enteredWords[i] = Console.ReadLine();

    if (enteredWords[i].All(char.IsLetter) == false)
    {
        Console.WriteLine("Please do not use Spaces or Numbers or Symbols");
    }
    else if (enteredWords[i].Length == 0)
    {
        Console.WriteLine($"Please enter a Valid Word");
    }
    else
    {
        i++;
    }
}

string joinWords = string.Join("", enteredWords);

char[] separateChars = joinWords.ToLower().ToCharArray();

BigInteger totalChars = separateChars.Length;

char letterToCheck = ' ';

Console.WriteLine("Please enter a character to count:");

while (letterToCheck == ' ') {
    char letterChosen = Console.ReadKey().KeyChar;

    if (Char.IsLetter(letterChosen))
    {
        letterToCheck = letterChosen;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a Valid Character");
    }
}


int letterOccurences = 0;

foreach (char letter in separateChars)
{
    if (Char.ToLower(letterToCheck) == letter)
    {
        letterOccurences++;
    }
}

double percentDouble = ((double)letterOccurences / (double)totalChars) * 100;
int percentInt = (int)percentDouble;

Console.WriteLine();
Console.WriteLine($"Out of {totalChars} total letters");
Console.WriteLine($"The letter '{letterToCheck}' appears {letterOccurences} times in the array.");
Console.WriteLine($"This letter makes up more than {percentInt}% of the total number of characters");

Console.ReadLine();

Console.WriteLine("Did you want to start again?");
Console.WriteLine("Y/N");

bool responseLoop = true;

while (responseLoop) {

    char restartResponse = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (Char.ToUpper(restartResponse))
    {
        case 'Y':
            Console.WriteLine("Restarting...");
            responseLoop = false;
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Welcome Back!");
            goto Start;
        case 'N':
            Console.WriteLine("See You Next Time");
            responseLoop = false;
            break;
        default:
            Console.WriteLine("Please Enter a Valid Response");
            break;
    }
} 




