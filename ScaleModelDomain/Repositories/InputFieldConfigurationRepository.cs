using ScaleModelDomain.Converters;
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
        internal static ResponseEnvelope CreateEntity(InputFieldConfigurationDataModel model)
        {
            InputFieldConfiguration entity = model.ConvertToEntity();
            entity.DateCreated = DateTime.Now;
            entity.DateLastModified = DateTime.Now;
            return InputFieldConfigurationManager.Create(entity);
        }

        internal static ResponseEnvelopeWithDataResult<List<InputFieldConfigurationDataModel>> GetEntities()
        {
            List<InputFieldConfiguration> entities = InputFieldConfigurationManager.GetEntities();
            return new ResponseEnvelopeWithDataResult<List<InputFieldConfigurationDataModel>>(entities.ConvertToDataModels());
        }
        internal static ResponseEnvelope UpdateEntity(InputFieldConfigurationDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(string.Format("No model passed as parameter to method {0}", new StackTrace().GetFrame(0).GetMethod().Name));
            }
            InputFieldConfiguration entity = InputFieldConfigurationManager.GetEntityFromGuid(model.Id);
            entity.UpdateFromModel(model);
            entity.DateLastModified = DateTime.Now;
            return InputFieldConfigurationManager.Update();
        }
        internal static ResponseEnvelope DeleteEntity(InputFieldConfigurationDataModel model)
        {
            if(model == null)
            {
                return new ResponseEnvelope(string.Format("No model passed as parameter to method {0}", new StackTrace().GetFrame(0).GetMethod().Name));
            }
            InputFieldConfiguration entity = InputFieldConfigurationManager.GetEntityFromGuid(model.Id);
            return InputFieldConfigurationManager.Delete(entity);
        }

        internal static ResponseEnvelopeWithDataResult<InputFieldConfigurationDataModel> GetEntity(Guid id)
        {
            InputFieldConfiguration entity = InputFieldConfigurationManager.GetEntityFromGuid(id);
            if(entity != null)
            {
                return new ResponseEnvelopeWithDataResult<InputFieldConfigurationDataModel>(entity.ConvertToDataModel());
            }
            throw new NotImplementedException();
        }
    }
}
