﻿string[] myArray1 = { "the", "road", "will", "be", "mastered", "by", "walking" };
string[] myArray2 = { "knowledge", "is", "priceless", "baggage", ":=)" };
string[] myArray3 = { "patience", "and", "a", "little", "effort" };

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
    string[] newArray = new string[elemment];
    for (int i = 0; i < array.Length; i++)
    {
        int k = 0;
        if(CharacterCountCheck(array[i])) 
        {
            newArray[k] = array[i];
            k++;
        }
        return newArray;
    }

}
