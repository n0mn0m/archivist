using System;
using System.IO;

namespace PdfToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the location of the PDF to load.");
            string inputPdf = Console.ReadLine();
            if (File.Exists(inputPdf))
            {
                Console.WriteLine($"Loading {inputPdf}");
                var result = PdfParser.ExtractTextFromPdf(inputPdf);
                result.ForEach(i => Console.Write("{0}\t", i));
            } else {
                Console.WriteLine($"{inputPdf} not found.");
            } 
        }
    }
}