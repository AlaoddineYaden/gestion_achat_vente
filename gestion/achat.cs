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
    public partial class achat : Form
    {
        public achat()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void achat_Load(object sender, EventArgs e)
        {
            Achat_methods am = new Achat_methods();
            DataTable dt = am.getAchat();
            listView1.Items.Clear();
            am.fillList(dt, listView1);
            listView1.Refresh();
        }

        private void ajt_achat_Click(object sender, EventArgs e)
        {
            Achat_methods am = new Achat_methods();
            DataTable dt = am.getAchat();
            am.ajouterAchat(id_achat.Text, date_achat.Text, qte_achat.Text, id_prod.Text, id_fourn.Text, id_users.Text);
            listView1.Items.Clear();
            am.fillList(dt, listView1);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_achat.Text = listView1.SelectedItems[0].Text.ToString();
            date_achat.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            qte_achat.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            id_prod.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
            id_fourn.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            id_users.Text = listView1.SelectedItems[0].SubItems[5].Text.ToString();
        }

        private void mdf_achat_Click(object sender, EventArgs e)
        {
            Achat_methods am = new Achat_methods();
            DataTable dt = am.getAchat();
            am.modifierAchat(id_achat.Text, date_achat.Text, qte_achat.Text, id_prod.Text, id_fourn.Text, id_users.Text);
            listView1.Items.Clear();
            am.fillList(dt, listView1);
        }

        private void vider_achat_Click(object sender, EventArgs e)
        {
            id_prod.Clear();
            id_achat.Clear();
            qte_achat.Clear();
            id_fourn.Clear();
            id_users.Clear();
        }

        private void supp_achat_Click(object sender, EventArgs e)
        {
            Achat_methods am = new Achat_methods(); ;
            DataTable dt = am.getAchat();
            am.supprimerAchat(id_achat.Text);
            listView1.Items.Clear();
            am.fillList(dt, listView1);
        }
    }
}
