using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Please enter a phrase");
string? phraseInput = Console.ReadLine();
string[] phrase = new string[phraseInput.Length] ;

bool inputGood = true;

while (inputGood) 
{
    if (phraseInput != null)
    {
        if (phraseInput.Any(char.IsDigit))
        {
            Console.WriteLine("Please enter a phrase with no numbers");
            phraseInput = Console.ReadLine();
        }
        else if (phraseInput.Length < 1)
        {
            Console.WriteLine("Please enter a phrase");
            phraseInput = Console.ReadLine();
        }
        else 
        {
            phraseInput = phraseInput.ToLower();
            phraseInput = Regex.Replace(phraseInput, @"[^\w\d\s]", "");
            phrase = phraseInput.Split(' ');
            break;
        }
    }
}

string[] uniqueWords = new string[] { };
foreach (string word in phrase)
{
    if (uniqueWords.Contains(word) == false)
    {

        Array.Resize(ref uniqueWords, uniqueWords.Length + 1);
        uniqueWords[uniqueWords.Length - 1] = word;
    }
}


Console.WriteLine("Your unique words are:");
foreach (string word in uniqueWords)
{
    Console.WriteLine(word);
}










