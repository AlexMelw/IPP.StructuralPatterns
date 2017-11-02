namespace AdapterAppliance.Tests
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using Client;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Stubs;

    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }

        [TestMethod]
        public void RenderTwoRowsGivenOleDbDataAdapter()
        {
            var adapter = new SqlDataAdapter();
            var connection =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\slava\Documents\Sample.mdf;Integrated Security=True;Connect Timeout=30");
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Pattern", connection);

            var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(4, lineCount);
        }
    }
}