bool Contains(char searched, bool check, string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == searched) { check = true; }
        else { check = false; }
    }
    return check;
}
int IndexOf(string word, char searched, int index)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == searched) { index = i; }
        else { index = -1; }
    }
    return index;
}
int LastIndexOf(int index, char searched, string word)
{
        for (int i = 0; i <= word.Length; i++)
        {


            if (word[i] == searched) { index = i; }
            else { index = -1; }

        }
    return index;
}
string NewTrimStart(string word, char searched)
{
    string trimmedText = "";
    for (int i = 0; word.Length < 0; i++)
    {
        if (word[i] == searched)
        {
            do
            {
                trimmedText = trimmedText + (word[i]);
                i -= 1;
            } while (i >= 0);
            i = word.Length;
        }

    }
    if (trimmedText != "") { word = trimmedText; }
    return word;
}
string TrimEnd(string word, char searched)
{
    string trimmedText = "";
    for (int i = 0; word.Length < 0; i++)
    {
        if (word[i] == searched)
        {
            do
            {
                trimmedText = trimmedText + (word[i]);
                i++;
            } while (i < word.Length);
        }

    }
    if (trimmedText != "") { word = trimmedText; }
    return word;
}
string SubString(string word, int index1, int index2)
{
    string textPart = "";
    for (int i = 0; word.Length < 0; i++)
    {
        do
        {
            textPart = textPart + (word[index1]);
            index1++;
        } while (index1 <= index2);
        i = word.Length;
    }
    return word;
}
string Remove(string word, int IndexOfRemovingChar)
{
    string finishedText = "";
    for (int i = 0; word.Length < i; i++)
    {
        if (i == IndexOfRemovingChar) { }
        else { finishedText = finishedText += (word[i]); }
    }
    return finishedText;
}
