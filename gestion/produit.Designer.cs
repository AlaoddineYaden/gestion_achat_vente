
namespace gestion
{
    partial class produit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_prod_txt = new Guna.UI.WinForms.GunaLabel();
            this.id_prod = new Guna.UI.WinForms.GunaLineTextBox();
            this.nom_prod = new Guna.UI.WinForms.GunaLineTextBox();
            this.nom_prod_txt = new Guna.UI.WinForms.GunaLabel();
            this.pu_prod = new Guna.UI.WinForms.GunaLineTextBox();
            this.pu_prod_txt = new Guna.UI.WinForms.GunaLabel();
            this.prix_vente = new Guna.UI.WinForms.GunaLineTextBox();
            this.prix_vente_txt = new Guna.UI.WinForms.GunaLabel();
            this.code_barre = new Guna.UI.WinForms.GunaLineTextBox();
            this.code_barre_txt = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ajt_produit = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.mdf_produit = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.supp_produit = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.vider = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.SuspendLayout();
            // 
            // id_prod_txt
            // 
            this.id_prod_txt.AutoSize = true;
            this.id_prod_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_prod_txt.Location = new System.Drawing.Point(97, 43);
            this.id_prod_txt.Name = "id_prod_txt";
            this.id_prod_txt.Size = new System.Drawing.Size(75, 25);
            this.id_prod_txt.TabIndex = 3;
            this.id_prod_txt.Text = "id_prod";
            // 
            // id_prod
            // 
            this.id_prod.BackColor = System.Drawing.Color.White;
            this.id_prod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_prod.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.id_prod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id_prod.LineColor = System.Drawing.Color.Gainsboro;
            this.id_prod.Location = new System.Drawing.Point(245, 43);
            this.id_prod.Name = "id_prod";
            this.id_prod.PasswordChar = '\0';
            this.id_prod.SelectedText = "";
            this.id_prod.Size = new System.Drawing.Size(263, 34);
            this.id_prod.TabIndex = 4;
            this.id_prod.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // nom_prod
            // 
            this.nom_prod.BackColor = System.Drawing.Color.White;
            this.nom_prod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_prod.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nom_prod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_prod.LineColor = System.Drawing.Color.Gainsboro;
            this.nom_prod.Location = new System.Drawing.Point(245, 95);
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.PasswordChar = '\0';
            this.nom_prod.SelectedText = "";
            this.nom_prod.Size = new System.Drawing.Size(263, 34);
            this.nom_prod.TabIndex = 6;
            // 
            // nom_prod_txt
            // 
            this.nom_prod_txt.AutoSize = true;
            this.nom_prod_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_prod_txt.Location = new System.Drawing.Point(97, 95);
            this.nom_prod_txt.Name = "nom_prod_txt";
            this.nom_prod_txt.Size = new System.Drawing.Size(118, 25);
            this.nom_prod_txt.TabIndex = 5;
            this.nom_prod_txt.Text = "nom produit";
            // 
            // pu_prod
            // 
            this.pu_prod.BackColor = System.Drawing.Color.White;
            this.pu_prod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pu_prod.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pu_prod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pu_prod.LineColor = System.Drawing.Color.Gainsboro;
            this.pu_prod.Location = new System.Drawing.Point(245, 148);
            this.pu_prod.Name = "pu_prod";
            this.pu_prod.PasswordChar = '\0';
            this.pu_prod.SelectedText = "";
            this.pu_prod.Size = new System.Drawing.Size(219, 34);
            this.pu_prod.TabIndex = 8;
            // 
            // pu_prod_txt
            // 
            this.pu_prod_txt.AutoSize = true;
            this.pu_prod_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pu_prod_txt.Location = new System.Drawing.Point(97, 148);
            this.pu_prod_txt.Name = "pu_prod_txt";
            this.pu_prod_txt.Size = new System.Drawing.Size(116, 25);
            this.pu_prod_txt.TabIndex = 7;
            this.pu_prod_txt.Text = "prix unitaire";
            // 
            // prix_vente
            // 
            this.prix_vente.BackColor = System.Drawing.Color.White;
            this.prix_vente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_vente.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_vente.LineColor = System.Drawing.Color.Gainsboro;
            this.prix_vente.Location = new System.Drawing.Point(245, 199);
            this.prix_vente.Name = "prix_vente";
            this.prix_vente.PasswordChar = '\0';
            this.prix_vente.SelectedText = "";
            this.prix_vente.Size = new System.Drawing.Size(219, 34);
            this.prix_vente.TabIndex = 10;
            // 
            // prix_vente_txt
            // 
            this.prix_vente_txt.AutoSize = true;
            this.prix_vente_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_vente_txt.Location = new System.Drawing.Point(97, 199);
            this.prix_vente_txt.Name = "prix_vente_txt";
            this.prix_vente_txt.Size = new System.Drawing.Size(98, 25);
            this.prix_vente_txt.TabIndex = 9;
            this.prix_vente_txt.Text = "prix vente";
            // 
            // code_barre
            // 
            this.code_barre.BackColor = System.Drawing.Color.White;
            this.code_barre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_barre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.code_barre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.code_barre.LineColor = System.Drawing.Color.Gainsboro;
            this.code_barre.Location = new System.Drawing.Point(245, 260);
            this.code_barre.Name = "code_barre";
            this.code_barre.PasswordChar = '\0';
            this.code_barre.SelectedText = "";
            this.code_barre.Size = new System.Drawing.Size(263, 34);
            this.code_barre.TabIndex = 12;
            // 
            // code_barre_txt
            // 
            this.code_barre_txt.AutoSize = true;
            this.code_barre_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_barre_txt.Location = new System.Drawing.Point(97, 260);
            this.code_barre_txt.Name = "code_barre_txt";
            this.code_barre_txt.Size = new System.Drawing.Size(103, 25);
            this.code_barre_txt.TabIndex = 11;
            this.code_barre_txt.Text = "code barre";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(470, 148);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 25);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "DH";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(470, 199);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(38, 25);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "DH";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 352);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(921, 273);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id_prod";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nom_produit";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "prix_unitaire_produit";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "prix_vente";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "code_barre";
            this.columnHeader5.Width = 122;
            // 
            // ajt_produit
            // 
            this.ajt_produit.AnimationHoverSpeed = 0.07F;
            this.ajt_produit.AnimationSpeed = 0.03F;
            this.ajt_produit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ajt_produit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ajt_produit.BorderColor = System.Drawing.Color.Black;
            this.ajt_produit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ajt_produit.FocusedColor = System.Drawing.Color.Empty;
            this.ajt_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ajt_produit.ForeColor = System.Drawing.Color.White;
            this.ajt_produit.Image = null;
            this.ajt_produit.ImageSize = new System.Drawing.Size(52, 52);
            this.ajt_produit.Location = new System.Drawing.Point(673, 43);
            this.ajt_produit.Name = "ajt_produit";
            this.ajt_produit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.ajt_produit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ajt_produit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ajt_produit.OnHoverForeColor = System.Drawing.Color.White;
            this.ajt_produit.OnHoverImage = null;
            this.ajt_produit.OnPressedColor = System.Drawing.Color.Black;
            this.ajt_produit.Size = new System.Drawing.Size(100, 95);
            this.ajt_produit.TabIndex = 20;
            this.ajt_produit.Text = "Ajouter";
            this.ajt_produit.Click += new System.EventHandler(this.ajt_produit_Click);
            // 
            // mdf_produit
            // 
            this.mdf_produit.AnimationHoverSpeed = 0.07F;
            this.mdf_produit.AnimationSpeed = 0.03F;
            this.mdf_produit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.mdf_produit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.mdf_produit.BorderColor = System.Drawing.Color.Black;
            this.mdf_produit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mdf_produit.FocusedColor = System.Drawing.Color.Empty;
            this.mdf_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mdf_produit.ForeColor = System.Drawing.Color.White;
            this.mdf_produit.Image = null;
            this.mdf_produit.ImageSize = new System.Drawing.Size(52, 52);
            this.mdf_produit.Location = new System.Drawing.Point(815, 43);
            this.mdf_produit.Name = "mdf_produit";
            this.mdf_produit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.mdf_produit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.mdf_produit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.mdf_produit.OnHoverForeColor = System.Drawing.Color.White;
            this.mdf_produit.OnHoverImage = null;
            this.mdf_produit.OnPressedColor = System.Drawing.Color.Black;
            this.mdf_produit.Size = new System.Drawing.Size(100, 95);
            this.mdf_produit.TabIndex = 21;
            this.mdf_produit.Text = "Modifier";
            this.mdf_produit.Click += new System.EventHandler(this.mdf_produit_Click);
            // 
            // supp_produit
            // 
            this.supp_produit.AnimationHoverSpeed = 0.07F;
            this.supp_produit.AnimationSpeed = 0.03F;
            this.supp_produit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.supp_produit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.supp_produit.BorderColor = System.Drawing.Color.Black;
            this.supp_produit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.supp_produit.FocusedColor = System.Drawing.Color.Empty;
            this.supp_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supp_produit.ForeColor = System.Drawing.Color.White;
            this.supp_produit.Image = null;
            this.supp_produit.ImageSize = new System.Drawing.Size(52, 52);
            this.supp_produit.Location = new System.Drawing.Point(673, 174);
            this.supp_produit.Name = "supp_produit";
            this.supp_produit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.supp_produit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.supp_produit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.supp_produit.OnHoverForeColor = System.Drawing.Color.White;
            this.supp_produit.OnHoverImage = null;
            this.supp_produit.OnPressedColor = System.Drawing.Color.Black;
            this.supp_produit.Size = new System.Drawing.Size(100, 95);
            this.supp_produit.TabIndex = 22;
            this.supp_produit.Text = "Supprimer";
            this.supp_produit.Click += new System.EventHandler(this.supp_produit_Click);
            // 
            // vider
            // 
            this.vider.AnimationHoverSpeed = 0.07F;
            this.vider.AnimationSpeed = 0.03F;
            this.vider.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.vider.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.vider.BorderColor = System.Drawing.Color.Black;
            this.vider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.vider.FocusedColor = System.Drawing.Color.Empty;
            this.vider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vider.ForeColor = System.Drawing.Color.White;
            this.vider.Image = null;
            this.vider.ImageSize = new System.Drawing.Size(52, 52);
            this.vider.Location = new System.Drawing.Point(815, 174);
            this.vider.Name = "vider";
            this.vider.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.vider.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.vider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.vider.OnHoverForeColor = System.Drawing.Color.White;
            this.vider.OnHoverImage = null;
            this.vider.OnPressedColor = System.Drawing.Color.Black;
            this.vider.Size = new System.Drawing.Size(100, 95);
            this.vider.TabIndex = 23;
            this.vider.Text = "Vider";
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1045, 656);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.supp_produit);
            this.Controls.Add(this.mdf_produit);
            this.Controls.Add(this.ajt_produit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.code_barre);
            this.Controls.Add(this.code_barre_txt);
            this.Controls.Add(this.prix_vente);
            this.Controls.Add(this.prix_vente_txt);
            this.Controls.Add(this.pu_prod);
            this.Controls.Add(this.pu_prod_txt);
            this.Controls.Add(this.nom_prod);
            this.Controls.Add(this.nom_prod_txt);
            this.Controls.Add(this.id_prod);
            this.Controls.Add(this.id_prod_txt);
            this.Name = "produit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel id_prod_txt;
        private Guna.UI.WinForms.GunaLineTextBox id_prod;
        private Guna.UI.WinForms.GunaLineTextBox nom_prod;
        private Guna.UI.WinForms.GunaLabel nom_prod_txt;
        private Guna.UI.WinForms.GunaLineTextBox pu_prod;
        private Guna.UI.WinForms.GunaLabel pu_prod_txt;
        private Guna.UI.WinForms.GunaLineTextBox prix_vente;
        private Guna.UI.WinForms.GunaLabel prix_vente_txt;
        private Guna.UI.WinForms.GunaLineTextBox code_barre;
        private Guna.UI.WinForms.GunaLabel code_barre_txt;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI.WinForms.GunaGradientCircleButton ajt_produit;
        private Guna.UI.WinForms.GunaGradientCircleButton mdf_produit;
        private Guna.UI.WinForms.GunaGradientCircleButton supp_produit;
        private Guna.UI.WinForms.GunaGradientCircleButton vider;
    }
}

