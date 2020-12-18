using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Manuals
{
    internal class ManualStep : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid ManualId { get; set; }
        public Manual Manual { get; set; }
        public int StepNumber { get; set; }
        [Required]
        public string StepTitle { get; set; }
        public string Content { get; set; }
        public List<ManualAttachment> Attachments { get; set; }
    }

}
