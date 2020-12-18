using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Manuals
{
    internal class Manual : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string ManualName { get; set; }
        public int TotalSteps { get; set; }
        [Required]
        public ManualCategory Category { get; set; }
        public List<ManualStep> ManualSteps { get; set; }
    }
}
