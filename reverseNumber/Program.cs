Console.WriteLine("This is a number reverser. Please enter a number you want to reverse:");
string numberInput = Console.ReadLine();
int numberToReverse = 0;

bool validNumber = false;
while (validNumber == false)
{
    if (!numberInput.All(char.IsNumber))
    {
        Console.WriteLine("Please enter a number with no letters or symbols");
        numberInput = Console.ReadLine();
    }
    else
    {
        numberToReverse = Int32.Parse(numberInput); 
        validNumber = true;
    }
}

bool reversing = true;
int reverse = 0;

while (reversing)
{
    int lastNumber = 0;

    lastNumber = numberToReverse % 10;
    reverse = reverse * 10 + lastNumber;
    numberToReverse = numberToReverse / 10;

    if (numberToReverse == 0)
    {
        reversing = false;
    }
}

Console.WriteLine(reverse);







