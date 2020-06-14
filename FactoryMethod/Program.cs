using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new DocumentManager();

            foreach (var document in manager.Documents)
            {
                Console.WriteLine($"{document.GetType().Name}: {document}");
            }

            Console.ReadLine();
        }
    }

    public class NewsDocument : IDocument
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string ReporterName { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content} - {ReporterName}";
        }
    }

    public class ArticleDocument : IDocument
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorName { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content} - {AuthorName}";
        }
    }

    public class DocumentManager : BaseManager
    {
        public DocumentManager()
        {
            CreateDocuments();
        }

        public override void CreateDocuments()
        {
            Documents = new List<IDocument>() {
                new NewsDocument()
                {
                    Title = "News title 1",
                    Content = "News content 1",
                    ReporterName = "MRP"
                },
                new ArticleDocument()
                {
                    Title = "Article title 1",
                    Content = "Article content 1",
                    AuthorName = "MRP"
                }
            };
        }
    }
}
