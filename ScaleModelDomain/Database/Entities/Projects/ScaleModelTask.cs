using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelTask : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid ScaleModelProjectId { get; set; }
        public ScaleModelProject ScaleModelProject { get; set; }
        [Required]
        public string TaskName { get; set; }
        public double? EstimatedTimeHours { get; set; }
        public double? RemainingTimeHours { get; set; }   
        public ActivityStatus Status { get; set; }
    }
}
