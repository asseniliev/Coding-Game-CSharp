using System;
using System.Collections.Generic;
using System.Text;

namespace MIMETypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string unknownExtension = "UNKNOWN";
            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

            Dictionary<string, string> types = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0]; // file extension
                string MT = inputs[1].ToLower(); // MIME type.
                types.Add(EXT, MT);
            }
            
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine(); // One file name per line.
                if (FNAME.Contains('.'))
                {
                    string[] splitFName = FNAME.Split('.');
                    string extension = splitFName[splitFName.Length - 1].ToLower();
                    if (types.ContainsKey(extension))
                        sb.AppendLine(types[extension]);
                    else
                        sb.AppendLine(unknownExtension);
                }
                else
                    sb.AppendLine(unknownExtension);
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
            Console.WriteLine(sb);
        }
    }
}
