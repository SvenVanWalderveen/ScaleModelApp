using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelPictures : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid? ScaleModelProjectId { get; set; }
        public ScaleModelProject ScaleModelProject { get; set; }
        [Required]
        public string FileLocation { get; set; }
        public string Remark { get; set; }
    }
}
