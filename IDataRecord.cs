using System;
using System.Data;

namespace Nebiam.Shared.Data
{
    public interface IDataRecord
    {
        /// ********************************************************************
        /// <summary>
        /// Gets/Sets the RecordID property.
        /// </summary>
        /// ********************************************************************        
        int RecordID
        {
            get;
            set;
        }
    }
}