using ScaleModelDomain.Base.Storage;
using ScaleModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Managers
{
    internal class CacheManager
    {
        internal static void OnStartup()
        {
            //Read config file
            ResponseEnvelopeWithDataResult<ConfigurationModel> callResult = ConfigurationManager.ReadConfigFromFile();
            if (callResult.CallSuccessfull)
            {
                UpdateConfig(callResult.DataResult);
            }

        }


        #region Configuration


        internal static void UpdateConfig(ConfigurationModel config)
        {
            ApplicationCache.Config = config;
        }
        internal static bool HasConfig()
        {
            return ApplicationCache.Config != null;
        }
        #endregion

        //internal static ConfigurationModel GetConfig()
        //{
        //    return AppCache.Config;
        //}


    }
}
