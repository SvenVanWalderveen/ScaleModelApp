using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class InputFieldConfiguration : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public ControlType ControlType { get; set; }
        public DataType DataType { get; set; }
        [Required]
        public string LabelName { get; set; }
        public string ToolTip { get; set; }
        public bool IsRequired { get; set; }
        public int? MaxLength { get; set; }
        public ValidationRule ValidationRule { get; set; }
        public List<ScaleModelProjectTypeInputField> ScaleModelProjectTypeInputFields { get; set; } 
    }
}