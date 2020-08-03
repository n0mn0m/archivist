using System;
using Xunit;
using Extractor;

namespace TestExtractor
{
    public class TestPdfParsing
    {
        [Fact]
        public void TestSuccessfulParse()
        {
            var result = new PdfExtractor("./assets/EclipsePhase_SecondEdition_QuickStart.pdf").ExtractText();
            Assert.Equal(22, result.Count);
        }
    }
}