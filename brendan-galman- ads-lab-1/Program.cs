using System.Net.Http.Headers;
using System.Runtime;
using System.Security.AccessControl;

List<int> List1 = new() { 1, 2, 3, 4, 5 };
List<int> List2 = new() { 1, 2, 3 };
List<int> List3 = new(){ 1, 1, 9, 1, 1, 1 };

List<List<int>> ListstoInputLists = new List<List<int>>();

ListstoInputLists.Add(List1);
ListstoInputLists.Add(List2);
ListstoInputLists.Add(List3);

List<int> MaxNumbersInLists(List<List<int>> listOfNumLists)
{
    List<int> outputList = new List<int>();

    foreach (List<int> list in listOfNumLists)
    {
        int largestNumber = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > largestNumber)
            {
                largestNumber = list[i];
            }
        }
        outputList.Add(largestNumber);
    }
    return outputList;
}

List<int> output = MaxNumbersInLists(ListstoInputLists);

for (int i = 0; i < output.Count; i++)
{
    Console.WriteLine($"For List{i + 1}, Number {output[i]} was the highest");
}


