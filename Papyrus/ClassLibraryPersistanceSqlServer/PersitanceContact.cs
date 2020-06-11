using ClassLibraryInterfacePersistanceMetier;
using ClassLibraryMetier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSqlServer
{
    public class PersitanceContact : IPersitanceContact
    {
        SqlConnection sqlConnection;

        public PersitanceContact(string _connectionString)
        {
            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = _connectionString;

        }

        public void Open()
        {
            sqlConnection.Open();
        }

        public void Close()
        {
            sqlConnection.Close();
        }

        public bool IsOpen()
        {
            return sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public int AddContact(StructContact contact)
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            SqlParameter pOut = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("CreateContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                pOut = new SqlParameter("@id", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(pOut);

                sqlCommand.Parameters.Add(new SqlParameter("@prue_contact", contact.satisfaction));
                sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pnom_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pville_contact", contact.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@pcp_contact", contact.code_postal));
                sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_contact", contact.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_contact", contact.satisfaction));

                if(sqlCommand.ExecuteNonQuery() == 1)
                {
                    Trace.TraceInformation($"{DateTime.Now} Création du contact {contact.nom}");
                }
                else
                {
                    Trace.TraceError($"{DateTime.Now} Execution échouée de la création du contact {contact.nom}");
                }
                
            }
            catch(Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un contact {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            return (int)pOut.Value;
        }

        public List<int> AddContact(List<StructContact> contacts)
        {
            List<int> maListeDeContact = new List<int>();

            try
            {
                foreach(StructContact contact in contacts)
                {
                    maListeDeContact.Add(this.AddContact(contact));
                }
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un tableau de contact : {e.Message}");
            }

            Trace.Flush();

            return maListeDeContact;
        }

        public bool DeleteContact(StructContact contact)
        {
            bool success = false;

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", contact.id));

                if(sqlCommand.ExecuteNonQuery() == 1)
                {
                    success = true;
                    Trace.TraceInformation($"{DateTime.Now} Suppression du contact {contact.nom}");
                }
                
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la supression du contact {contact.nom} {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            return success;
        }

        public bool UpdateContact(StructContact contact)
        {
            bool success = false;

            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateContact", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", contact.id));
                sqlCommand.Parameters.Add(new SqlParameter("@prue_contact", contact.satisfaction));
                sqlCommand.Parameters.Add(new SqlParameter("@pnum_rue_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pnom_contact", contact.num_rue));
                sqlCommand.Parameters.Add(new SqlParameter("@pville_contact", contact.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@pcp_contact", contact.code_postal));
                sqlCommand.Parameters.Add(new SqlParameter("@ppersonne_contact", contact.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@psatisfaction_contact", contact.satisfaction));

                sqlCommand.ExecuteNonQuery();
                success = true;

                Trace.TraceInformation($"{DateTime.Now} Mise à jour du contact {contact.nom}");
            }
            catch (Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Execution échouée de la mise à jour du contact {contact.nom} {e.Message}");
            }

            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            Trace.Flush();

            return success;
        }

        public StructContact GetContact(int id)
        {
            Contact contact = null;

            sqlConnection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SearchAllContact", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pid_contact", id));

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                bool ok = false;

                while (sqlDataReader.Read())
                {
                    contact = new Contact(sqlDataReader.GetString(3), sqlDataReader.GetString(2), sqlDataReader.GetString(1), sqlDataReader.GetString(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetInt32(7));

                    Trace.TraceInformation($"{DateTime.Now} Accès au contact {id}");

                    ok = true;
                }

                if (!ok)
                {
                    Trace.TraceError($"{DateTime.Now} Tentative d'acces à un contact inexistant : {id}");
                }

                sqlDataReader.Close();

            }
            catch(Exception e)
            {
                Trace.TraceError($"{DateTime.Now} Echec de la tentative d'accès au contact {id} {e.Message}");
            }

            Trace.Flush();

            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            if (contact != null)
            {
                return contact.GetStruct();
            }
            else
            {
                return new StructContact
                {
                    id = -1
                };
            }
        }
    }
}
