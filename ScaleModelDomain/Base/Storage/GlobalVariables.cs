using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Base.Storage
{
    internal static class GlobalVariables
    {
        internal static string StorageRootLocation
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ScaleModelApp";
            }
        }
        internal static string ConfigLocation
        {
            get
            {
                return StorageRootLocation + @"\Configuration.xml";
            }
        }
        internal static string DatabaseLocation
        {
            get
            {
                return StorageRootLocation + @"\ScaleModelApp.sqlite";
            }
        }
    }
}
