using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public class PersistanceSQLServer
    {
        SqlConnection sqlConnection;
        string server;
        string bdd;

        public PersistanceSQLServer(string server, string bdd)
        {
            this.server = server;
            this.bdd = bdd;

            this.sqlConnection = new SqlConnection(@"Data Source=" + this.server + "; Initial Catalog=" + this.bdd + "; Integrated Security=True\"providerName = \"System.Data.SqlClient");
        }

        public PersistanceSQLServer(string connectionString)
        {
            this.sqlConnection = new SqlConnection(connectionString);
            this.bdd = this.sqlConnection.Database;
            this.server = this.sqlConnection.DataSource;
        }

        public PersistanceSQLServer()
        {
            this.bdd = this.server = null;
            this.sqlConnection = null;
        }

        public string Connexion()
        {
            string logs = "";
            try
            {
                sqlConnection.Open();
                Trace.TraceInformation(DateTime.Now + " Connection réussie " + sqlConnection.Database);
            }
            catch(Exception e)
            {
                logs = e.Message;
                Trace.TraceError(DateTime.Now + " Tentative de connection échouée : " + bdd + ":" + server);
            }
            Trace.Flush();
            return logs;
        }

        public string Deconnexion()
        {
            string logs = "";
            try
            {
                sqlConnection.Close();
                Trace.TraceInformation(DateTime.Now + " Déconnection réussie " + sqlConnection.Database);
            }
            catch (Exception e)
            {
                logs = e.Message;
                Trace.TraceError(DateTime.Now + " Tentative de déconnection échouée : " + bdd + ":" + server);
            }
            Trace.Flush();
            return logs;
        }

        public string ExecuteNonQuery(Dictionary<string, object> parameters, string storedProcedure)
        {
            string logs = "";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < parameters.Count; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(parameters.Keys.ElementAt(i), parameters.Values.ElementAt(i));
                    sqlCommand.Parameters.Add(sqlParameter);
                }

                sqlCommand.ExecuteNonQuery();

                Trace.TraceInformation($"{DateTime.Now} Execution réussie : {storedProcedure}");
            }
            catch (Exception e)
            {
                Trace.TraceInformation($"{DateTime.Now} Execution échouée : {storedProcedure} {e.Message}");
                logs = e.Message;
            }
            Trace.Flush();
            return logs;
        }

        public ArrayList ExecuteDataReader(Dictionary<string, object> parameters, string storedProcedure)
        {
            ArrayList list = new ArrayList();

            try
            {
                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < parameters.Count; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(parameters.Keys.ElementAt(i), parameters.Values.ElementAt(i));
                    sqlCommand.Parameters.Add(sqlParameter);
                }

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        list.Add(sqlDataReader.GetValue(i));
                    }
                }

                sqlDataReader.Close();

                Trace.TraceInformation($"{DateTime.Now} Execution réussie : {storedProcedure}");
            }
            catch (Exception e)
            {
                Trace.TraceInformation($"{DateTime.Now} Execution échouée : {storedProcedure} {e.Message}");
            }
            Trace.Flush();
            return list;
        }

        public bool IsOpen()
        {
            return this.sqlConnection != null;
        }


    }
}
