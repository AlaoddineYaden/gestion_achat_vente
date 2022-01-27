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
    public partial class produit : Form
    {
        public produit()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getProduits();
            listView1.Items.Clear();
            db.fillList(dt, listView1);
            listView1.Refresh();
        }

        private void ajt_produit_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getProduits();
            db.ajouterProduit(id_prod.Text, nom_prod.Text, pu_prod.Text, prix_vente.Text, code_barre.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_prod.Text = listView1.SelectedItems[0].Text.ToString();
            nom_prod.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            pu_prod.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            prix_vente.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
            code_barre.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
        }

        private void mdf_produit_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getProduits();
            db.modifierProduit(id_prod.Text, nom_prod.Text, pu_prod.Text, prix_vente.Text, code_barre.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);

        }

        private void supp_produit_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getProduits();
            db.supprimerProduit(id_prod.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void vider_Click(object sender, EventArgs e)
        {
            id_prod.Clear();
            nom_prod.Clear();
            pu_prod.Clear();
            prix_vente.Clear();
            code_barre.Clear();
/*            achat ac = new achat();
            ac.Show();*/
        }
    }
}
