﻿using ScaleModelDomain.Converters;
using ScaleModelDomain.Database.Entities.Projects;
using ScaleModelDomain.DataModels;
using ScaleModelDomain.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Repositories
{
    internal class InputFieldConfigurationRepository
    {
        #region CREATE
        internal static ResponseEnvelope CreateEntity(InputFieldConfigurationDataModel model)
        {
            InputFieldConfiguration entity = model.ConvertToEntity();
            entity.DateCreated = DateTime.Now;
            entity.DateLastModified = DateTime.Now;
            return InputFieldConfigurationManager.Create(entity);
        }
        #endregion

        #region READ
        internal static ResponseEnvelopeWithDataResult<BaseDataModel> GetDataModelByGuid(Guid id)
        {
            return new ResponseEnvelopeWithDataResult<BaseDataModel>()
            {
                DataResult = InputFieldConfigurationManager.GetEntityFromGuid(id).ConvertToDataModel()
            };
        }

        internal static ResponseEnvelopeWithDataResult<BaseDataModel> GetLatestDataModel()
        {
            return new ResponseEnvelopeWithDataResult<BaseDataModel>()
            {
                DataResult = InputFieldConfigurationManager.GetEntities().OrderByDescending(x => x.DateCreated).FirstOrDefault().ConvertToDataModel()
            };
        }
        internal static ResponseEnvelopeWithDataResult<List<BaseDataModel>> GetDataModels()
        {
            return new ResponseEnvelopeWithDataResult<List<BaseDataModel>>()
            {
                DataResult = InputFieldConfigurationManager.GetEntities().ConvertToDataModels().ConvertAll(x => (BaseDataModel)x)
            };
        }
        #endregion

        #region UPDATE
        internal static ResponseEnvelope UpdateEntity(InputFieldConfigurationDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            InputFieldConfiguration entity = InputFieldConfigurationManager.GetEntityFromGuid(model.Id);
            entity.UpdateFromModel(model);
            entity.DateLastModified = DateTime.Now;
            return InputFieldConfigurationManager.Update();
        }
        #endregion

        #region DELETE
        internal static ResponseEnvelope DeleteEntity(InputFieldConfigurationDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            InputFieldConfiguration entity = InputFieldConfigurationManager.GetEntityFromGuid(model.Id);
            return InputFieldConfigurationManager.Delete(entity);
        }
        #endregion
    }
}
