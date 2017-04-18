using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Nebiam.Shared.Data
{
    public abstract class SqlDataRecordProvider<T> : Nebiam.Shared.Connection 
        where T : Nebiam.Shared.Data.IDataRecord
    {
        /// ********************************************************************
        /// <summary>
        /// Gets a data-record from the underlying SQL database.
        /// </summary>
        /// ********************************************************************
        protected abstract void GetDataRecord(
            IDataReader dataReader, T dataRecord);


        /// ********************************************************************
        /// <summary>
        /// Selects a data-record from the database using the specified command,
        /// and then maps the fields to the data-record.
        /// </summary>
        /// ********************************************************************
        protected bool SelectDataRecord(T dataRecord, SqlCommand cmd)
        {
            bool isEmpty = true;

            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    isEmpty = false;
                    GetDataRecord(dataReader, dataRecord);
                }
            }
            return !isEmpty;
        }
    }
}