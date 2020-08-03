using System;
using System.IO;
using System.Linq;
using Extractor;

namespace CommandLineInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the location of the PDF to load.");
            var inputPdf = Console.ReadLine();
            if (File.Exists(inputPdf))
            {
                Console.WriteLine($"Loading {inputPdf}");
                var result = new PdfExtractor(inputPdf).ExtractText();
                Console.WriteLine(string.Join("\t", result));
            } else {
                Console.WriteLine($"{inputPdf} not found.");
            } 
        }
    }
}