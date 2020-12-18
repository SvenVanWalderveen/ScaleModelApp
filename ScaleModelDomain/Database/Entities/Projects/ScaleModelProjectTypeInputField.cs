using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelProjectTypeInputField : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid ScaleModelProjecTypeId { get; set; }
        public ScaleModelProjectType ScaleModelProjectType { get; set; }
        public Guid InputFieldConfigurationId { get; set; }
        public InputFieldConfiguration InputFieldConfiguration { get; set; }
    }
}
