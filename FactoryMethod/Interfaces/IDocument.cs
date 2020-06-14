namespace FactoryMethod
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public interface IDocument
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
