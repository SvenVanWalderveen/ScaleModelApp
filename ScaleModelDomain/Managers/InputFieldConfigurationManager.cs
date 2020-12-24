using ScaleModelDomain.Database.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Managers
{
    internal class InputFieldConfigurationManager
    {
        internal static ResponseEnvelope Create(InputFieldConfiguration entity)
        {
            return DatabaseManager.InsertEntity(entity);
        }
        internal static List<InputFieldConfiguration> GetEntities()
        {
            return DatabaseManager.ReadEntities<InputFieldConfiguration>().ToList();
        }
        internal static ResponseEnvelope Delete(InputFieldConfiguration entity)
        {
            return DatabaseManager.DeleteEntity(entity);
        }
        internal static ResponseEnvelope Update()
        {
            return DatabaseManager.UpdateEntity();
        }
        internal static InputFieldConfiguration GetEntityFromGuid(Guid id)
        {
            return GetEntities().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
