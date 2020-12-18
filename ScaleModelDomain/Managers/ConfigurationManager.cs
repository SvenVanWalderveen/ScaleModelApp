using ScaleModelDomain.Base.Storage;
using ScaleModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Managers
{
    internal static class ConfigurationManager
    {
        internal static void InitLocalStorage()
        {
            if (!FileManager.RootFolderExists())
            {
                ResponseEnvelope callResult = FileManager.CreateFolderStructure();
                if (!callResult.CallSuccessfull)
                {
                    return;
                }
                ConfigurationModel model = CreateDefaultConfiguration();
                CacheManager.UpdateConfig(model);
                callResult = FileManager.SaveToXmlFile(GlobalVariables.ConfigLocation, model);
            }
            if (!CacheManager.HasConfig())
            {
                ConfigurationModel model = CreateDefaultConfiguration();
                CacheManager.UpdateConfig(model);
                FileManager.SaveToXmlFile(GlobalVariables.ConfigLocation, model);
            }
            if (!FileManager.FileExists(GlobalVariables.DatabaseLocation))
            {
                DatabaseManager.CreateDatabase();
            }

        }
        internal static ConfigurationModel CreateDefaultConfiguration()
        {
            return new ConfigurationModel().CreateDefault();
        }

        #region read
        internal static ResponseEnvelopeWithDataResult<ConfigurationModel> ReadConfigFromFile()
        {
            var result = FileManager.ReadFromXmlFile(GlobalVariables.ConfigLocation, typeof(ConfigurationModel));
            if (result.CallSuccessfull)
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
