using System;
using Xunit;
using PdfToText;

namespace TestPdfToText
{
    public class TestPdfParsing
    {
        [Fact]
        public void TestSuccessfulParse()
        {
            var result = PdfParser.ExtractTextFromPdf("./docs/EclipsePhase_SecondEdition_Glossary.pdf");
            Assert.Equal(4, result.Count);
        }
    }
}