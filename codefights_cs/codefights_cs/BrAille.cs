using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class BrAille
    {
        public static string brAIlle(string[] message)
        {
            string invalid = "[?]", result = "";
            int messageLen;
            int[] alphabet = { 1, 12, 14, 145, 15, 124, 1245, 125, 24, 245, 13, 123, 134, 1345, 135, 1234, 12345,
                1235, 234, 2345, 136, 1236, 2456, 1346, 13456, 1356 };

            messageLen = message.Length;
            // If message has less than three lines, it cannot be decrypted and [?] should be returned.
            if (messageLen < 3)
                return invalid;

            return "";
        }
    }
}
