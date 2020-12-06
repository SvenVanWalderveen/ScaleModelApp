using ScaleModelDomain.Storage.Cache.Managers;
using ScaleModelDomain.Storage.FileSystem.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Storage.FileSystem.Managers
{
    internal static class ConfigurationManager
    {
        internal static void InitLocalStorage()
        {
            if (!FileSystemManager.RootFolderExists())
            {
                ResponseEnvelope callResult = FileSystemManager.CreateFolderStructure();
                if(!callResult.CallSuccessfull)
                {
                    return;
                }
                ConfigurationModel model = CreateDefaultConfiguration();
                CacheManager.UpdateConfig(model);
                callResult = FileSystemManager.SaveToXmlFile(GlobalVariables.ConfigLocation, model);
            }
            if (!CacheManager.HasConfig())
            {
                ConfigurationModel model = CreateDefaultConfiguration();
                CacheManager.UpdateConfig(model);
                FileSystemManager.SaveToXmlFile(GlobalVariables.ConfigLocation, model);
            }
            else
            {

            }
        }
        internal static ConfigurationModel CreateDefaultConfiguration()
        {
            return new ConfigurationModel().CreateDefault();
        }

        #region read
        internal static ResponseEnvelopeWithDataResult<ConfigurationModel> ReadConfigFromFile()
        {
            var result = FileSystemManager.ReadFromXmlFile(GlobalVariables.ConfigLocation, typeof(ConfigurationModel));
            if(result.CallSuccessfull)
            {
                return new ResponseEnvelopeWithDataResult<ConfigurationModel>()
                {
                    DataResult = result.DataResult as ConfigurationModel,
                    CallSuccessfull = true
                };
            }
            else
            {
                return new ResponseEnvelopeWithDataResult<ConfigurationModel>(result.Exception);
            }
        }
        #endregion
    }
}
