using System;
using System.IO;

namespace StreamWriterAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\aalima5\Desktop\Code C#\file1.txt";
            string targetPath = @"C:\Users\aalima5\Desktop\Code C#\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath); //ler todo o conteudo do arquivo e guardar no vetor

                //Bloco using:
                using (StreamWriter sw = File.AppendText(targetPath))

                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
