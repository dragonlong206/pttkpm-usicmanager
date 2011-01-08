using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Xml;

namespace DAO
{
    public class SqlDataAccessHelper
    {
        #region ConnectionString

        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString("ConnectionString.xml");
            }
        }

        public static String ReadConnectionString(String strPath)
        {
            try
            {
                XmlDocument docConnectionString = new XmlDocument();
                docConnectionString.Load(strPath);
                XmlElement root = docConnectionString.DocumentElement;
                String strConnectionString = root.InnerText;
                return strConnectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExcuteQuery

        public static DataTable ExcuteQuery(string strCommand, List<OleDbParameter> arrParameters)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();

                try
                {
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = strCommand;

                    if (arrParameters != null)
                    {
                        foreach (OleDbParameter param in arrParameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex1)
                {
                    throw ex1;
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region ExcuteNonQuery

        public static int ExcuteNonQuery(String strCommand, List<OleDbParameter> arrParams)
        {
            int nRecord = 0;

            try
            {
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();

                try
                {
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = strCommand;

                    if (arrParams != null)
                    {
                        foreach (OleDbParameter param in arrParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    nRecord = command.ExecuteNonQuery();
                }
                catch (Exception ex1)
                {
                    throw ex1;
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nRecord;
        }

        #endregion
    }
}
