using System;
using System.Collections.Generic;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace Extractor
{
    public class PdfExtractor : ITextExtractor<string>
    {
        private string _inputFile;
        public PdfExtractor(string inputFile)
        {
           _inputFile = inputFile;
        }

        public ICollection<string> ExtractText()
        {
            var pdfReader = new PdfReader(_inputFile);
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