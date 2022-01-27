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
    public partial class vente : Form
    {
        public String i;
        public vente()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_vente.Text = listView1.SelectedItems[0].Text.ToString();
            date_vente.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            qte_vente.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            pu_achat.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
            pu_vente.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            revenue_vente.Text = listView1.SelectedItems[0].SubItems[5].Text.ToString();
            id_prod.Text = listView1.SelectedItems[0].SubItems[6].Text.ToString();
            id_users.Text = listView1.SelectedItems[0].SubItems[7].Text.ToString();
            id_client.Text = listView1.SelectedItems[0].SubItems[8].Text.ToString();
        }

        private void vente_Load(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getVente();
            listView1.Items.Clear();
            db.fillList(dt, listView1);
            listView1.Refresh();
        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajt_vente_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getVente();
            db.ajouterVente(id_vente.Text, date_vente.Text, qte_vente.Text, pu_achat.Text, pu_vente.Text, revenue_vente.Text, id_prod.Text, id_users.Text, id_client.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void mdf_vente_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getVente();
            db.modifierVente(id_vente.Text, date_vente.Text, qte_vente.Text, pu_achat.Text, pu_vente.Text, revenue_vente.Text, id_prod.Text, id_users.Text, id_client.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void supp_txt_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getVente();
            db.supprimerVente(id_vente.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void vide_vente_Click(object sender, EventArgs e)
        {
            id_vente.Clear();
            qte_vente.Clear();
            pu_achat.Clear();
            pu_vente.Clear();
            revenue_vente.Clear();
            id_prod.Clear();
            id_users.Clear();
            id_client.Clear();
        }
    }
}
