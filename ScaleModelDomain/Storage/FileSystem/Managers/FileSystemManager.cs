using ScaleModelDomain.Storage.Cache.Managers;
using ScaleModelDomain.Storage.FileSystem.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ScaleModelDomain.Storage.FileSystem.Managers
{
    internal static class FileSystemManager
    {
        internal static bool RootFolderExists()
        {
            return Directory.Exists(GlobalVariables.StorageRootLocation);
        }

        internal static ResponseEnvelope CreateFolderStructure()
        {
            try
            {
                Directory.CreateDirectory(GlobalVariables.StorageRootLocation);
                File.Create(GlobalVariables.ConfigLocation).Close();
                return new ResponseEnvelope();
            }
            catch(Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }





        //internal static void CreateFolderStructure()
        //{
        //    Directory.CreateDirectory(GlobalVariables.StorageRootLocation);
        //    File.Create(GlobalVariables.ConfigLocation).Close();
        //}

        #region XML files
        //internal static void SaveToXmlFile(string fileLocation, object obj)
        //{
        //    if (obj == null || string.IsNullOrEmpty(fileLocation))
        //    {
        //        return;
        //    }
        //    XmlSerializer seralizer = new XmlSerializer(obj.GetType());
        //    TextWriter writer = new StreamWriter(fileLocation);
        //    seralizer.Serialize(writer, obj);
        //    writer.Close();
        //}
        internal static ResponseEnvelope SaveToXmlFile(string fileLocation, object obj)
        {
            if(string.IsNullOrEmpty(fileLocation)) {
                return new ResponseEnvelope(string.Format("No file location passed as parameter to method {0}", new StackTrace().GetFrame(0).GetMethod().Name));
            }
            if (obj == null)
            {
                return new ResponseEnvelope(string.Format("No object passed as parameter to method {0}", new StackTrace().GetFrame(0).GetMethod().Name));
            }
            try
            {
                XmlSerializer seralizer = new XmlSerializer(obj.GetType());
                TextWriter writer = new StreamWriter(fileLocation);
                seralizer.Serialize(writer, obj);
                writer.Close();
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }
        internal static ResponseEnvelopeWithDataResult<object> ReadFromXmlFile(string fileLocation, Type objectType)
        {
            if (string.IsNullOrEmpty(fileLocation))
            {
                return null;
            }
            try
            {
                ResponseEnvelopeWithDataResult<object> result = new ResponseEnvelopeWithDataResult<object>();
                XmlSerializer deserializer = new XmlSerializer(objectType);
                StreamReader reader = new StreamReader(fileLocation);
                result.DataResult = deserializer.Deserialize(reader);
                reader.Close();
                result.CallSuccessfull = true;
                return result;
            }
            catch(Exception ex)
            {
                return new ResponseEnvelopeWithDataResult<object>(ex);
            }
            
        }
        #endregion
    }
}
