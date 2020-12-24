using Microsoft.EntityFrameworkCore;
using ScaleModelDomain.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Managers
{
    public class DatabaseManager
    {
        static ScaleModelDatabaseContext _context;
        #region context
        internal static void InitContext()
        {
            _context = new ScaleModelDatabaseContext();
        }

        internal static void CloseContext()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        internal static ScaleModelDatabaseContext GetContext()
        {
            if(_context == null)
            {
                return new ScaleModelDatabaseContext();
            }
            return _context;
        }
        #endregion

        internal static ResponseEnvelope CreateDatabase()
        {
            ResponseEnvelope callResult = FileManager.CreateDatabaseFile();
            return callResult;
        }

        internal static ResponseEnvelope InsertEntity(object entity)
        {
            try
            {
                var context = GetContext();
                
                context.Add(entity);
                context.SaveChanges();
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }

        internal static ResponseEnvelope DeleteEntity(object entity)
        {
            try
            {
                var context = GetContext();
                context.Remove(entity);
                context.SaveChanges();
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                return new ResponseEnvelope(ex);
            }
        }

        internal static IQueryable<T> ReadEntities<T>() where T : class
        {
            try
            {
                DbSet<T> result;
                result = GetContext().Set<T>();
                return result;
            }
            catch (Exception ex)
            {
                // Invalid type was provided (i.e. table does not exist in database)
                throw new ArgumentException("Invalid Entity", ex);
            }
        }
        internal static ResponseEnvelope UpdateEntity()
        {
            try
            {
                GetContext().SaveChanges();
                return new ResponseEnvelope();
            }
            catch (Exception ex)
            {
                // Invalid type was provided (i.e. table does not exist in database)
                throw new ArgumentException("Invalid Entity", ex);
            }
        }
        internal static IQueryable<T> ReadEntitieByProperty<T>(string propertyName) where T : class
        {
            try
            {
                DbSet<T> result;
                result = GetContext().Set<T>();
                return result;
            }
            catch (Exception ex)
            {
                // Invalid type was provided (i.e. table does not exist in database)
                throw new ArgumentException("Invalid Entity", ex);
            }
        }
    }
}
