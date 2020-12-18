using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelProject : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid ScaleModelProjectTypeId { get; set; }
        public ScaleModelProjectType ScaleModelProjectType { get; set; }
        [Required]
        public string ProjectTitle { get; set; }
        public string Content { get; set; }
        public ActivityStatus ProjectStatus { get; set; }
        public List<ScaleModelTask> Tasks { get; set; }
    }
}
