namespace DLWMS.WindForms.Studenti;

partial class frmStudentiPredmeti
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
        pbSlikaStudenta =  new PictureBox() ;
        lblIndex =  new Label() ;
        lblImePrezime =  new Label() ;
        cmbPredmet =  new ComboBox() ;
        cmbOcjene =  new ComboBox() ;
        dtpDatumPolaganja =  new DateTimePicker() ;
        btnDodaj =  new Button() ;
        err =  new ErrorProvider(components) ;
        Predmet =  new DataGridViewTextBoxColumn() ;
        Datum =  new DataGridViewTextBoxColumn() ;
        Ocjena =  new DataGridViewTextBoxColumn() ;
        dgvPolozeniPredmeti =  new DataGridView() ;
        dataGridViewTextBoxColumn1 =  new DataGridViewTextBoxColumn() ;
        dataGridViewTextBoxColumn2 =  new DataGridViewTextBoxColumn() ;
        dataGridViewTextBoxColumn3 =  new DataGridViewTextBoxColumn() ;
        Obriši =  new DataGridViewButtonColumn() ;
        ( ( System.ComponentModel.ISupportInitialize )  pbSlikaStudenta  ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize )  err  ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize )  dgvPolozeniPredmeti  ).BeginInit();
        SuspendLayout();
        // 
        // pbSlikaStudenta
        // 
        pbSlikaStudenta.Location =  new Point(12, 12) ;
        pbSlikaStudenta.Name =  "pbSlikaStudenta" ;
        pbSlikaStudenta.Size =  new Size(125, 151) ;
        pbSlikaStudenta.SizeMode =  PictureBoxSizeMode.StretchImage ;
        pbSlikaStudenta.TabIndex =  1 ;
        pbSlikaStudenta.TabStop =  false ;
        // 
        // lblIndex
        // 
        lblIndex.AutoSize =  true ;
        lblIndex.Font =  new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point) ;
        lblIndex.Location =  new Point(143, 96) ;
        lblIndex.Name =  "lblIndex" ;
        lblIndex.Size =  new Size(160, 67) ;
        lblIndex.TabIndex =  2 ;
        lblIndex.Text =  "label1" ;
        // 
        // lblImePrezime
        // 
        lblImePrezime.AutoSize =  true ;
        lblImePrezime.Font =  new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point) ;
        lblImePrezime.Location =  new Point(172, 12) ;
        lblImePrezime.Name =  "lblImePrezime" ;
        lblImePrezime.Size =  new Size(109, 46) ;
        lblImePrezime.TabIndex =  3 ;
        lblImePrezime.Text =  "label2" ;
        // 
        // cmbPredmet
        // 
        cmbPredmet.FormattingEnabled =  true ;
        cmbPredmet.Location =  new Point(12, 169) ;
        cmbPredmet.Name =  "cmbPredmet" ;
        cmbPredmet.Size =  new Size(125, 28) ;
        cmbPredmet.TabIndex =  4 ;
        cmbPredmet.SelectedIndexChanged +=  cmbPredmet_SelectedIndexChanged ;
        // 
        // cmbOcjene
        // 
        cmbOcjene.FormattingEnabled =  true ;
        cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
        cmbOcjene.Location =  new Point(156, 169) ;
        cmbOcjene.Name =  "cmbOcjene" ;
        cmbOcjene.Size =  new Size(125, 28) ;
        cmbOcjene.TabIndex =  5 ;
        // 
        // dtpDatumPolaganja
        // 
        dtpDatumPolaganja.Location =  new Point(296, 170) ;
        dtpDatumPolaganja.Name =  "dtpDatumPolaganja" ;
        dtpDatumPolaganja.Size =  new Size(250, 27) ;
        dtpDatumPolaganja.TabIndex =  6 ;
        // 
        // btnDodaj
        // 
        btnDodaj.Location =  new Point(568, 171) ;
        btnDodaj.Name =  "btnDodaj" ;
        btnDodaj.Size =  new Size(94, 29) ;
        btnDodaj.TabIndex =  7 ;
        btnDodaj.Text =  "Dodaj" ;
        btnDodaj.UseVisualStyleBackColor =  true ;
        btnDodaj.Click +=  btnDodaj_Click ;
        // 
        // err
        // 
        err.ContainerControl =  this ;
        // 
        // Predmet
        // 
        Predmet.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
        Predmet.DataPropertyName =  "Predmet" ;
        Predmet.HeaderText =  "Predmet" ;
        Predmet.MinimumWidth =  6 ;
        Predmet.Name =  "Predmet" ;
        // 
        // Datum
        // 
        Datum.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
        Datum.DataPropertyName =  "Datum" ;
        Datum.HeaderText =  "Datum" ;
        Datum.MinimumWidth =  6 ;
        Datum.Name =  "Datum" ;
        // 
        // Ocjena
        // 
        Ocjena.DataPropertyName =  "Ocjene" ;
        Ocjena.HeaderText =  "Ocjena" ;
        Ocjena.MinimumWidth =  6 ;
        Ocjena.Name =  "Ocjena" ;
        Ocjena.Width =  125 ;
        // 
        // dgvPolozeniPredmeti
        // 
        dgvPolozeniPredmeti.AllowUserToAddRows =  false ;
        dgvPolozeniPredmeti.AllowUserToDeleteRows =  false ;
        dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
        dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Obriši });
        dgvPolozeniPredmeti.Location =  new Point(12, 229) ;
        dgvPolozeniPredmeti.Name =  "dgvPolozeniPredmeti" ;
        dgvPolozeniPredmeti.RowHeadersWidth =  51 ;
        dgvPolozeniPredmeti.RowTemplate.Height =  29 ;
        dgvPolozeniPredmeti.SelectionMode =  DataGridViewSelectionMode.FullRowSelect ;
        dgvPolozeniPredmeti.Size =  new Size(650, 188) ;
        dgvPolozeniPredmeti.TabIndex =  8 ;
        dgvPolozeniPredmeti.CellContentClick +=  dgvPolozeniPredmeti_CellContentClick ;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
        dataGridViewTextBoxColumn1.DataPropertyName =  "Predmet" ;
        dataGridViewTextBoxColumn1.HeaderText =  "Predmet" ;
        dataGridViewTextBoxColumn1.MinimumWidth =  6 ;
        dataGridViewTextBoxColumn1.Name =  "dataGridViewTextBoxColumn1" ;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode =  DataGridViewAutoSizeColumnMode.Fill ;
        dataGridViewTextBoxColumn2.DataPropertyName =  "Datum" ;
        dataGridViewTextBoxColumn2.HeaderText =  "Datum" ;
        dataGridViewTextBoxColumn2.MinimumWidth =  6 ;
        dataGridViewTextBoxColumn2.Name =  "dataGridViewTextBoxColumn2" ;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.DataPropertyName =  "Ocjena" ;
        dataGridViewTextBoxColumn3.HeaderText =  "Ocjena" ;
        dataGridViewTextBoxColumn3.MinimumWidth =  6 ;
        dataGridViewTextBoxColumn3.Name =  "dataGridViewTextBoxColumn3" ;
        dataGridViewTextBoxColumn3.Width =  125 ;
        // 
        // Obriši
        // 
        Obriši.HeaderText =  "" ;
        Obriši.MinimumWidth =  6 ;
        Obriši.Name =  "Obriši" ;
        Obriši.Text =  "Obriši" ;
        Obriši.UseColumnTextForButtonValue =  true ;
        Obriši.Width =  125 ;
        // 
        // frmStudentiPredmeti
        // 
        AutoScaleDimensions =  new SizeF(8F, 20F) ;
        AutoScaleMode =  AutoScaleMode.Font ;
        ClientSize =  new Size(676, 440) ;
        Controls.Add(dgvPolozeniPredmeti);
        Controls.Add(btnDodaj);
        Controls.Add(dtpDatumPolaganja);
        Controls.Add(cmbOcjene);
        Controls.Add(cmbPredmet);
        Controls.Add(lblImePrezime);
        Controls.Add(lblIndex);
        Controls.Add(pbSlikaStudenta);
        Name =  "frmStudentiPredmeti" ;
        StartPosition =  FormStartPosition.CenterScreen ;
        Text =  "frmStudentiPredmeti" ;
        Load +=  frmStudentiPredmeti_Load ;
        ( ( System.ComponentModel.ISupportInitialize )  pbSlikaStudenta  ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize )  err  ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize )  dgvPolozeniPredmeti  ).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private PictureBox pbSlikaStudenta;
    private Label lblIndex;
    private Label lblImePrezime;
    private ComboBox cmbPredmet;
    private ComboBox cmbOcjene;
    private DateTimePicker dtpDatumPolaganja;
    private Button btnDodaj;
    private ErrorProvider err;
    private DataGridViewTextBoxColumn Predmet;
    private DataGridViewTextBoxColumn Datum;
    private DataGridViewTextBoxColumn Ocjena;
    private DataGridView dgvPolozeniPredmeti;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn Obriši;
}
