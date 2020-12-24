using ScaleModelDomain.DataModels;
using ScaleModelDomain.Managers;
using ScaleModelDomain.Repositories;
using System;
using System.Collections.Generic;

namespace ScaleModelDomain
{
    public static class ScaleModelDomainAdapter
    {
        public static void OnStartup()
        {
            CacheManager.OnStartup();
            ConfigurationManager.InitLocalStorage();
            DatabaseManager.InitContext();
        }

        public static void OnClose()
        {
            DatabaseManager.CloseContext();
        }

        public static ResponseEnvelope CreateInputFieldConfiguration(InputFieldConfigurationDataModel model)
        {
            return InputFieldConfigurationRepository.CreateEntity(model);
        }
        public static ResponseEnvelope DeleteInputFieldConfiguration(InputFieldConfigurationDataModel model)
        {
            return InputFieldConfigurationRepository.DeleteEntity(model);
        }
        public static ResponseEnvelope UpdateInputFieldConfiguration(InputFieldConfigurationDataModel model)
        {
            return InputFieldConfigurationRepository.UpdateEntity(model);
        }
        public static ResponseEnvelopeWithDataResult<List<InputFieldConfigurationDataModel>> GetInputConfigurationDataModels()
        {
            return InputFieldConfigurationRepository.GetEntities();
        }

        public static ResponseEnvelopeWithDataResult<InputFieldConfigurationDataModel> GetInputConfigurationDataModel(Guid id)
        {
            return InputFieldConfigurationRepository.GetEntity(id);
        }

      
    }
}
