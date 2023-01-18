string? stringInput = string.Empty;
string? reversed = null;

bool checkWord = true;
while (checkWord)
{
    if (stringInput == "")
    {
        Console.WriteLine("Please Provide a string");
        stringInput = Console.ReadLine();
    }
    else if (stringInput != null)
    {
        if (stringInput.Any(char.IsNumber))
        {
            Console.WriteLine("Please no numbers or symbols");
            stringInput = Console.ReadLine();
        }
        else 
        {
            char[] chars= stringInput.ToCharArray();
            Array.Reverse(chars);
            reversed = new string(chars);
            checkWord = false;
        }
    }
}

Console.WriteLine(reversed);