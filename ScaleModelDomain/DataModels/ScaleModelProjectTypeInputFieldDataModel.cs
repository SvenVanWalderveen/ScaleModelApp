using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.DataModels
{
    public class ScaleModelProjectTypeInputFieldDataModel
    {
        public Guid Id { get; set; }
        public Guid ScaleModelProjecTypeId { get; set; }
       // public ScaleModelProjectType ScaleModelProjectType { get; set; }
        public Guid InputFieldConfigurationId { get; set; }
        public InputFieldConfigurationDataModel InputFieldConfiguration { get; set; }
    }
}
