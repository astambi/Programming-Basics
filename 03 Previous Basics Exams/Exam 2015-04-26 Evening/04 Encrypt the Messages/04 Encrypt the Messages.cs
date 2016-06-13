using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encrypt_the_Messages
{
    class _04_Encrypt_the_Messages
    {
        static void Main(string[] args)
        {
            int count = 0;
            string start = "start";
            string end = "end";
            List<string> encryptedMessagesList = new List<string>();

            string input = Console.ReadLine();
            while (input != start && input != start.ToUpper())
                input = Console.ReadLine();

            input = Console.ReadLine();
            while (input != end && input != end.ToUpper())
            {
                if (input != string.Empty)
                {
                    count++;
                    char[] chars = input.Reverse().ToArray();
                    string encryptedMessage = "";

                    foreach (char character in chars)
                    {
                        bool isLetter = char.IsLetter(character);
                        bool isDigit = char.IsDigit(character);
                        bool isSpecialChar = character == ' ' || character == ',' ||
                                             character == '.' || character == '?' ||
                                             character == '!';
                        if (isDigit)
                            encryptedMessage += character;
                        else if (isLetter)
                            encryptedMessage += GetEncryptedLetter(character);
                        else if (isSpecialChar)
                            encryptedMessage += GetEncryptedSpecialChar(character);
                    }
                    encryptedMessagesList.Add(encryptedMessage);
                }
                input = Console.ReadLine();
            }
            if (count > 0)
            {
                Console.WriteLine("Total number of messages: {0}", count);
                Console.WriteLine(string.Join("\n", encryptedMessagesList));
            }
            else Console.WriteLine("No messages sent.");
        }
        static char GetEncryptedSpecialChar(char special)
        {
            Dictionary<char, char> specialChars = new Dictionary<char, char>()
            {
                {' ', '+'},
                {',', '%'},
                {'.', '&'},
                {'?', '#'},
                {'!', '$'},
            };
            foreach (var pair in specialChars)
                if (pair.Key == special) return pair.Value;
            return '@';
        }
        static char GetEncryptedLetter(char letter)
        {
            int encryptedIndex = 0;
            if (char.IsUpper(letter))
                if (letter <= 'M') encryptedIndex = letter - 'A' + 'N';
                else encryptedIndex = letter + 'A' - 'N';
            else // lower
                if (letter <= 'm') encryptedIndex = letter - 'a' + 'n';
            else encryptedIndex = letter + 'a' - 'n';
            return (char)encryptedIndex;
        }
    }
}