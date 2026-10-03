string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    string stringEdit;

    string theSentence;

    while (periodLocation != -1)
    {
        theSentence = myString.Remove(periodLocation);
        stringEdit = myString.Substring(periodLocation + 1);
        stringEdit = myString.TrimStart();
        Console.WriteLine(theSentence);
        periodLocation = myString.IndexOf(".");
    }
    theSentence = myString.Trim();
    Console.WriteLine(theSentence);
}