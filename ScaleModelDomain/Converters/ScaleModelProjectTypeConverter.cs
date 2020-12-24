using ScaleModelDomain.Database.Entities.Projects;
using ScaleModelDomain.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Converters
{
    public static class ScaleModelProjectTypeConverter
    {
        internal static ScaleModelProjectType ConvertToEntity(this ScaleModelProjectTypeDataModel model)
        {
            return new ScaleModelProjectType()
            {
               Id = model.Id,
               TypeName = model.TypeName
            };
        }
        internal static void UpdateFromModel(this ScaleModelProjectType entity, ScaleModelProjectTypeDataModel model)
        {
            entity.Id = model.Id;
            entity.TypeName = model.TypeName;
        }

        internal static ScaleModelProjectTypeDataModel ConvertToDataModel(this ScaleModelProjectType entity)
        {
            if(entity == null)
            {
                return null;
            }
            return new ScaleModelProjectTypeDataModel()
            {
                Id = entity.Id,
                TypeName = entity.TypeName
            };
        }

        internal static List<ScaleModelProjectTypeDataModel> ConvertToDataModels(this List<ScaleModelProjectType> entities)
        {
            return entities.Select(x => new ScaleModelProjectTypeDataModel()
            {
                Id = x.Id,
                TypeName = x.TypeName
            }).ToList();
        }
    }
}
