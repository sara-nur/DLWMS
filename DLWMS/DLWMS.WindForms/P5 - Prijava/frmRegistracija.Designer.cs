namespace DLWMS.WindForms.P5___Prijava
{
    partial class frmRegistracija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components =  new System.ComponentModel.Container () ;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (frmRegistracija));
            pictureBox1 =  new PictureBox () ;
            label1 =  new Label () ;
            groupBox1 =  new GroupBox () ;
            btnGenerisi =  new Button () ;
            lblEmail =  new Label () ;
            txtEmail =  new TextBox () ;
            cbAktivan =  new CheckBox () ;
            lblLozinka =  new Label () ;
            lblKorisnickoIme =  new Label () ;
            txtLozinka =  new TextBox () ;
            txtKorisnickoIme =  new TextBox () ;
            groupBox2 =  new GroupBox () ;
            dateTimePicker1 =  new DateTimePicker () ;
            lblIme =  new Label () ;
            txtIme =  new TextBox () ;
            lblDatumRodjenja =  new Label () ;
            lblPrezime =  new Label () ;
            txtPrezime =  new TextBox () ;
            btnRegistracija =  new Button () ;
            errPr =  new ErrorProvider (components) ;
            ( ( System.ComponentModel.ISupportInitialize ) pictureBox1  ).BeginInit ();
            groupBox1.SuspendLayout ();
            groupBox2.SuspendLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) errPr  ).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image =  ( Image ) resources.GetObject ("pictureBox1.Image")  ;
            pictureBox1.Location =  new Point (22 , 19) ;
            pictureBox1.Margin =  new Padding (3 , 4 , 3 , 4) ;
            pictureBox1.Name =  "pictureBox1" ;
            pictureBox1.Size =  new Size (128 , 67) ;
            pictureBox1.SizeMode =  PictureBoxSizeMode.AutoSize ;
            pictureBox1.TabIndex =  0 ;
            pictureBox1.TabStop =  false ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font ("Segoe UI" , 9.3F , FontStyle.Bold , GraphicsUnit.Point) ;
            label1.ImageAlign =  ContentAlignment.TopCenter ;
            label1.Location =  new Point (156 , 19) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size (272 , 63) ;
            label1.TabIndex =  1 ;
            label1.Text =  "Univerzitet \"Džemal Bijedić\"\r\nFakultet informcijskih Tehnologija\r\nMostar" ;
            label1.TextAlign =  ContentAlignment.MiddleCenter ;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add (btnGenerisi);
            groupBox1.Controls.Add (lblEmail);
            groupBox1.Controls.Add (txtEmail);
            groupBox1.Controls.Add (cbAktivan);
            groupBox1.Controls.Add (lblLozinka);
            groupBox1.Controls.Add (lblKorisnickoIme);
            groupBox1.Controls.Add (txtLozinka);
            groupBox1.Controls.Add (txtKorisnickoIme);
            groupBox1.Location =  new Point (22 , 291) ;
            groupBox1.Name =  "groupBox1" ;
            groupBox1.Size =  new Size (406 , 178) ;
            groupBox1.TabIndex =  2 ;
            groupBox1.TabStop =  false ;
            groupBox1.Text =  "Korisnički podaci" ;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location =  new Point (324 , 112) ;
            btnGenerisi.Name =  "btnGenerisi" ;
            btnGenerisi.Size =  new Size (29 , 29) ;
            btnGenerisi.TabIndex =  11 ;
            btnGenerisi.Text =  "G" ;
            btnGenerisi.UseVisualStyleBackColor =  true ;
            btnGenerisi.Click +=  btnGenerisi_Click ;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize =  true ;
            lblEmail.Location =  new Point (18 , 45) ;
            lblEmail.Name =  "lblEmail" ;
            lblEmail.Size =  new Size (46 , 20) ;
            lblEmail.TabIndex =  10 ;
            lblEmail.Text =  "Email" ;
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn =  true ;
            txtEmail.Location =  new Point (130 , 42) ;
            txtEmail.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtEmail.Name =  "txtEmail" ;
            txtEmail.Size =  new Size (223 , 27) ;
            txtEmail.TabIndex =  9 ;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize =  true ;
            cbAktivan.Location =  new Point (130 , 146) ;
            cbAktivan.Name =  "cbAktivan" ;
            cbAktivan.Size =  new Size (80 , 24) ;
            cbAktivan.TabIndex =  8 ;
            cbAktivan.Text =  "Aktivan" ;
            cbAktivan.UseVisualStyleBackColor =  true ;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize =  true ;
            lblLozinka.Location =  new Point (18 , 115) ;
            lblLozinka.Name =  "lblLozinka" ;
            lblLozinka.Size =  new Size (59 , 20) ;
            lblLozinka.TabIndex =  7 ;
            lblLozinka.Text =  "Lozinka" ;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize =  true ;
            lblKorisnickoIme.Location =  new Point (18 , 80) ;
            lblKorisnickoIme.Name =  "lblKorisnickoIme" ;
            lblKorisnickoIme.Size =  new Size (106 , 20) ;
            lblKorisnickoIme.TabIndex =  6 ;
            lblKorisnickoIme.Text =  "Korisničko Ime" ;
            // 
            // txtLozinka
            // 
            txtLozinka.AcceptsReturn =  true ;
            txtLozinka.Location =  new Point (130 , 112) ;
            txtLozinka.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtLozinka.Name =  "txtLozinka" ;
            txtLozinka.Size =  new Size (183 , 27) ;
            txtLozinka.TabIndex =  5 ;
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.AcceptsReturn =  true ;
            txtKorisnickoIme.Location =  new Point (130 , 77) ;
            txtKorisnickoIme.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtKorisnickoIme.Name =  "txtKorisnickoIme" ;
            txtKorisnickoIme.Size =  new Size (223 , 27) ;
            txtKorisnickoIme.TabIndex =  4 ;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add (dateTimePicker1);
            groupBox2.Controls.Add (lblIme);
            groupBox2.Controls.Add (txtIme);
            groupBox2.Controls.Add (lblDatumRodjenja);
            groupBox2.Controls.Add (lblPrezime);
            groupBox2.Controls.Add (txtPrezime);
            groupBox2.Location =  new Point (22 , 117) ;
            groupBox2.Name =  "groupBox2" ;
            groupBox2.Size =  new Size (406 , 157) ;
            groupBox2.TabIndex =  11 ;
            groupBox2.TabStop =  false ;
            groupBox2.Text =  "Lični podaci" ;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location =  new Point (130 , 111) ;
            dateTimePicker1.Name =  "dateTimePicker1" ;
            dateTimePicker1.Size =  new Size (223 , 27) ;
            dateTimePicker1.TabIndex =  11 ;
            // 
            // lblIme
            // 
            lblIme.AutoSize =  true ;
            lblIme.Location =  new Point (18 , 45) ;
            lblIme.Name =  "lblIme" ;
            lblIme.Size =  new Size (34 , 20) ;
            lblIme.TabIndex =  10 ;
            lblIme.Text =  "Ime" ;
            // 
            // txtIme
            // 
            txtIme.AcceptsReturn =  true ;
            txtIme.Location =  new Point (130 , 42) ;
            txtIme.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtIme.Name =  "txtIme" ;
            txtIme.Size =  new Size (223 , 27) ;
            txtIme.TabIndex =  9 ;
            txtIme.TextChanged +=  txtIme_TextChanged ;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize =  true ;
            lblDatumRodjenja.Location =  new Point (18 , 115) ;
            lblDatumRodjenja.Name =  "lblDatumRodjenja" ;
            lblDatumRodjenja.Size =  new Size (109 , 20) ;
            lblDatumRodjenja.TabIndex =  7 ;
            lblDatumRodjenja.Text =  "Datum rođenja" ;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize =  true ;
            lblPrezime.Location =  new Point (18 , 80) ;
            lblPrezime.Name =  "lblPrezime" ;
            lblPrezime.Size =  new Size (62 , 20) ;
            lblPrezime.TabIndex =  6 ;
            lblPrezime.Text =  "Prezime" ;
            // 
            // txtPrezime
            // 
            txtPrezime.AcceptsReturn =  true ;
            txtPrezime.Location =  new Point (130 , 77) ;
            txtPrezime.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtPrezime.Name =  "txtPrezime" ;
            txtPrezime.Size =  new Size (223 , 27) ;
            txtPrezime.TabIndex =  4 ;
            txtPrezime.TextChanged +=  txtPrezime_TextChanged ;
            // 
            // btnRegistracija
            // 
            btnRegistracija.Location =  new Point (129 , 486) ;
            btnRegistracija.Name =  "btnRegistracija" ;
            btnRegistracija.Size =  new Size (225 , 29) ;
            btnRegistracija.TabIndex =  12 ;
            btnRegistracija.Text =  "Registruj se" ;
            btnRegistracija.UseVisualStyleBackColor =  true ;
            btnRegistracija.Click +=  btnRegistracija_Click ;
            // 
            // errPr
            // 
            errPr.ContainerControl =  this ;
            // 
            // frmRegistracija
            // 
            AutoScaleDimensions =  new SizeF (8F , 20F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size (463 , 527) ;
            Controls.Add (btnRegistracija);
            Controls.Add (groupBox2);
            Controls.Add (groupBox1);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Margin =  new Padding (3 , 4 , 3 , 4) ;
            Name =  "frmRegistracija" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "DLWMS :: Registracija" ;
            Load +=  frmRegistracija_Load ;
            ( ( System.ComponentModel.ISupportInitialize ) pictureBox1  ).EndInit ();
            groupBox1.ResumeLayout (false);
            groupBox1.PerformLayout ();
            groupBox2.ResumeLayout (false);
            groupBox2.PerformLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) errPr  ).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblLozinka;
        private Label lblKorisnickoIme;
        private TextBox txtLozinka;
        private TextBox txtKorisnickoIme;
        private CheckBox cbAktivan;
        private Label lblEmail;
        private TextBox txtEmail;
        private GroupBox groupBox2;
        private Label lblIme;
        private TextBox txtIme;
        private Label lblDatumRodjenja;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private DateTimePicker dateTimePicker1;
        private Button btnRegistracija;
        private Button btnGenerisi;
        private ErrorProvider errPr;
    }
}