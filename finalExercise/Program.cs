string[] primaryArray = new string[4] {"hello", "2", "world", ":-)"};
string[] newArray = new string[primaryArray.Length];
void FillArray(string[] primaryArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < primaryArray.Length; i++)
    {
        if (primaryArray[i].Length <=3)
        {
            newArray[count] = primaryArray[i];
            count++;
        }
    }
}
void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    System.Console.WriteLine();
}
FillArray(primaryArray, newArray);
PrintArray(newArray);