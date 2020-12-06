using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScaleModelDomain.Storage.FileSystem.DataModels
{
    [XmlRoot("ScaleModelConfig")]
    public class ConfigurationModel
    {

        internal ConfigurationModel CreateDefault()
        {
            return this;
        }
    }
}
