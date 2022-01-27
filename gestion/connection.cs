using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion
{
    public partial class connection : Form
    {
        public String s;
        dbConn db = new dbConn();
        public connection()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DataTable ids = new DataTable();
            if (db.getUser(user.Text, pass.Text))
            {
                
                this.Hide();
                MainForm m = new MainForm();
                m.Show();
            }
            else
            {
                MessageBox.Show("Nom ou mot de pass est incorrecte");
            }
        }
    }
}
