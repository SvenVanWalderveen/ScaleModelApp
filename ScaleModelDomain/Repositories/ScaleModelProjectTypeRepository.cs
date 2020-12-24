using ScaleModelDomain.Converters;
using ScaleModelDomain.Database.Entities.Projects;
using ScaleModelDomain.DataModels;
using ScaleModelDomain.Interfaces;
using ScaleModelDomain.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Repositories
{
    internal class ScaleModelProjectTypeRepository
    {
        #region CREATE
        internal static ResponseEnvelope CreateEntity(ScaleModelProjectTypeDataModel model)
        {
            ScaleModelProjectType entity = model.ConvertToEntity();
            entity.DateCreated = DateTime.Now;
            entity.DateLastModified = DateTime.Now;
            return ScaleModelProjectTypeManager.Create(entity);
        }
        #endregion

        #region READ
        internal static ResponseEnvelopeWithDataResult<BaseDataModel> GetDataModelByGuid(Guid id)
        {
            return new ResponseEnvelopeWithDataResult<BaseDataModel>()
            {
                DataResult = ScaleModelProjectTypeManager.GetEntityFromGuid(id).ConvertToDataModel()
            };
        }

        internal static ResponseEnvelopeWithDataResult<BaseDataModel> GetLatestDataModel()
        {
            return new ResponseEnvelopeWithDataResult<BaseDataModel>()
            {
                DataResult = ScaleModelProjectTypeManager.GetEntities().OrderByDescending(x => x.DateCreated).FirstOrDefault().ConvertToDataModel()
            };
        }
        internal static ResponseEnvelopeWithDataResult<List<BaseDataModel>> GetDataModels()
        {
            return new ResponseEnvelopeWithDataResult<List<BaseDataModel>>()
            {
                DataResult = ScaleModelProjectTypeManager.GetEntities().ConvertToDataModels().ConvertAll(x => (BaseDataModel)x)
            };
        }
        #endregion

        #region UPDATE
        internal static ResponseEnvelope UpdateEntity(ScaleModelProjectTypeDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            ScaleModelProjectType entity = ScaleModelProjectTypeManager.GetEntityFromGuid(model.Id);
            entity.UpdateFromModel(model);
            entity.DateLastModified = DateTime.Now;
            return ScaleModelProjectTypeManager.Update();
        }
        #endregion

        #region DELETE
        internal static ResponseEnvelope DeleteEntity(ScaleModelProjectTypeDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            ScaleModelProjectType entity = ScaleModelProjectTypeManager.GetEntityFromGuid(model.Id);
            return ScaleModelProjectTypeManager.Delete(entity);
        }
        #endregion
    }
}
