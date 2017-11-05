namespace BridgeAppliance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Formatters;
    using Interfaces;
    using Model;

    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();

            #region Pick a proper formatter

            //var formatter = new StandardFormatter();
            //var formatter = new FancyFormatter();
            var formatter = new BackwardsFormatter();

            #endregion

            #region Initialization

            var faq = new FAQ(formatter);

            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");

            var book = new Book(formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };

            var termPaper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };

            #endregion

            var topSecretArticle = new ClassifiedArticle
            {
                EncryptedText = "c2RhYXNmZGpuZnNrbGpkc2psc2RmbGtqc2Rqb"
            };

            var printable = new object[] { book, topSecretArticle, faq, termPaper };

            documents.AddRange(printable.OfType<Manuscript>());

            foreach (var doc in documents)
            {
                doc.Print();
            }

            Console.ReadKey();
        }
    }
}