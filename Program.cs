using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";


            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }


        }
    }
}
