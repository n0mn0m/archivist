using System.Collections;
using System.Collections.Generic;

namespace Extractor
{
    public interface ITextExtractor<T>
    {
        public ICollection<T> ExtractText();
    }
}