using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Manuals
{
    internal class ManualAttachment : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid ManualStepId { get; set; }
        public ManualStep ManualStep { get; set; }
        public string FileLocation { get; set; }
        public FileType FileType { get; set; }
    }
}
