using ScaleModelDomain.Managers;

namespace ScaleModelDomain
{
    public static class ScaleModelDomainAdapter
    {
        public static void InitLocalStorage()
        {
            CacheManager.OnStartup();

            ConfigurationManager.InitLocalStorage();
        }
    }
}
