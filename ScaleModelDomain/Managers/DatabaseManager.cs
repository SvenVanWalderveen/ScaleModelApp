using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Managers
{
    public class DatabaseManager
    {
        internal static ResponseEnvelope CreateDatabase()
        {
            ResponseEnvelope callResult = FileManager.CreateDatabaseFile();
            return callResult;
        }
    }
}
