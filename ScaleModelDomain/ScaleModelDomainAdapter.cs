using ScaleModelDomain.DataModels;
using ScaleModelDomain.Managers;
using ScaleModelDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;

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


        public static ResponseEnvelope AddDataModelToDb(BaseDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            return (ResponseEnvelope)InvokeMethod(model.GetType(), "CreateEntity", new object[] { model });
        }

        public static ResponseEnvelope UpdateDataModel(BaseDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            return (ResponseEnvelope)InvokeMethod(model.GetType(), "UpdateEntity", new object[] { model });
        }

        public static ResponseEnvelope DeleteDataModelFromDb(BaseDataModel model)
        {
            if (model == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'model' is empty"));
            }
            return (ResponseEnvelope)InvokeMethod(model.GetType(), "DeleteEntity", new object[] { model });
        }
    

        public static ResponseEnvelopeWithDataResult<BaseDataModel> GetDataModelByGuid(Guid id, Type dataModelType)
        {
            return (ResponseEnvelopeWithDataResult<BaseDataModel>)InvokeMethod(dataModelType, "GetDataModelByGuid", new object[] { id });
        }
        
        public static ResponseEnvelopeWithDataResult<BaseDataModel> GetLatestDataModel(Type dataModelType)
        {
            return (ResponseEnvelopeWithDataResult<BaseDataModel>)InvokeMethod(dataModelType, "GetLatestDataModel", null);
        }

        public static ResponseEnvelopeWithDataResult<List<BaseDataModel>> GetDataModels(Type dataModelType)
        {
            return (ResponseEnvelopeWithDataResult<List<BaseDataModel>>)InvokeMethod(dataModelType, "GetDataModels", null);
        }

        private static object? InvokeMethod(Type modelType, string methodName, object[] parameters)
        {
            string entityName = modelType.Name.Replace("DataModel", "");
            string typeName = string.Format("ScaleModelDomain.Repositories.{0}Repository", entityName);
            Type repositoryType = Type.GetType(typeName);
            if (repositoryType == null)
            {
                return new ResponseEnvelope(new Exception("Repository type is unknown"));
            }
            MethodInfo methodInfo = repositoryType.GetMethod(methodName, BindingFlags.Static | BindingFlags.NonPublic);
            if (methodInfo == null)
            {
                return new ResponseEnvelope(new Exception(string.Format("Method '{0}' doesn't exists in repository.", methodName)));
            }
            var classInstance = Activator.CreateInstance(repositoryType);
            return methodInfo.Invoke(classInstance, parameters);
        }
    }
}
