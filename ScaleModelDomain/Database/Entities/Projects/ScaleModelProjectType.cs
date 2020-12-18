using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelProjectType : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public List<ScaleModelProjectTypeInputField> ScaleModelProjectTypeInputFields { get; set; }
    }
}
