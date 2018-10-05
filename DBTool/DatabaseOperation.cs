using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace DBTool
{
    class DatabaseOperation
    {
        #region
        private string databaseConnectionString = string.Empty;

        public string DatabaseConnectionString
        {
            get { return databaseConnectionString; }
            set { databaseConnectionString = value; }
        }

        private OracleConnection conn = new OracleConnection();

        public OracleConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public DatabaseOperation(string databaseConnectionString)
        {
            this.databaseConnectionString = databaseConnectionString;
            conn = new OracleConnection(databaseConnectionString);
        }

        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        public Boolean ConnectionTest()
        {
            bool isCanConn = true;
            try
            {
                Conn.Open();
            }
            catch (Exception)
            {
                isCanConn = false;
            }
            finally
            {
                conn.Close();
            }
            return isCanConn;
        }
    }
}
