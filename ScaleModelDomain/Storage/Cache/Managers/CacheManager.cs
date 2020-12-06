using ScaleModelDomain.Storage.FileSystem.DataModels;
using ScaleModelDomain.Storage.FileSystem.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Storage.Cache.Managers
{
    internal class CacheManager
    {
        internal static void OnStartup()
        {
            //Read config file
            ResponseEnvelopeWithDataResult<ConfigurationModel> callResult = ConfigurationManager.ReadConfigFromFile();
            if(callResult.CallSuccessfull)
            {
                UpdateConfig(callResult.DataResult);
            }

        }


        #region Configuration


        internal static void UpdateConfig(ConfigurationModel config)
        {
            AppCache.Config = config;
        }
        internal static bool HasConfig()
        {
            return AppCache.Config != null;
        }
        #endregion

        //internal static ConfigurationModel GetConfig()
        //{
        //    return AppCache.Config;
        //}


    }
}
