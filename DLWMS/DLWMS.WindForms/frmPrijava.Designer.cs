namespace DLWMS.WindForms
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (frmPrijava));
            txtKorisnickoIme =  new TextBox () ;
            txtLozinka =  new TextBox () ;
            lblKorisnickoIme =  new Label () ;
            lblLozinka =  new Label () ;
            btnPrijava =  new Button () ;
            pictureBox1 =  new PictureBox () ;
            label1 =  new Label () ;
            label2 =  new Label () ;
            err =  new ErrorProvider (components) ;
            ( ( System.ComponentModel.ISupportInitialize ) pictureBox1  ).BeginInit ();
            ( ( System.ComponentModel.ISupportInitialize ) err  ).BeginInit ();
            SuspendLayout ();
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.AcceptsReturn =  true ;
            txtKorisnickoIme.Location =  new Point (183 , 63) ;
            txtKorisnickoIme.Name =  "txtKorisnickoIme" ;
            txtKorisnickoIme.Size =  new Size (196 , 23) ;
            txtKorisnickoIme.TabIndex =  0 ;
            // 
            // txtLozinka
            // 
            txtLozinka.AcceptsReturn =  true ;
            txtLozinka.Location =  new Point (183 , 110) ;
            txtLozinka.Name =  "txtLozinka" ;
            txtLozinka.PasswordChar =  '*' ;
            txtLozinka.Size =  new Size (196 , 23) ;
            txtLozinka.TabIndex =  1 ;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize =  true ;
            lblKorisnickoIme.Location =  new Point (183 , 45) ;
            lblKorisnickoIme.Name =  "lblKorisnickoIme" ;
            lblKorisnickoIme.Size =  new Size (85 , 15) ;
            lblKorisnickoIme.TabIndex =  2 ;
            lblKorisnickoIme.Text =  "Korisničko Ime" ;
            lblKorisnickoIme.Click +=  label1_Click ;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize =  true ;
            lblLozinka.Location =  new Point (183 , 92) ;
            lblLozinka.Name =  "lblLozinka" ;
            lblLozinka.Size =  new Size (47 , 15) ;
            lblLozinka.TabIndex =  3 ;
            lblLozinka.Text =  "Lozinka" ;
            // 
            // btnPrijava
            // 
            btnPrijava.Location =  new Point (212 , 150) ;
            btnPrijava.Name =  "btnPrijava" ;
            btnPrijava.Size =  new Size (147 , 23) ;
            btnPrijava.TabIndex =  4 ;
            btnPrijava.Text =  "Prijava" ;
            btnPrijava.UseVisualStyleBackColor =  true ;
            btnPrijava.Click +=  btnPrijava_Click ;
            // 
            // pictureBox1
            // 
            pictureBox1.Image =  ( Image ) resources.GetObject ("pictureBox1.Image")  ;
            pictureBox1.Location =  new Point (12 , 12) ;
            pictureBox1.Name =  "pictureBox1" ;
            pictureBox1.Size =  new Size (145 , 161) ;
            pictureBox1.SizeMode =  PictureBoxSizeMode.CenterImage ;
            pictureBox1.TabIndex =  5 ;
            pictureBox1.TabStop =  false ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font ("Segoe UI" , 14F , FontStyle.Bold , GraphicsUnit.Point) ;
            label1.Location =  new Point (199 , 9) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size (140 , 25) ;
            label1.TabIndex =  6 ;
            label1.Text =  "DLWMS :: v4.0" ;
            label1.Click +=  label1_Click_1 ;
            // 
            // label2
            // 
            label2.BackColor =  Color.Black ;
            label2.Location =  new Point (167 , 12) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size (2 , 161) ;
            label2.TabIndex =  7 ;
            // 
            // err
            // 
            err.ContainerControl =  this ;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions =  new SizeF (7F , 15F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size (401 , 199) ;
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Controls.Add (btnPrijava);
            Controls.Add (lblLozinka);
            Controls.Add (lblKorisnickoIme);
            Controls.Add (txtLozinka);
            Controls.Add (txtKorisnickoIme);
            MinimizeBox =  false ;
            Name =  "frmPrijava" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "DLWMS :: Prijava" ;
            Load +=  frmPrijava_Load ;
            ( ( System.ComponentModel.ISupportInitialize ) pictureBox1  ).EndInit ();
            ( ( System.ComponentModel.ISupportInitialize ) err  ).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private TextBox txtKorisnickoIme;
        private TextBox txtLozinka;
        private Label lblKorisnickoIme;
        private Label lblLozinka;
        private Button btnPrijava;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ErrorProvider err;
    }
}