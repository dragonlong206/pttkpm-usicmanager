using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Xml;

namespace DAO
{
    public class SqlDataAccessHelper
    {
        #region ConnectionString
        protected static String connectionString;
        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString("ConnectionString.xml");
            }
        }
        public static String ReadConnectionString(String file)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement root = doc.DocumentElement;
                String connectionString = root.InnerText;
                return connectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        #region ExecuteQuery
        public static DataTable ExecuteQuery(String query, List<OleDbParameter> sqlParams)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection connect = new OleDbConnection(ConnectionString);
                connect.Open();
                try
                {
                    OleDbCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    if (sqlParams != null)
                    {
                        foreach (OleDbParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }

                catch (OleDbException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static DataTable ExecuteQuery(String spName)
        {
            return ExecuteQuery(spName, null);
        }
        #endregion
        #region ExecuteNoneQuery
        public static int ExecuteNoneQuery(String query, List<OleDbParameter> sqlParams)
        {
            int n;
            try
            {
                OleDbConnection connect = new OleDbConnection(ConnectionString);
                connect.Open();
                try
                {
                    OleDbCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    if (sqlParams != null)
                    {
                        foreach (OleDbParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    n = command.ExecuteNonQuery();
                }

                catch (OleDbException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }
        public static int ExecuteNoneQuery(String query)
        {
            return ExecuteNoneQuery(query, null);
        }
        #endregion

    }
}
