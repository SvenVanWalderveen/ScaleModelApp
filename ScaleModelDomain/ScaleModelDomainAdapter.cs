using ScaleModelDomain.Storage.Cache.Managers;
using ScaleModelDomain.Storage.FileSystem;
using ScaleModelDomain.Storage.FileSystem.Managers;
using System;

namespace ScaleModelDomain
{
    public static class ScaleModelDomainAdapter
    {
        public static void InitLocalStorage()
        {
            CacheManager.OnStartup();

            ConfigurationManager.InitLocalStorage();
        }

        //private static void SaveErrorMessageToCache(Exception ex)
        //{
        //    CacheManager.SaveErrorMessage(ex);
        //}

        //public static bool ResetLocalStorageToDefault()
        //{
        //    try
        //    {
        //        ConfigurationManager.ResetLocalStorageToDefault();
        //        return true;
        //    }
        //    catch(Exception ex)
        //    {
        //        SaveErrorMessageToCache(ex);
        //        return false;
        //    }
        //}

        //public static Exception GetErrorMessage()
        //{
        //    return CacheManager.GetErrorMessage();
        //}
    }
}
