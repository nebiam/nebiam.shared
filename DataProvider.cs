using System;
using System.Data;

namespace Nebiam.Shared.Data
{
    public class DataProvider
    {
        // Exceptions.
        private const string EFieldNotFound = "Field {0} not found.";
        protected class DataProviderException : System.ApplicationException
        {
            public DataProviderException(string errorMessage) : base(errorMessage) { }
        }


        /// ********************************************************************
        /// <summary>
        /// Creates the data-provider.
        /// </summary>
        /// ********************************************************************
        protected DataProvider()
            : base()
        {
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a
        /// boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(DataRow dataRow, string fieldName)
        {
            return Convert.ToBoolean(dataRow[fieldName]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a
        /// boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(DataRow dataRow, int fieldNo)
        {
            return Convert.ToBoolean(dataRow[fieldNo]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(
            DataTable dataTable, int rowNo, string fieldName)
        {
            return GetBooleanField(dataTable.Rows[rowNo], fieldName);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(
            DataTable dataTable, int rowNo, int fieldNo)
        {
            return GetBooleanField(dataTable.Rows[rowNo], fieldNo);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as a 
        /// boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(
            IDataReader dataReader, string fieldName)
        {
            return GetBooleanField(dataReader, IndexOf(dataReader, fieldName));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the specified field from the data-reader as a boolean value.
        /// </summary>
        /// ********************************************************************
        protected virtual bool GetBooleanField(IDataReader dataReader, int fieldNo)
        {
            return (Convert.ToString(dataReader.GetValue(fieldNo)) ==
                    "T");
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a date-
        /// time value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(DataRow dataRow, string fieldName)
        {
            return Convert.ToDateTime(dataRow[fieldName]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a date-
        /// time value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(DataRow dataRow, int fieldNo)
        {
            return Convert.ToDateTime(dataRow[fieldNo]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a date-time value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(
            DataTable dataTable, int rowNo, string fieldName)
        {
            return GetDateTimeField(dataTable.Rows[rowNo], fieldName);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a date-time value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(
            DataTable dataTable, int rowNo, int fieldNo)
        {
            return GetDateTimeField(dataTable.Rows[rowNo], fieldNo);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value specified field from the data-reader as a date-time 
        /// value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(
            IDataReader dataReader, string fieldName)
        {
            return GetDateTimeField(dataReader, IndexOf(dataReader, fieldName));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value specified field from the data-reader as a date-time
        /// value.
        /// </summary>
        /// ********************************************************************
        protected virtual DateTime GetDateTimeField(
            IDataReader dataReader, int fieldNo)
        {
            return Convert.ToDateTime(dataReader.GetValue(fieldNo));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a
        /// floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            DataRow dataRow, string fieldName)
        {
            return Convert.ToDouble(dataRow[fieldName]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a
        /// floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            DataRow dataRow, int fieldNo)
        {
            return Convert.ToDouble(dataRow[fieldNo]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            DataTable dataTable, int rowNo, string fieldName)
        {
            return GetFloatField(dataTable.Rows[rowNo], fieldName);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            DataTable dataTable, int rowNo, int fieldNo)
        {
            return GetFloatField(dataTable.Rows[rowNo], fieldNo);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the valaue of the specified field from the data-reader as a 
        /// floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            IDataReader dataReader, string fieldName)
        {
            return GetFloatField(dataReader, IndexOf(dataReader, fieldName));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as a 
        /// floating-point value.
        /// </summary>
        /// ********************************************************************
        protected virtual double GetFloatField(
            IDataReader dataReader, int fieldNo)
        {
            return Convert.ToDouble(dataReader.GetValue(fieldNo));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as an
        /// integer value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            DataRow dataRow, string fieldName)
        {
            return Convert.ToInt32(dataRow[fieldName]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as an
        /// integer value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            DataRow dataRow, int fieldNo)
        {
            return Convert.ToInt32(dataRow[fieldNo]);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as an integer value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            DataTable dataTable, int rowNo, string fieldName)
        {
            return GetIntegerField(dataTable.Rows[rowNo], fieldName);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as an intetger value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            DataTable dataTable, int rowNo, int fieldNo)
        {
            return GetIntegerField(dataTable.Rows[rowNo], fieldNo);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as an 
        /// integer value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            IDataReader dataReader, string fieldName)
        {
            return GetIntegerField(dataReader, IndexOf(dataReader, fieldName));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as an 
        /// integer value.
        /// </summary>
        /// ********************************************************************
        protected virtual int GetIntegerField(
            IDataReader dataReader, int fieldNo)
        {
            return Convert.ToInt32(dataReader.GetValue(fieldNo));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a string
        /// value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            DataRow dataRow, string fieldName)
        {
            return dataRow[fieldName].ToString();
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-row as a string
        /// value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            DataRow dataRow, int fieldNo)
        {
            return dataRow[fieldNo].ToString();
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a string value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            DataTable dataTable, int rowNo, string fieldName)
        {
            return GetStringField(dataTable.Rows[rowNo], fieldName);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the specified row in the 
        /// data-table as a string value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            DataTable dataTable, int rowNo, int fieldNo)
        {
            return GetStringField(dataTable.Rows[rowNo], fieldNo);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as a 
        /// string value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            IDataReader dataReader, string fieldName)
        {
            return GetStringField(dataReader, IndexOf(dataReader, fieldName));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the value of the specified field from the data-reader as a 
        /// string value.
        /// </summary>
        /// ********************************************************************
        protected virtual string GetStringField(
            IDataReader dataReader, int fieldNo)
        {
            return Convert.ToString(dataReader.GetValue(fieldNo));
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the index of the specified field in the data-reader.
        /// </summary>
        /// ********************************************************************
        protected int IndexOf(IDataReader dataReader, string fieldName)
        {
            int index;

            // Find the field.
            try
            {
                index = dataReader.GetOrdinal(fieldName);
            }
            catch
            {
                index = -1;
            }

            // Return the index.
            if (index >= 0)
            {
                return index;
            }
            else
            {
                throw new DataProviderException(
                    String.Format(EFieldNotFound, fieldName));
            }
        }

    }
}