string[] myArray1 = { "the", "road", "will", "be", "mastered", "by", "walking" };
string[] myArray2 = { "knowledge", "is", "priceless", "baggage", ":=)" };
string[] myArray3 = { "patience", "and", "a", "little", "effort" };

ResultOutput(myArray1);
ResultOutput(myArray2);
ResultOutput(myArray3);

void ResultOutput(string[] array)
{
    int res = CountElements(array);
    string[] newarr = FormNewArray(array, res);
    Console.WriteLine("[" + String.Join(",", array) + "] --> " + "[" + String.Join(",", newarr) + "]");
}

bool CharacterCountCheck(string element)
{
    char[] num = element.ToCharArray();
    if (num.Length > 3) return false;
    return true;
}

int CountElements(string[] arr)
{
    int countElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (CharacterCountCheck(arr[i])) countElement++;
    }
    return countElement;
}

string[] FormNewArray(string[] array, int elemment)
{
    int k = 0;
    string[] newArray = new string[elemment];
    for (int i = 0; i < array.Length; i++)
    {
        if (CharacterCountCheck(array[i]))
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}

