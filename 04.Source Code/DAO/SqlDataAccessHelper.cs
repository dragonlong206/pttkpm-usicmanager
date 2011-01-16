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
        public static string fileAddress = "ConnectionString.xml";

        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString(fileAddress);
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
        public static DataTable ExecuteQuery(String query)
        {
            return ExecuteQuery(query, null);
        }
        #endregion
        #region ExecuteNoneQuery
        public static int ExecuteNoneQuery(String query, List<OleDbParameter> sqlParams)
        {
            int n = 0;
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

        public static DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "STT";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }
    }
}
