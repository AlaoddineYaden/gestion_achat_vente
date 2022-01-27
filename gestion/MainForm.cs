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
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront(); childForm.Show();
        }

        private void produit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new produit(), sender);
        }

        private void achat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new achat(), sender);
        }

        private void vente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new vente(), sender);
        }

        private void fourn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Fournisseur(), sender);
        }

        private void client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new client(), sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                MessageBox.Show("click red x");
            
          

        }

    }
}
