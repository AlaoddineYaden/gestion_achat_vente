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
    class Achat_methods
    {
        static string chaine = @"Data Source=ALAE\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public DataTable getAchat()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE getAchat ;";
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

        public bool ajouterAchat(String txt1, String txt2, String txt3, String txt4, String txt5, String txt6)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE ajouterAchat N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "', N'" + txt5 + "', N'" + txt6 + "' ;";
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
                Console.WriteLine(ex);
                Console.Error.WriteLine(ex);
            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }

        public bool modifierAchat(String txt1, String txt2, String txt3, String txt4, String txt5, String txt6)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE modifierAchat N'" + txt1 + "', N'" + txt2 + "', N'" + txt3 + "', N'" + txt4 + "', N'" + txt5 + "', N'" + txt6 + "' ;";
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

        public bool supprimerAchat(String txt1)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "EXECUTE supprimerAchat N'" + txt1 + "' ;";
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
