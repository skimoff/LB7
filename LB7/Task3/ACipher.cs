using LB7.Interfaces.InterfaceForTask3;
using Microsoft.VisualBasic.CompilerServices;

namespace LB7.Task3;

public class ACipher:ICipher
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
                int newIndex = (index + 1) % Alphabet.Length;
                result += Alphabet[newIndex];
            }
        }
        return result;
    }
    public string decode(string input)
    {
        string result = "";
        foreach (char c in input.ToUpper())
        {
            int index = Alphabet.IndexOf(c);
            if (index == -1)
            {
                result += c;
            }
            else
            {
                int newIndex = (index - 1 + Alphabet.Length) % Alphabet.Length;
                result += Alphabet[newIndex];
            }
        }
        return result;
    }
}