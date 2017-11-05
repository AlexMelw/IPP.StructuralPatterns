namespace AdapterAppliance
{
    using System;
    using System.Data;

    class HtmlDataAdapter : IDbDataAdapter
    {
        private IHtmlElement _htmlElement;

        public int Fill(DataSet dataSet)
        {
            _htmlElement = new HtmlElement();

            var dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("Tag", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Text", typeof(string)));

            var row = dataTable.NewRow();

            row[0] = _htmlElement.Tag;
            row[1] = _htmlElement.Text;

            dataTable.Rows.Add(row);
            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();

            return dataTable.Rows.Count;

        }

        #region not implemented

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        public MissingMappingAction MissingMappingAction { get; set; }
        public MissingSchemaAction MissingSchemaAction { get; set; }
        public ITableMappingCollection TableMappings { get; }
        public IDbCommand SelectCommand { get; set; }
        public IDbCommand InsertCommand { get; set; }
        public IDbCommand UpdateCommand { get; set; }
        public IDbCommand DeleteCommand { get; set; }

        #endregion
    }

    interface IHtmlElement
    {
        string Tag { get; set; }
        string Text { get; set; }
    }

    class HtmlElement : IHtmlElement
    {
        public string Tag { get; set; } = "h1";
        public string Text { get; set; } = "My web site header";
    }
}