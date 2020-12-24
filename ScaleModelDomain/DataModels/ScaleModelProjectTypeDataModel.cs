using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.DataModels
{
    public class ScaleModelProjectTypeDataModel : BaseDataModel
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public List<ScaleModelProjectTypeInputFieldDataModel> ScaleModelProjectTypeInputFields { get; set; }
    }
}
