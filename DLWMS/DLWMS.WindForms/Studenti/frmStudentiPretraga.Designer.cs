namespace DLWMS.WindForms.Studenti
{
    partial class frmStudentiPretraga
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
            btnDodajStudenta =  new Button() ;
            txtPretraga =  new TextBox() ;
            dgvStudenti =  new DataGridView() ;
            BrojIndeksa =  new DataGridViewTextBoxColumn() ;
            Ime =  new DataGridViewTextBoxColumn() ;
            Prezime =  new DataGridViewTextBoxColumn() ;
            Email =  new DataGridViewTextBoxColumn() ;
            DatumRodjenja =  new DataGridViewTextBoxColumn() ;
            Aktivan =  new DataGridViewCheckBoxColumn() ;
            Predmeti =  new DataGridViewButtonColumn() ;
            ( ( System.ComponentModel.ISupportInitialize )  dgvStudenti  ).BeginInit();
            SuspendLayout();
            // 
            // btnDodajStudenta
            // 
            btnDodajStudenta.Location =  new Point(764, 15) ;
            btnDodajStudenta.Name =  "btnDodajStudenta" ;
            btnDodajStudenta.Size =  new Size(158, 29) ;
            btnDodajStudenta.TabIndex =  1 ;
            btnDodajStudenta.Text =  "Dodaj Studenta" ;
            btnDodajStudenta.UseVisualStyleBackColor =  true ;
            btnDodajStudenta.Click +=  btnDodajStudenta_Click ;
            // 
            // txtPretraga
            // 
            txtPretraga.Location =  new Point(12, 16) ;
            txtPretraga.Name =  "txtPretraga" ;
            txtPretraga.Size =  new Size(746, 27) ;
            txtPretraga.TabIndex =  2 ;
            txtPretraga.TextChanged +=  txtPretraga_TextChanged ;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToDeleteRows =  false ;
            dgvStudenti.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Ime, Prezime, Email, DatumRodjenja, Aktivan, Predmeti });
            dgvStudenti.Location =  new Point(12, 59) ;
            dgvStudenti.Name =  "dgvStudenti" ;
            dgvStudenti.ReadOnly =  true ;
            dgvStudenti.RowHeadersWidth =  51 ;
            dgvStudenti.RowTemplate.Height =  29 ;
            dgvStudenti.SelectionMode =  DataGridViewSelectionMode.FullRowSelect ;
            dgvStudenti.Size =  new Size(910, 202) ;
            dgvStudenti.TabIndex =  0 ;
            dgvStudenti.CellContentClick +=  dgvStudenti_CellContentClick ;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName =  "BrojIndeksa" ;
            BrojIndeksa.HeaderText =  "BrojIndeksa" ;
            BrojIndeksa.MinimumWidth =  6 ;
            BrojIndeksa.Name =  "BrojIndeksa" ;
            BrojIndeksa.ReadOnly =  true ;
            BrojIndeksa.Visible =  false ;
            BrojIndeksa.Width =  125 ;
            // 
            // Ime
            // 
            Ime.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
            Ime.DataPropertyName =  "Ime" ;
            Ime.HeaderText =  "Ime" ;
            Ime.MinimumWidth =  6 ;
            Ime.Name =  "Ime" ;
            Ime.ReadOnly =  true ;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
            Prezime.DataPropertyName =  "Prezime" ;
            Prezime.HeaderText =  "Prezime" ;
            Prezime.MinimumWidth =  6 ;
            Prezime.Name =  "Prezime" ;
            Prezime.ReadOnly =  true ;
            // 
            // Email
            // 
            Email.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
            Email.DataPropertyName =  "Email" ;
            Email.HeaderText =  "Email" ;
            Email.MinimumWidth =  6 ;
            Email.Name =  "Email" ;
            Email.ReadOnly =  true ;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
            DatumRodjenja.DataPropertyName =  "DatumRodjenja" ;
            DatumRodjenja.HeaderText =  "DatumRodjenja" ;
            DatumRodjenja.MinimumWidth =  6 ;
            DatumRodjenja.Name =  "DatumRodjenja" ;
            DatumRodjenja.ReadOnly =  true ;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName =  "Aktivan" ;
            Aktivan.HeaderText =  "Aktivan" ;
            Aktivan.MinimumWidth =  6 ;
            Aktivan.Name =  "Aktivan" ;
            Aktivan.ReadOnly =  true ;
            Aktivan.Width =  125 ;
            // 
            // Predmeti
            // 
            Predmeti.HeaderText =  "Predmeti" ;
            Predmeti.MinimumWidth =  6 ;
            Predmeti.Name =  "Predmeti" ;
            Predmeti.ReadOnly =  true ;
            Predmeti.Text =  "Polozeni" ;
            Predmeti.UseColumnTextForButtonValue =  true ;
            Predmeti.Width =  125 ;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions =  new SizeF(8F, 20F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size(945, 285) ;
            Controls.Add(txtPretraga);
            Controls.Add(btnDodajStudenta);
            Controls.Add(dgvStudenti);
            Name =  "frmStudentiPretraga" ;
            Text =  "Pretraga Studenata" ;
            Load +=  frmStudentiPretraga_Load ;
            ( ( System.ComponentModel.ISupportInitialize )  dgvStudenti  ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDodajStudenta;
        private TextBox txtPretraga;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Predmeti;
    }
}