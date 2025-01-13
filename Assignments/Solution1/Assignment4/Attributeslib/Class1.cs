namespace Attributeslib
{
    public class DataTable : Attribute
    {
		private string _TableName;

		public string TableName
        {
			get { return _TableName; }
			set { _TableName = value; }
		}


	}
    public class DataColumn : Attribute
    {
		private bool _KeyColumn;

        private string _ColumnName;

        private string _ColumnType;

        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }
        public bool KeyColumn
        {
			get { return _KeyColumn; }
			set { _KeyColumn = value; }
		}
        public string ColumnType
        {
            get { return _ColumnType; }
            set { _ColumnType = value; }
        }



    }
}
