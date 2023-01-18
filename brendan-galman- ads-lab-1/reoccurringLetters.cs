using System.Globalization;
using System.Linq;

Console.WriteLine("Please provide a string");
string sentenceInput = Console.ReadLine();
string sentence = String.Join(" ", sentenceInput);
char[] multipleOccurance = new char[] { };

foreach (char letter in sentence)
{
    int count = 0;
    for (int i = 0; i < sentence.Length; i++)
    {
        if (letter == sentence[i])
        {
            count++;
        }
    }
    if (count > 1)
    {
        if (multipleOccurance.Contains(letter) == false)
        {

            Array.Resize(ref multipleOccurance, multipleOccurance.Length + 1);
            multipleOccurance[multipleOccurance.Length - 1] = letter;
        }

    }
}

Console.Write("The Letter(s) That Appear Multiple Times are:");
foreach (char letter in multipleOccurance)
{
    Console.Write($" {letter}");
}

Console.ReadLine();
