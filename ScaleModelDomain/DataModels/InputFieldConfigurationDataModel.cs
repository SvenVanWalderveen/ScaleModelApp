using ScaleModelDomain.Base.Enums;
using ScaleModelDomain.Database.Entities.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.DataModels
{
    public class InputFieldConfigurationDataModel : BaseDataModel
    {
        public Guid Id { get; set; }
        public ControlType ControlType { get; set; }
        public DataType DataType { get; set; }
        [Required]
        public string LabelName { get; set; }
        public string ToolTip { get; set; }
        public bool IsRequired { get; set; }
        public int? MaxLength { get; set; }
        public ValidationRule? ValidationRule { get; set; }
    }
}
