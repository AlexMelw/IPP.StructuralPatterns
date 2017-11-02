namespace BridgeAppliance.Model
{
    using System;
    using Interfaces;

    public class Book : Manuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        #region CONSTRUCTORS

        public Book(IFormatter formatter) : base(formatter) { }

        #endregion

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}