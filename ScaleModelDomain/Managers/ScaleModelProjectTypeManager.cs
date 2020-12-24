using ScaleModelDomain.Database.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Managers
{
    internal class ScaleModelProjectTypeManager
    {
        internal static ResponseEnvelope Create(ScaleModelProjectType entity)
        {
            return DatabaseManager.InsertEntity(entity);
        }
        internal static List<ScaleModelProjectType> GetEntities()
        {
            return DatabaseManager.ReadEntities<ScaleModelProjectType>().ToList();
        }
        internal static ResponseEnvelope Delete(ScaleModelProjectType entity)
        {
            return DatabaseManager.DeleteEntity(entity);
        }
        internal static ResponseEnvelope Update()
        {
            return DatabaseManager.UpdateEntity();
        }
        internal static ScaleModelProjectType GetEntityFromGuid(Guid id)
        {
            return GetEntities().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
