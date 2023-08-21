namespace DLWMS.WindForms.P5___Prijava
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
            linkLabel1 =  new LinkLabel () ;
            ( ( System.ComponentModel.ISupportInitialize ) pictureBox1  ).BeginInit ();
            ( ( System.ComponentModel.ISupportInitialize ) err  ).BeginInit ();
            SuspendLayout ();
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.AcceptsReturn =  true ;
            txtKorisnickoIme.Location =  new Point (209 , 84) ;
            txtKorisnickoIme.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtKorisnickoIme.Name =  "txtKorisnickoIme" ;
            txtKorisnickoIme.Size =  new Size (223 , 27) ;
            txtKorisnickoIme.TabIndex =  0 ;
            // 
            // txtLozinka
            // 
            txtLozinka.AcceptsReturn =  true ;
            txtLozinka.Location =  new Point (209 , 147) ;
            txtLozinka.Margin =  new Padding (3 , 4 , 3 , 4) ;
            txtLozinka.Name =  "txtLozinka" ;
            txtLozinka.PasswordChar =  '*' ;
            txtLozinka.Size =  new Size (223 , 27) ;
            txtLozinka.TabIndex =  1 ;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize =  true ;
            lblKorisnickoIme.Location =  new Point (209 , 60) ;
            lblKorisnickoIme.Name =  "lblKorisnickoIme" ;
            lblKorisnickoIme.Size =  new Size (106 , 20) ;
            lblKorisnickoIme.TabIndex =  2 ;
            lblKorisnickoIme.Text =  "Korisničko Ime" ;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize =  true ;
            lblLozinka.Location =  new Point (209 , 123) ;
            lblLozinka.Name =  "lblLozinka" ;
            lblLozinka.Size =  new Size (59 , 20) ;
            lblLozinka.TabIndex =  3 ;
            lblLozinka.Text =  "Lozinka" ;
            // 
            // btnPrijava
            // 
            btnPrijava.Location =  new Point (356 , 200) ;
            btnPrijava.Margin =  new Padding (3 , 4 , 3 , 4) ;
            btnPrijava.Name =  "btnPrijava" ;
            btnPrijava.Size =  new Size (76 , 31) ;
            btnPrijava.TabIndex =  4 ;
            btnPrijava.Text =  "Prijava" ;
            btnPrijava.UseVisualStyleBackColor =  true ;
            btnPrijava.Click +=  btnPrijava_Click ;
            // 
            // pictureBox1
            // 
            pictureBox1.Image =  ( Image ) resources.GetObject ("pictureBox1.Image")  ;
            pictureBox1.Location =  new Point (14 , 16) ;
            pictureBox1.Margin =  new Padding (3 , 4 , 3 , 4) ;
            pictureBox1.Name =  "pictureBox1" ;
            pictureBox1.Size =  new Size (166 , 215) ;
            pictureBox1.SizeMode =  PictureBoxSizeMode.CenterImage ;
            pictureBox1.TabIndex =  5 ;
            pictureBox1.TabStop =  false ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font ("Segoe UI" , 14F , FontStyle.Bold , GraphicsUnit.Point) ;
            label1.Location =  new Point (227 , 12) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size (179 , 32) ;
            label1.TabIndex =  6 ;
            label1.Text =  "DLWMS :: v4.0" ;
            // 
            // label2
            // 
            label2.BackColor =  Color.Black ;
            label2.Location =  new Point (191 , 16) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size (2 , 215) ;
            label2.TabIndex =  7 ;
            // 
            // err
            // 
            err.ContainerControl =  this ;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize =  true ;
            linkLabel1.Location =  new Point (218 , 205) ;
            linkLabel1.Name =  "linkLabel1" ;
            linkLabel1.Size =  new Size (132 , 20) ;
            linkLabel1.TabIndex =  8 ;
            linkLabel1.TabStop =  true ;
            linkLabel1.Text =  "Niste registrovani?" ;
            linkLabel1.LinkClicked +=  linkLabel1_LinkClicked ;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions =  new SizeF (8F , 20F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size (458 , 265) ;
            Controls.Add (linkLabel1);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Controls.Add (btnPrijava);
            Controls.Add (lblLozinka);
            Controls.Add (lblKorisnickoIme);
            Controls.Add (txtLozinka);
            Controls.Add (txtKorisnickoIme);
            Margin =  new Padding (3 , 4 , 3 , 4) ;
            MinimizeBox =  false ;
            Name =  "frmPrijava" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "DLWMS :: Prijava" ;
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
        private LinkLabel linkLabel1;
    }
}