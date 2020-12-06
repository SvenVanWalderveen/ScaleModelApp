using ScaleModelDomain.Storage.FileSystem.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Storage.Cache
{
    internal static class AppCache
    {
        public static ConfigurationModel Config { get; internal set; }
    }
}
