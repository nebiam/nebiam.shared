using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Configuration;

namespace Nebiam.Shared
{
    public class Connection : Nebiam.Shared.Data.DataProvider
    {
        // Configuration constants.
        private const string ConnectionStringSetting = "ConnectionString";

        // Declare SqlConnection.
        public SqlConnection myConnection = null;

        /// ********************************************************************
        /// <summary>
        /// Creates an SQL connection.
        /// </summary>
        /// ********************************************************************
        public void CreateConnection(SqlConnection con)
        {
            con = new SqlConnection(ConnectionString);

            this.myConnection = con;
        }

        /// ********************************************************************
        /// <summary>
        /// Checks if the SQL connection has been created, and then opens the 
        /// SQL connection.
        /// </summary>
        /// ********************************************************************
        public void OpenConnection()
        {
            if (this.myConnection == null)
            {
                CreateConnection(myConnection);
            }

            if (this.myConnection.State != ConnectionState.Open)
            {
                this.myConnection.Open();
            }
        }


        /// ********************************************************************
        /// <summary>
        /// Closes the active SQL connection.
        /// </summary>
        /// ********************************************************************
        protected void CloseConnection()
        {
            if (this.myConnection != null && this.myConnection.State != ConnectionState.Closed)
            {
                this.myConnection.Close();
            }
        }


        /// ********************************************************************
        /// <summary>
        /// Creates a new SQL command using the SQL Data-Source's connection.
        /// </summary>
        /// ********************************************************************
        protected SqlCommand CreateCommand(string commandText)
        {
            return new SqlCommand(commandText, this.myConnection);
        }


        /// ********************************************************************
        /// <summary>
        /// Gets the config setting.
        /// </summary>
        /// ********************************************************************
        protected static object GetConfigSetting(string settingName)
        {
            return ConfigurationManager.ConnectionStrings[settingName];
        }

        /// ********************************************************************
        /// <summary>
        /// Sets the config setting to the specified string value.
        /// </summary>
        /// ********************************************************************
        protected static void SetConfigSetting<T>(
            string settingName, T settingValue)
        {
            ConfigurationManager.AppSettings[settingName] = settingValue.ToString();
        }


        /// ********************************************************************
        /// <summary>
        /// Gets/Sets the application's database Connection-String.
        /// </summary>
        /// ********************************************************************
        public static string ConnectionString
        {
            get
            {
                return Convert.ToString(GetConfigSetting(ConnectionStringSetting));
            }
            set
            {
                SetConfigSetting(ConnectionStringSetting, value);
            }
        }



    }
}