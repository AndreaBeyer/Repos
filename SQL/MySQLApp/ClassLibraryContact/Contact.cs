using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security;

namespace ClassLibraryContact
{
    public static class Contact
    {
        public static bool Create(string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction, SqlConnection sqlConnection)
        {
            bool success = false;
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                SqlDataReader sqlDataReader;
                int id = 0;

                sqlCommand.CommandText = "SELECT MAX(id_contact) FROM Contact";

                sqlDataReader = sqlCommand.ExecuteReader();
                bool ok = sqlDataReader.Read();
                if (ok)
                {
                    id = sqlDataReader.GetInt32(0) + 1;
                }
                else
                {
                    id = 1;
                }
                sqlDataReader.Close();

                SqlCommand sqlCommand1 = new SqlCommand();
                sqlCommand1.Connection = sqlConnection;

                sqlCommand1.CommandType = CommandType.StoredProcedure;

                sqlCommand1.CommandText = "CreateContact";

                SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                SqlParameter pnumRueFournisseur = new SqlParameter("@pnum_rue_contact", SqlDbType.NVarChar);
                SqlParameter pRueFournisseur = new SqlParameter("@prue_contact", SqlDbType.VarChar);
                SqlParameter pnom_contact = new SqlParameter("@pnom_contact", SqlDbType.VarChar);
                SqlParameter pville_contact = new SqlParameter("@pville_contact", SqlDbType.VarChar);
                SqlParameter pcp_contact = new SqlParameter("@pcp_contact", SqlDbType.NVarChar);
                SqlParameter ppersonne_contact = new SqlParameter("@ppersonne_contact", SqlDbType.NVarChar);
                SqlParameter psatisfaction_contact = new SqlParameter("@psatisfaction_contact", SqlDbType.Int);

                pCodeFournisseur.Value = id;
                pnumRueFournisseur.Value = num_rue;
                pnom_contact.Value = nom;
                pville_contact.Value = ville;
                pcp_contact.Value = code_postal;
                ppersonne_contact.Value = personne_contact;
                psatisfaction_contact.Value = satisfaction;
                pRueFournisseur.Value = rue;

                sqlCommand1.Parameters.Add(pCodeFournisseur);
                sqlCommand1.Parameters.Add(pnumRueFournisseur);
                sqlCommand1.Parameters.Add(pnom_contact);
                sqlCommand1.Parameters.Add(pville_contact);
                sqlCommand1.Parameters.Add(pcp_contact);
                sqlCommand1.Parameters.Add(ppersonne_contact);
                sqlCommand1.Parameters.Add(psatisfaction_contact);
                sqlCommand1.Parameters.Add(pRueFournisseur);

                sqlCommand1.ExecuteNonQuery();
                success = true;
                Trace.TraceInformation(DateTime.Now + " Création du contact numéro " + id);
            }
            catch(Exception e)
            {
                Trace.TraceError(DateTime.Now + " Tentative de creation d'un contact échouée " + e.Message);
            }
            finally
            {
                Trace.Flush();
            }
            return success;
        }

        public static bool Update(string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction, SqlConnection sqlConnection, int id)
        {
            bool success = false;
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.CommandText = "UpdateContact";

                SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                SqlParameter pnumRueFournisseur = new SqlParameter("@pnum_rue_contact", SqlDbType.NVarChar);
                SqlParameter pRueFournisseur = new SqlParameter("@prue_contact", SqlDbType.VarChar);
                SqlParameter pnom_contact = new SqlParameter("@pnom_contact", SqlDbType.VarChar);
                SqlParameter pville_contact = new SqlParameter("@pville_contact", SqlDbType.VarChar);
                SqlParameter pcp_contact = new SqlParameter("@pcp_contact", SqlDbType.NVarChar);
                SqlParameter ppersonne_contact = new SqlParameter("@ppersonne_contact", SqlDbType.NVarChar);
                SqlParameter psatisfaction_contact = new SqlParameter("@psatisfaction_contact", SqlDbType.Int);

                pCodeFournisseur.Value = id;
                pnumRueFournisseur.Value = num_rue;
                pnom_contact.Value = nom;
                pville_contact.Value = ville;
                pcp_contact.Value = code_postal;
                ppersonne_contact.Value = personne_contact;
                psatisfaction_contact.Value = satisfaction;
                pRueFournisseur.Value = rue;

                sqlCommand.Parameters.Add(pCodeFournisseur);
                sqlCommand.Parameters.Add(pnumRueFournisseur);
                sqlCommand.Parameters.Add(pnom_contact);
                sqlCommand.Parameters.Add(pville_contact);
                sqlCommand.Parameters.Add(pcp_contact);
                sqlCommand.Parameters.Add(ppersonne_contact);
                sqlCommand.Parameters.Add(psatisfaction_contact);
                sqlCommand.Parameters.Add(pRueFournisseur);

                sqlCommand.ExecuteNonQuery();
                success = true;
                Trace.TraceInformation(DateTime.Now + " Mise à jour du contact numéro " + id);
            }
            catch(Exception e)
            {
                Trace.TraceError(DateTime.Now + $" Tentative de mise à jour du contact {id} échouée " + e.Message);
            }
            finally
            {
                Trace.Flush();
            }
            return success;
        }

        public static bool Supress(int id, SqlConnection bdd)
        {
            bool success = false;

            SqlCommand sqlCommand, sqlCommand1, sqlCommand2, sqlCommand3, sqlCommand4, sqlCommand5;
            SqlParameter pCodeFournisseur, pCodeCommande;


            try
            {
                pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                pCodeFournisseur.Value = id;

                sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection = bdd;
                sqlCommand2.CommandText = "DELETE FROM VENTE WHERE id_contact = @pid_contact";
                sqlCommand2.Parameters.Add(pCodeFournisseur);

                sqlCommand2.ExecuteNonQuery();

                sqlCommand2.Parameters.Clear();

                pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                pCodeFournisseur.Value = id;

                sqlCommand4 = new SqlCommand();
                sqlCommand4.Connection = bdd;
                sqlCommand4.CommandText = "Select id_commande FROM COMMANDE WHERE id_contact = @pid_contact";
                sqlCommand4.Parameters.Add(pCodeFournisseur);

                SqlDataReader sqlDataReader = sqlCommand4.ExecuteReader();

                sqlCommand4.Parameters.Clear();


                int i = 0;

                List<int> myList = new List<int>();

                while (sqlDataReader.Read())
                {
                    myList.Add(sqlDataReader.GetInt32(i));
                    i++;
                }
                sqlDataReader.Close();

                foreach (int id_comm in myList)
                {
                    pCodeFournisseur = new SqlParameter("@pid_comm", SqlDbType.Int);
                    pCodeFournisseur.Value = id_comm;

                    sqlCommand5 = new SqlCommand();
                    sqlCommand5.Connection = bdd;
                    sqlCommand5.CommandText = "DELETE FROM Ligne_commande WHERE id_commande = @pid_comm";
                    sqlCommand5.Parameters.Add(pCodeFournisseur);

                    sqlCommand5.ExecuteNonQuery();
                    sqlCommand5.Parameters.Clear();
                }

                pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                pCodeFournisseur.Value = id;

                sqlCommand = new SqlCommand();
                sqlCommand.Connection = bdd;
                sqlCommand.CommandText = "DELETE FROM COMMANDE WHERE id_contact = @pid_contact";
                sqlCommand.Parameters.Add(pCodeFournisseur);

                int nb = sqlCommand.ExecuteNonQuery();

                sqlCommand.Parameters.Clear();

                pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);
                pCodeFournisseur.Value = id;

                sqlCommand1 = new SqlCommand();
                sqlCommand1.Connection = bdd;
                sqlCommand1.CommandText = "DELETE FROM CONTACT WHERE id_contact = @pid_contact";
                sqlCommand1.Parameters.Add(pCodeFournisseur);

                int nb1 = sqlCommand1.ExecuteNonQuery();
                sqlCommand1.Parameters.Clear();

                pCodeCommande = new SqlParameter("@pid_commande", SqlDbType.Int);
                pCodeCommande.Value = id;

                sqlCommand3 = new SqlCommand();
                sqlCommand3.Connection = bdd;
                sqlCommand3.CommandText = "DELETE FROM ligne_commande WHERE id_commande = @pid_commande";
                sqlCommand3.Parameters.Add(pCodeCommande);

                int nb4 = sqlCommand3.ExecuteNonQuery();
                sqlCommand3.Parameters.Clear();
                success = true;
            }
            catch(Exception e)
            {
                Trace.TraceError(DateTime.Now + " Echec de la supression du contact " + id + " " + e.Message);
            }

            return success;
        }
    }
}
