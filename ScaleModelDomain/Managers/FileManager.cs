﻿using ScaleModelDomain.Base.Storage;
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

using System.Xml.Serialization;

namespace ScaleModelDomain.Managers
{
    internal static class FileManager
    {
        #region Exists
        internal static bool RootFolderExists()
        {
            return Directory.Exists(GlobalVariables.StorageRootLocation);
        }
        internal static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }
        #endregion

        #region Create files and directories
        internal static ResponseEnvelope CreateFolderStructure()
        {
            try
            {
                Directory.CreateDirectory(GlobalVariables.StorageRootLocation);
                File.Create(GlobalVariables.ConfigLocation).Close();
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }

        internal static ResponseEnvelope CreateDatabaseFile()
        {
            try
            {
                SQLiteConnection.CreateFile(GlobalVariables.DatabaseLocation);
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }

        #endregion






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
            if (string.IsNullOrEmpty(fileLocation))
            {
                return new ResponseEnvelope(new Exception("Parameter 'File location' is empty"));
            }
            if (obj == null)
            {
                return new ResponseEnvelope(new Exception("Parameter 'obj' is empty"));
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
            catch (Exception ex)
            {
                return new ResponseEnvelopeWithDataResult<object>(ex);
            }

        }
        #endregion
    }
}
