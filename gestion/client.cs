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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void client_Load(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getClient();
            listView1.Items.Clear();
            db.fillList(dt, listView1);
            listView1.Refresh();
        }

        private void ajt_client_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getClient();
            db.ajouterClient(id_client.Text, nom_client.Text, adresse_client.Text, tele_client.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void mdf_client_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getClient();
            db.modifierClient(id_client.Text, nom_client.Text, adresse_client.Text, tele_client.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void supp_client_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getClient();
            db.supprimerClient(id_client.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void vider_client_Click(object sender, EventArgs e)
        {
            id_client.Clear();
            nom_client.Clear();
            adresse_client.Clear();
            tele_client.Clear();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_client.Text = listView1.SelectedItems[0].Text.ToString();
            nom_client.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            adresse_client.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            tele_client.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
        }
    }
}
