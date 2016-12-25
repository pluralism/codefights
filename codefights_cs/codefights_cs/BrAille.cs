using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class BrAille
    {
        public static bool isEmpty(string[] message, int index)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (message[i][j] != 32)
                        return false;
            return true;
        }


        public static bool isValid(string[] message, int index)
        {
            if (message[0][index + 1] == 32 && message[1][index + 1] == 32 && message[2][index + 1] == 32)
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
            string invalid = "[?]", result = "";
            int messageLen, i, longest;
            int[] alphabet = { 1, 12, 14, 145, 15, 124, 1245, 125, 24, 245, 13, 123, 134, 1345, 135, 1234, 12345,
                1235, 234, 2345, 136, 1236, 2456, 1346, 13456, 1356 };

            messageLen = message.Length;
            // If message has less than three lines, it cannot be decrypted and [?] should be returned.
            if (messageLen < 3)
                return invalid;

            /**
             * If message has more than three lines, the exceeding lines should be added to the first three lines 
             * one by one: the first exceeding line should be added to message[0], the next one should be added 
             * to message[1], the following line should be added to message[2], and the next should be added to 
             * message[0] again. The process should continue until message contains exactly three lines.
             */
            for (i = 3; i < messageLen; i++)
                message[i % 3] += message[i];

            // Find the longest message
            longest = message.Max(m => m.Length);
            message = message.Take(3).Select(m => m.PadRight(longest)).ToArray();

            for (i = 0; i < longest; i += 4)
            {
                int tmpNumber = convertToNumber(message, i);
                if(alphabet.Contains(tmpNumber))
                {
                    Console.WriteLine((char)(Array.IndexOf(alphabet, tmpNumber) + 97));
                }
            }

            return "";
        }
    }
}
