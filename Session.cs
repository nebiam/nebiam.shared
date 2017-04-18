using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nebiam.Shared
{
    public class Session
    {
        /// *******************************************************************
        /// <summary>
        /// Gets the value in the session with the specified name.
        /// </summary>
        /// *******************************************************************
        protected static void SetSessionValue<T>(
            string sessionName, T sessionValue)
        {
            HttpContext.Current.Session[sessionName] = (object)sessionValue;
        }


        /// *******************************************************************
        /// <summary>
        /// Gets the value of the session variable as a boolean value.
        /// </summary>
        /// *******************************************************************
        protected static bool GetSessionValueAsBoolean(string sessionName)
        {
            return Convert.ToBoolean(GetSessionValue(sessionName));
        }


        /// *******************************************************************
        /// <summary>
        /// Gets the value of the session variable as a date-time value.
        /// </summary>
        /// *******************************************************************
        protected static DateTime GetSessionValueAsDateTime(string sessionName)
        {
            return Convert.ToDateTime(GetSessionValue(sessionName));
        }


        /// *******************************************************************
        /// <summary>
        /// Gets the value of the session variable as an integer value.
        /// </summary>
        /// *******************************************************************
        protected static int GetSessionValueAsInteger(string sessionName)
        {
            return Convert.ToInt32(GetSessionValue(sessionName));
        }


        /// *******************************************************************
        /// <summary>
        /// Gets the value of the session variable as a string value.
        /// </summary>
        /// *******************************************************************
        protected static string GetSessionValueAsString(string sessionName)
        {
            return Convert.ToString(GetSessionValue(sessionName));
        }


        /// *******************************************************************
        /// <summary>
        /// Gets the value in the session with the specified name.
        /// </summary>
        /// *******************************************************************
        protected static object GetSessionValue(string sessionName)
        {
            object result;

            try
            {
                result = HttpContext.Current.Session[sessionName];
            }
            catch
            {
                result = null;
            }
            return result;
        }



    }
}