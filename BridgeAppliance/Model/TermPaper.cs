namespace BridgeAppliance.Model
{
    using System;
    using Interfaces;

    public class TermPaper : Manuscript
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        #region CONSTRUCTORS

        public TermPaper(IFormatter formatter) : base(formatter) { }

        #endregion

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Class", Class));
            Console.WriteLine(formatter.Format("Student", Student));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine(formatter.Format("References", References));
            Console.WriteLine();
        }
    }
}