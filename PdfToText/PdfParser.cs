using System;
using System.Collections.Generic;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PdfToText
{
    public class PdfParser
    {
        public static List<string> ExtractTextFromPdf(string filePath)
        {
            var pdfReader = new PdfReader(filePath);
            var pdfDoc = new PdfDocument(pdfReader);
            var extractedLines = new List<string>();
            for (var page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                var strategy = new SimpleTextExtractionStrategy();
                extractedLines.Add(PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy));
            }
            pdfDoc.Close();
            pdfReader.Close();
            return extractedLines;
        }  
    }
}