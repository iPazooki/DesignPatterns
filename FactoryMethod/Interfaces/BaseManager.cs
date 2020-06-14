using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class BaseManager
    {
        public IList<IDocument> Documents { get; set; }

        //Factory method
        public abstract void CreateDocuments();
    }
}
