using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace WcfExtension.LogCenter.Core
{
    /// <summary>
    /// MongoDB查询类
    /// </summary>
  public  class MongoDBUtil
    {



        //private static string MongonDbConnString = ConfigurationManager.AppSettings["AmsDBConn"];

        private static MongoServer mongo = MongoServer.Create(new MongoUrl(ConfigProvider.Common.MongoConnWcfLog));

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="DbName">数据库名称</param>
        /// <param name="TableName">表名</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderby">排序</param>
        /// <param name="fields">返回字段</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="count">记录总数</param>
        /// <returns>数据列表</returns>
        public static List<T> GetPaged<T>(string DbName, string TableName, BsonDocument where, string[] orderby, BsonDocument fields, int pageIndex, int pageSize, out int count)
        {
            count = 0;
            List<T> list = new List<T>();
            try
            {
                MongoDatabase db = mongo.GetDatabase(DbName);//数据库名字
                if (db == null) throw new ArgumentNullException("db not found.");
                MongoCollection<BsonDocument> categories = db.GetCollection<BsonDocument>(TableName);//表的名字
                count = (int)categories.Count(new QueryComplete(where));//总数
                MongoCursor<T> cursor = categories.FindAs<T>(new QueryComplete(where));
                cursor.SetSkip(((pageIndex - 1) * pageSize));
                cursor.SetLimit(pageSize);
                cursor.SetSortOrder(SortBy.Descending(orderby));
                foreach (T t in cursor)
                {
                    list.Add(t);
                }
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }
            return list;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="DbName">数据库名称</param>
        /// <param name="TableName">表名</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderby">排序</param>
        /// <param name="fields">返回字段</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="count">记录总数</param>
        /// <returns>数据列表</returns>
        public static List<T> GetPaged<T>(string DbName, string TableName, BsonDocument where, string[] orderby, BsonDocument fields, int pageIndex, int pageSize)
        {
            List<T> list = new List<T>();
            try
            {
                MongoDatabase db = mongo.GetDatabase(DbName);//数据库名字
                if (db == null) throw new ArgumentNullException("db not found.");
                MongoCollection<BsonDocument> categories = db.GetCollection<BsonDocument>(TableName);//表的名字
                MongoCursor<T> cursor = categories.FindAs<T>(new QueryComplete(where));
                cursor.SetSkip(((pageIndex - 1) * pageSize));
                cursor.SetLimit(pageSize);
                cursor.SetSortOrder(SortBy.Descending(orderby));
                foreach (T t in cursor)
                {
                    list.Add(t);
                }
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }
            return list;
        }

        public static List<T> GetAll<T>(string DbName, string TableName, BsonDocument where, string[] orderby, BsonDocument fields)
        {
            List<T> list = new List<T>();
            try
            {
                MongoDatabase db = mongo.GetDatabase(DbName);//数据库名字
                if (db == null) throw new ArgumentNullException("db not found.");
                MongoCollection<BsonDocument> categories = db.GetCollection<BsonDocument>(TableName);//表的名字
                MongoCursor<T> cursor = categories.FindAs<T>(new QueryComplete(where));
                //string[] strResult = { "Id" };
                cursor.SetSortOrder(SortBy.Descending(orderby));
                foreach (T t in cursor)
                {
                    list.Add(t);
                }
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }
            return list;
        }

        public static T GetModel<T>(string DbName, string TableName, BsonDocument where)
        {
            try
            {
                MongoDatabase db = mongo.GetDatabase(DbName);//数据库名字
                if (db == null) throw new ArgumentNullException("db not found.");
                MongoCollection<T> categories = db.GetCollection<T>(TableName);//表的名字
                T model = categories.FindOne(new QueryComplete(where));
                return model;
       
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
                return default(T);
            }
        }

    }
}
