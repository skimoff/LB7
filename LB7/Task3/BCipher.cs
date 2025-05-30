using LB7.Interfaces.InterfaceForTask3;

namespace LB7.Task3;

public class BCipher:ICipher
{
    public const string Alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
    public string encode(string input)
    {
        string result = "";
        foreach (char ch in input.ToUpper())
        {
            int index = Alphabet.IndexOf(ch);
            if (index == -1)
            {
                result += ch;
            }
            else
            {
                int mirrorIndex = Alphabet.Length - 1 - index;
                result += Alphabet[mirrorIndex];
            }
        }
        return result;
    }

    public string decode(string input)
    {
        return encode(input);
    }
}