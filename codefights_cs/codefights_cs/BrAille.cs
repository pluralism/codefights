using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class BrAille
    {
        public static int[] alphabet = { 1, 12, 14, 145, 15, 124, 1245, 125, 24, 245, 13, 123, 134, 1345, 135, 1234, 12345,
                1235, 234, 2345, 136, 1236, 2456, 1346, 13456, 1356, 3456 };

        public static bool isEmpty(string[] message, int index)
        {
            for (int i = 0; i < 3; i++)
                for (int j = index; j < index + 3; j++)
                    if (message[i][j] != 32)
                        return false;
            return true;
        }


        public static bool isValid(string[] message, int index)
        {
            if (message[0][index + 1] == 32 && message[1][index + 1] == 32 && message[2][index + 1] == 32
                && alphabet.Contains(convertToNumber(message, index)))
                return true;
            return false;
        }


        public static int convertToNumber(string[] message, int index)
        {
            int total = 0, count = 0, currentNumber = 6;

            for(int j = index + 2; j >= index; j -= 2)
                for(int k = 2; k >= 0; k--)
                {
                    if(message[k][j] == '#')
                        total += (int) Math.Pow(10, count++) * currentNumber;
                    currentNumber--;
                }
            return total;
        }

        public static string brAIlle(string[] message)
        {
            string result = "";
            int messageLen, i, longest;
            bool numberMode = false;

            messageLen = message.Length;
            if (messageLen < 3)
                return "[?]";

            for (i = 3; i < messageLen; i++)
                message[i % 3] += message[i];

            longest = message.Max(m => m.Length);
            message = message.Take(3).Select(m => m.PadRight(longest)).ToArray();

            for (i = 0; i < longest; i += 4)
            {
                if (i + 2 >= longest)
                {
                    result += "[?]";
                    break;
                }


                if (!isValid(message, i))
                {
                    // Empty block
                    if (isEmpty(message, i))
                    {
                        result += ' ';
                        continue;
                    }

                    if (result.Length > 0 && result[result.Length - 1] == ']')
                        continue;
                    result += "[?]";
                }
                else
                {
                    if (i > 0 &&
                        (message[0][i - 1] == '#' || message[1][i - 1] == '#' || message[2][i - 1] == '#'))
                    {
                        if (result[result.Length - 1] != ']')
                        {
                            if (!numberMode)
                                result = result.Remove(result.Length - 1, 1) + "[?]";
                            else
                                result += "[?]";
                            continue;
                        }
                        continue;
                    }

                    int tmpNumber = convertToNumber(message, i);

                    if (tmpNumber == 3456)
                    {
                        numberMode ^= true;
                        if (numberMode)
                            continue;
                    }

                    if (numberMode)
                    {
                        int indexNumber = Array.IndexOf(alphabet, tmpNumber);
                        if (indexNumber < 10)
                        {
                            indexNumber = indexNumber == 9 ? 0 : indexNumber + 1;
                            result += indexNumber;
                        }
                        else
                        {
                            result += (char)(Array.IndexOf(alphabet, tmpNumber) + 97); ;
                            numberMode ^= true;
                        }
                    }
                    else result += (char)(Array.IndexOf(alphabet, tmpNumber) + 97);
                }
            }
            return result.Replace(" ", string.Empty);
        }
    }
}
