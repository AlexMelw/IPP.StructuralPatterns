namespace AdapterAppliance.Library
{
    using System.Data;
    using System.IO;

    public class DataRenderer
    {
        private readonly IDbDataAdapter _dataAdapter;

        #region CONSTRUCTORS

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        #endregion

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering Data:");
            var myDataSet = new DataSet();

            _dataAdapter.Fill(myDataSet);

            foreach (DataTable table in myDataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write($"{column.ColumnName.PadRight(20)} ");
                }
                writer.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        writer.Write($"{row[i].ToString().PadRight(20)} ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}