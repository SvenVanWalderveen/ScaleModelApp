using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Base
{
    internal class BaseDbDateTimeEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
    }
}
