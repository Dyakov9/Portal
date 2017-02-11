﻿using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using Dapper;

namespace TestDataAccess
{
    class ExcelDataAccess
    {
        public static string TestDataFileConnection()
        {
            var fileName = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static UserData GetTestData()
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                var keyName = "test";
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                return value;
            }
        }
    }
}