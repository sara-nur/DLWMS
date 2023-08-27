namespace DLWMS.WindForms.Studenti
{
    partial class frmStudentiNovi
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
            if ( disposing && ( components != null ) )
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
            components =  new System.ComponentModel.Container() ;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentiNovi));
            btnSacuvaj =  new Button() ;
            groupBox2 =  new GroupBox() ;
            cbGodinaStudija =  new ComboBox() ;
            lblGodinaStudija =  new Label() ;
            dtpDatumRodjenja =  new DateTimePicker() ;
            lblIme =  new Label() ;
            txtIme =  new TextBox() ;
            lblDatumRodjenja =  new Label() ;
            lblPrezime =  new Label() ;
            txtPrezime =  new TextBox() ;
            pbSlikaStudenta =  new PictureBox() ;
            lblBrojIndeksa =  new Label() ;
            txtBrojIndeksa =  new TextBox() ;
            groupBox1 =  new GroupBox() ;
            btnGenerisi =  new Button() ;
            lblEmail =  new Label() ;
            cbAktivan =  new CheckBox() ;
            txtEmail =  new TextBox() ;
            lblLozinka =  new Label() ;
            txtLozinka =  new TextBox() ;
            label1 =  new Label() ;
            pbLogo =  new PictureBox() ;
            btnUcitajSliku =  new Button() ;
            err =  new ErrorProvider(components) ;
            openFileDialog1 =  new OpenFileDialog() ;
            cmbSpol =  new ComboBox() ;
            lblSpol =  new Label() ;
            groupBox2.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )  pbSlikaStudenta  ).BeginInit();
            groupBox1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )  pbLogo  ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )  err  ).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location =  new Point(207, 603) ;
            btnSacuvaj.Name =  "btnSacuvaj" ;
            btnSacuvaj.Size =  new Size(225, 29) ;
            btnSacuvaj.TabIndex =  3 ;
            btnSacuvaj.Text =  "Sačuvaj" ;
            btnSacuvaj.UseVisualStyleBackColor =  true ;
            btnSacuvaj.Click +=  btnSacuvaj_Click ;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbSpol);
            groupBox2.Controls.Add(lblSpol);
            groupBox2.Controls.Add(cbGodinaStudija);
            groupBox2.Controls.Add(lblGodinaStudija);
            groupBox2.Controls.Add(dtpDatumRodjenja);
            groupBox2.Controls.Add(lblIme);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(lblDatumRodjenja);
            groupBox2.Controls.Add(lblPrezime);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Location =  new Point(266, 119) ;
            groupBox2.Name =  "groupBox2" ;
            groupBox2.Size =  new Size(406, 247) ;
            groupBox2.TabIndex =  0 ;
            groupBox2.TabStop =  false ;
            groupBox2.Text =  "Podaci o studentu" ;
            // 
            // cbGodinaStudija
            // 
            cbGodinaStudija.DropDownStyle =  ComboBoxStyle.DropDownList ;
            cbGodinaStudija.FormattingEnabled =  true ;
            cbGodinaStudija.Location =  new Point(130, 144) ;
            cbGodinaStudija.Name =  "cbGodinaStudija" ;
            cbGodinaStudija.Size =  new Size(223, 28) ;
            cbGodinaStudija.TabIndex =  3 ;
            // 
            // lblGodinaStudija
            // 
            lblGodinaStudija.AutoSize =  true ;
            lblGodinaStudija.Location =  new Point(18, 147) ;
            lblGodinaStudija.Name =  "lblGodinaStudija" ;
            lblGodinaStudija.Size =  new Size(107, 20) ;
            lblGodinaStudija.TabIndex =  15 ;
            lblGodinaStudija.Text =  "Godina Studija" ;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location =  new Point(130, 111) ;
            dtpDatumRodjenja.Name =  "dtpDatumRodjenja" ;
            dtpDatumRodjenja.Size =  new Size(223, 27) ;
            dtpDatumRodjenja.TabIndex =  2 ;
            // 
            // lblIme
            // 
            lblIme.AutoSize =  true ;
            lblIme.Location =  new Point(18, 45) ;
            lblIme.Name =  "lblIme" ;
            lblIme.Size =  new Size(34, 20) ;
            lblIme.TabIndex =  10 ;
            lblIme.Text =  "Ime" ;
            // 
            // txtIme
            // 
            txtIme.AcceptsReturn =  true ;
            txtIme.Location =  new Point(130, 42) ;
            txtIme.Margin =  new Padding(3, 4, 3, 4) ;
            txtIme.Name =  "txtIme" ;
            txtIme.Size =  new Size(223, 27) ;
            txtIme.TabIndex =  0 ;
            txtIme.TextChanged +=  txtIme_TextChanged ;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize =  true ;
            lblDatumRodjenja.Location =  new Point(18, 115) ;
            lblDatumRodjenja.Name =  "lblDatumRodjenja" ;
            lblDatumRodjenja.Size =  new Size(109, 20) ;
            lblDatumRodjenja.TabIndex =  7 ;
            lblDatumRodjenja.Text =  "Datum rođenja" ;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize =  true ;
            lblPrezime.Location =  new Point(18, 80) ;
            lblPrezime.Name =  "lblPrezime" ;
            lblPrezime.Size =  new Size(62, 20) ;
            lblPrezime.TabIndex =  6 ;
            lblPrezime.Text =  "Prezime" ;
            // 
            // txtPrezime
            // 
            txtPrezime.AcceptsReturn =  true ;
            txtPrezime.Location =  new Point(130, 77) ;
            txtPrezime.Margin =  new Padding(3, 4, 3, 4) ;
            txtPrezime.Name =  "txtPrezime" ;
            txtPrezime.Size =  new Size(223, 27) ;
            txtPrezime.TabIndex =  1 ;
            txtPrezime.TextChanged +=  txtPrezime_TextChanged ;
            // 
            // pbSlikaStudenta
            // 
            pbSlikaStudenta.BorderStyle =  BorderStyle.FixedSingle ;
            pbSlikaStudenta.Location =  new Point(28, 126) ;
            pbSlikaStudenta.Name =  "pbSlikaStudenta" ;
            pbSlikaStudenta.Size =  new Size(210, 221) ;
            pbSlikaStudenta.SizeMode =  PictureBoxSizeMode.StretchImage ;
            pbSlikaStudenta.TabIndex =  17 ;
            pbSlikaStudenta.TabStop =  false ;
            // 
            // lblBrojIndeksa
            // 
            lblBrojIndeksa.AutoSize =  true ;
            lblBrojIndeksa.Location =  new Point(18, 45) ;
            lblBrojIndeksa.Name =  "lblBrojIndeksa" ;
            lblBrojIndeksa.Size =  new Size(90, 20) ;
            lblBrojIndeksa.TabIndex =  13 ;
            lblBrojIndeksa.Text =  "Broj Indeksa" ;
            // 
            // txtBrojIndeksa
            // 
            txtBrojIndeksa.AcceptsReturn =  true ;
            txtBrojIndeksa.Location =  new Point(130, 42) ;
            txtBrojIndeksa.Margin =  new Padding(3, 4, 3, 4) ;
            txtBrojIndeksa.Name =  "txtBrojIndeksa" ;
            txtBrojIndeksa.Size =  new Size(223, 27) ;
            txtBrojIndeksa.TabIndex =  0 ;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblBrojIndeksa);
            groupBox1.Controls.Add(txtBrojIndeksa);
            groupBox1.Controls.Add(cbAktivan);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblLozinka);
            groupBox1.Controls.Add(txtLozinka);
            groupBox1.Location =  new Point(266, 411) ;
            groupBox1.Name =  "groupBox1" ;
            groupBox1.Size =  new Size(406, 173) ;
            groupBox1.TabIndex =  1 ;
            groupBox1.TabStop =  false ;
            groupBox1.Text =  "Korisnički podaci" ;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location =  new Point(324, 112) ;
            btnGenerisi.Name =  "btnGenerisi" ;
            btnGenerisi.Size =  new Size(29, 29) ;
            btnGenerisi.TabIndex =  4 ;
            btnGenerisi.Text =  "G" ;
            btnGenerisi.UseVisualStyleBackColor =  true ;
            btnGenerisi.Click +=  btnGenerisi_Click ;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize =  true ;
            lblEmail.Location =  new Point(18, 81) ;
            lblEmail.Name =  "lblEmail" ;
            lblEmail.Size =  new Size(46, 20) ;
            lblEmail.TabIndex =  10 ;
            lblEmail.Text =  "Email" ;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize =  true ;
            cbAktivan.Location =  new Point(130, 146) ;
            cbAktivan.Name =  "cbAktivan" ;
            cbAktivan.Size =  new Size(80, 24) ;
            cbAktivan.TabIndex =  3 ;
            cbAktivan.Text =  "Aktivan" ;
            cbAktivan.UseVisualStyleBackColor =  true ;
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn =  true ;
            txtEmail.Location =  new Point(130, 78) ;
            txtEmail.Margin =  new Padding(3, 4, 3, 4) ;
            txtEmail.Name =  "txtEmail" ;
            txtEmail.Size =  new Size(223, 27) ;
            txtEmail.TabIndex =  1 ;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize =  true ;
            lblLozinka.Location =  new Point(18, 115) ;
            lblLozinka.Name =  "lblLozinka" ;
            lblLozinka.Size =  new Size(59, 20) ;
            lblLozinka.TabIndex =  7 ;
            lblLozinka.Text =  "Lozinka" ;
            // 
            // txtLozinka
            // 
            txtLozinka.AcceptsReturn =  true ;
            txtLozinka.Location =  new Point(130, 112) ;
            txtLozinka.Margin =  new Padding(3, 4, 3, 4) ;
            txtLozinka.Name =  "txtLozinka" ;
            txtLozinka.Size =  new Size(183, 27) ;
            txtLozinka.TabIndex =  2 ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font("Segoe UI", 9.3F, FontStyle.Bold, GraphicsUnit.Point) ;
            label1.ImageAlign =  ContentAlignment.TopCenter ;
            label1.Location =  new Point(266, 21) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size(272, 63) ;
            label1.TabIndex =  19 ;
            label1.Text =  "Univerzitet \"Džemal Bijedić\"\r\nFakultet informcijskih Tehnologija\r\nMostar" ;
            label1.TextAlign =  ContentAlignment.MiddleCenter ;
            // 
            // pbLogo
            // 
            pbLogo.Image =  ( Image )  resources.GetObject("pbLogo.Image")  ;
            pbLogo.Location =  new Point(132, 21) ;
            pbLogo.Margin =  new Padding(3, 4, 3, 4) ;
            pbLogo.Name =  "pbLogo" ;
            pbLogo.Size =  new Size(128, 67) ;
            pbLogo.SizeMode =  PictureBoxSizeMode.AutoSize ;
            pbLogo.TabIndex =  18 ;
            pbLogo.TabStop =  false ;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location =  new Point(28, 359) ;
            btnUcitajSliku.Name =  "btnUcitajSliku" ;
            btnUcitajSliku.Size =  new Size(210, 29) ;
            btnUcitajSliku.TabIndex =  2 ;
            btnUcitajSliku.Text =  "Učitaj Sliku" ;
            btnUcitajSliku.UseVisualStyleBackColor =  true ;
            btnUcitajSliku.Click +=  btnUcitajSliku_Click ;
            // 
            // err
            // 
            err.ContainerControl =  this ;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName =  "openFileDialog1" ;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle =  ComboBoxStyle.DropDownList ;
            cmbSpol.FormattingEnabled =  true ;
            cmbSpol.Location =  new Point(130, 181) ;
            cmbSpol.Name =  "cmbSpol" ;
            cmbSpol.Size =  new Size(223, 28) ;
            cmbSpol.TabIndex =  16 ;
            cmbSpol.SelectedIndexChanged +=  comboBox1_SelectedIndexChanged ;
            // 
            // lblSpol
            // 
            lblSpol.AutoSize =  true ;
            lblSpol.Location =  new Point(17, 184) ;
            lblSpol.Name =  "lblSpol" ;
            lblSpol.Size =  new Size(39, 20) ;
            lblSpol.TabIndex =  17 ;
            lblSpol.Text =  "Spol" ;
            lblSpol.Click +=  label2_Click ;
            // 
            // frmStudentiNovi
            // 
            AutoScaleDimensions =  new SizeF(8F, 20F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size(714, 644) ;
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlikaStudenta);
            Controls.Add(btnSacuvaj);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            MaximizeBox =  false ;
            MinimizeBox =  false ;
            Name =  "frmStudentiNovi" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "frmStudentiNovi" ;
            Load +=  frmStudentiNovi_Load ;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize )  pbSlikaStudenta  ).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize )  pbLogo  ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )  err  ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private GroupBox groupBox2;
        private ComboBox cbGodinaStudija;
        private Label lblGodinaStudija;
        private DateTimePicker dtpDatumRodjenja;
        private Label lblIme;
        private TextBox txtIme;
        private Label lblDatumRodjenja;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private PictureBox pbSlikaStudenta;
        private Label lblBrojIndeksa;
        private TextBox txtBrojIndeksa;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private Label lblEmail;
        private CheckBox cbAktivan;
        private TextBox txtEmail;
        private Label lblLozinka;
        private TextBox txtLozinka;
        private Label label1;
        private PictureBox pbLogo;
        private Button btnUcitajSliku;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbSpol;
        private Label lblSpol;
    }
}