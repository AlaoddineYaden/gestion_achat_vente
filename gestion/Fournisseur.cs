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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void ajt_fourn_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getFournisseur();
            db.ajouterFournisseur(id_fourn.Text, nom_fourn.Text, adresse_fourn.Text, tele_fourn.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getFournisseur();
            listView1.Items.Clear();
            db.fillList(dt, listView1);
            listView1.Refresh();
        }

        private void mdf_fourn_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getFournisseur();
            db.modifierFournisseur(id_fourn.Text, nom_fourn.Text, adresse_fourn.Text, tele_fourn.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void supp_fourn_Click(object sender, EventArgs e)
        {
            dbConn db = new dbConn();
            DataTable dt = db.getFournisseur();
            db.supprimerFournisseur(id_fourn.Text);
            listView1.Items.Clear();
            db.fillList(dt, listView1);
        }

        private void vider_fourn_Click(object sender, EventArgs e)
        {
            id_fourn.Clear();
            nom_fourn.Clear();
            adresse_fourn.Clear();
            tele_fourn.Clear();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_fourn.Text = listView1.SelectedItems[0].Text.ToString();
            nom_fourn.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            adresse_fourn.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            tele_fourn.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
        }
    }
}
