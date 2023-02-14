string[] myArray1 = { "the", "road", "will", "be", "mastered", "by", "walking" };
string[] myArray2 = { "knowledge", "is", "priceless", "baggage", ":=)" };
string[] myArray3 = { "patience", "and", "a", "little", "effort" };

bool CharacterCountCheck(string element)
{
    char[] num = element.ToCharArray();
    if (num.Length > 3) return false;
    return true;
}

