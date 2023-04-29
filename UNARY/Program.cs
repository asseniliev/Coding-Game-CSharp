using System;
using System.Text;
using System.Linq;

namespace UNARY
{
    class Program
    {
        static void Main(string[] args)
        {
            string MESSAGE = Console.ReadLine();

            byte[] bytes = Encoding.ASCII.GetBytes(MESSAGE);

            bytes.Select(b =>
            {
                string trimmedBytes = Convert.ToString(b, 2);
                return (trimmedBytes.Length < 7) ? trimmedBytes.PadLeft(7, '0') : trimmedBytes;

            });
            
            //string binaryMessage = string.Join("", bytes.Select(b => Convert.ToString(b, 2).TrimStart('0')));
            string binaryMessage = string.Join("", bytes.Select(b =>
            {
                string trimmedBytes = Convert.ToString(b, 2);
                return (trimmedBytes.Length < 7) ? trimmedBytes.PadLeft(7, '0') : trimmedBytes;

            }));

            Console.WriteLine(binaryMessage);

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            int currentSymbolNumber = 0;
            int numberOfRepeatingSybols = 1;

            while(currentSymbolNumber < binaryMessage.Length)
            {                
                if (isEndOfSeries(binaryMessage, currentSymbolNumber))
                {
                    string endBlock = (currentSymbolNumber != binaryMessage.Length - 1) ? " " : "";

                    string firstBlock = binaryMessage[currentSymbolNumber] == '0' ? "00" : "0";
                    string secondBlock = new String('0', numberOfRepeatingSybols);
                    Console.Write(firstBlock + " " + secondBlock + endBlock);

                    numberOfRepeatingSybols = 1;
                    currentSymbolNumber++;
                }
                else
                {
                    currentSymbolNumber++;
                    numberOfRepeatingSybols++;
                }
            }
        }

        private static bool isEndOfSeries(string message, int currentSymbolNumber)
        {
            if (currentSymbolNumber == message.Length - 1)
                return true;

            if (message[currentSymbolNumber] != message[currentSymbolNumber + 1])
                return true;

            return false;
        }
    }
}
