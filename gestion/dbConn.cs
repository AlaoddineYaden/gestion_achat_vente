using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion
{
    class dbConn
    {
        static string chaine = @"Data Source=ALAE\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        int rows;
        public String id;
        public bool getUser(String log, String pass)
        {
            bool isSuccess = false;
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from users where login_users = '" + log + "' and pass_users = '" + pass + "' ;";
                rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                    id = dt.Rows[0].ItemArray[0].ToString();
                    vente v = new vente();
                    v.i = id;
                    //MessageBox.Show(id);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return isSuccess;
        }
       
        public void fillList(DataTable dt, ListView listView1)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
        public DataTable getProduits()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE AfficheProduits;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }

        public bool ajouterProduit(String txt1, String txt2, String txt3, String txt4, String txt5)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE ajouterProduit N'"+ txt1 + "', N'"+txt2+"', N'"+ txt3 + "', N'" + txt4+ "', N'" + txt5 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
   
        public bool modifierProduit(String txt1, String txt2, String txt3, String txt4, String txt5)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE modifierProduit N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "', N'" + txt5 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool supprimerProduit(String txt1)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE supprimerProduit N'" + txt1 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
        public DataTable getFournisseur()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE getFournisseur;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }

        public bool ajouterFournisseur(String txt1, String txt2, String txt3, String txt4)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE ajouterFournisseur N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool modifierFournisseur(String txt1, String txt2, String txt3, String txt4)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE modifierFournisseur N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 +  "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool supprimerFournisseur(String txt1)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE supprimerFournisseur N'" + txt1 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
        public DataTable getVente()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE getVente;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }

        public bool ajouterVente(String txt1, String txt2, String txt3, String txt4, String txt5, String txt6, String txt7, String txt8, String txt9)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE ajouterVente N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "', N'" + txt5 + "', N'" + txt6 + "', N'" + txt7 + "', N'" + txt8 + "', N'" + txt9 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool modifierVente(String txt1, String txt2, String txt3, String txt4, String txt5, String txt6, String txt7, String txt8, String txt9)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE modifierVente N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "', N'" + txt5 + "', N'" + txt6 + "', N'" + txt7 + "', N'" + txt8 + "', N'" + txt9 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool supprimerVente(String txt1)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE supprimerVente N'" + txt1 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
        public DataTable getClient()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE getClient;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }

        public bool ajouterClient(String txt1, String txt2, String txt3, String txt4)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE ajouterClient N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool modifierClient(String txt1, String txt2, String txt3, String txt4)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE modifierClient N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool supprimerClient(String txt1)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE supprimerClient N'" + txt1 + "' ;";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }


    }
}

       

