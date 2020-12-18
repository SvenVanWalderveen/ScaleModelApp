using ScaleModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Base.Storage
{
    internal static class ApplicationCache
    {
        public static ConfigurationModel Config { get; internal set; }
    }
}
