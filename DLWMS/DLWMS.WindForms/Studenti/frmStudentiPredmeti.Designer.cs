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
        components = new System.ComponentModel.Container();
        pbSlikaStudenta = new PictureBox();
        lblIndex = new Label();
        lblImePrezime = new Label();
        cmbPredmet = new ComboBox();
        cmbOcjene = new ComboBox();
        dtpDatumPolaganja = new DateTimePicker();
        btnDodaj = new Button();
        err = new ErrorProvider(components);
        Predmet = new DataGridViewTextBoxColumn();
        Datum = new DataGridViewTextBoxColumn();
        Ocjena = new DataGridViewTextBoxColumn();
        dgvPolozeniPredmeti = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        Obriši = new DataGridViewButtonColumn();
        btnPrintaj = new Button();
        ((System.ComponentModel.ISupportInitialize) pbSlikaStudenta).BeginInit();
        ((System.ComponentModel.ISupportInitialize) err).BeginInit();
        ((System.ComponentModel.ISupportInitialize) dgvPolozeniPredmeti).BeginInit();
        SuspendLayout();
        // 
        // pbSlikaStudenta
        // 
        pbSlikaStudenta.Location = new Point(10, 9);
        pbSlikaStudenta.Margin = new Padding(3, 2, 3, 2);
        pbSlikaStudenta.Name = "pbSlikaStudenta";
        pbSlikaStudenta.Size = new Size(109, 113);
        pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
        pbSlikaStudenta.TabIndex = 1;
        pbSlikaStudenta.TabStop = false;
        // 
        // lblIndex
        // 
        lblIndex.AutoSize = true;
        lblIndex.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        lblIndex.Location = new Point(125, 72);
        lblIndex.Name = "lblIndex";
        lblIndex.Size = new Size(130, 54);
        lblIndex.TabIndex = 2;
        lblIndex.Text = "label1";
        // 
        // lblImePrezime
        // 
        lblImePrezime.AutoSize = true;
        lblImePrezime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        lblImePrezime.Location = new Point(150, 9);
        lblImePrezime.Name = "lblImePrezime";
        lblImePrezime.Size = new Size(90, 37);
        lblImePrezime.TabIndex = 3;
        lblImePrezime.Text = "label2";
        // 
        // cmbPredmet
        // 
        cmbPredmet.FormattingEnabled = true;
        cmbPredmet.Location = new Point(10, 127);
        cmbPredmet.Margin = new Padding(3, 2, 3, 2);
        cmbPredmet.Name = "cmbPredmet";
        cmbPredmet.Size = new Size(110, 23);
        cmbPredmet.TabIndex = 4;
        cmbPredmet.SelectedIndexChanged += cmbPredmet_SelectedIndexChanged;
        // 
        // cmbOcjene
        // 
        cmbOcjene.FormattingEnabled = true;
        cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
        cmbOcjene.Location = new Point(136, 127);
        cmbOcjene.Margin = new Padding(3, 2, 3, 2);
        cmbOcjene.Name = "cmbOcjene";
        cmbOcjene.Size = new Size(110, 23);
        cmbOcjene.TabIndex = 5;
        // 
        // dtpDatumPolaganja
        // 
        dtpDatumPolaganja.Location = new Point(259, 128);
        dtpDatumPolaganja.Margin = new Padding(3, 2, 3, 2);
        dtpDatumPolaganja.Name = "dtpDatumPolaganja";
        dtpDatumPolaganja.Size = new Size(219, 23);
        dtpDatumPolaganja.TabIndex = 6;
        // 
        // btnDodaj
        // 
        btnDodaj.Location = new Point(497, 128);
        btnDodaj.Margin = new Padding(3, 2, 3, 2);
        btnDodaj.Name = "btnDodaj";
        btnDodaj.Size = new Size(82, 22);
        btnDodaj.TabIndex = 7;
        btnDodaj.Text = "Dodaj";
        btnDodaj.UseVisualStyleBackColor = true;
        btnDodaj.Click += btnDodaj_Click;
        // 
        // err
        // 
        err.ContainerControl = this;
        // 
        // Predmet
        // 
        Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Predmet.DataPropertyName = "Predmet";
        Predmet.HeaderText = "Predmet";
        Predmet.MinimumWidth = 6;
        Predmet.Name = "Predmet";
        // 
        // Datum
        // 
        Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Datum.DataPropertyName = "Datum";
        Datum.HeaderText = "Datum";
        Datum.MinimumWidth = 6;
        Datum.Name = "Datum";
        // 
        // Ocjena
        // 
        Ocjena.DataPropertyName = "Ocjene";
        Ocjena.HeaderText = "Ocjena";
        Ocjena.MinimumWidth = 6;
        Ocjena.Name = "Ocjena";
        Ocjena.Width = 125;
        // 
        // dgvPolozeniPredmeti
        // 
        dgvPolozeniPredmeti.AllowUserToAddRows = false;
        dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
        dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Obriši });
        dgvPolozeniPredmeti.Location = new Point(10, 172);
        dgvPolozeniPredmeti.Margin = new Padding(3, 2, 3, 2);
        dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
        dgvPolozeniPredmeti.RowHeadersWidth = 51;
        dgvPolozeniPredmeti.RowTemplate.Height = 29;
        dgvPolozeniPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPolozeniPredmeti.Size = new Size(569, 141);
        dgvPolozeniPredmeti.TabIndex = 8;
        dgvPolozeniPredmeti.CellContentClick += dgvPolozeniPredmeti_CellContentClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn1.DataPropertyName = "Predmet";
        dataGridViewTextBoxColumn1.HeaderText = "Predmet";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
        dataGridViewTextBoxColumn2.HeaderText = "Datum";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.DataPropertyName = "Ocjena";
        dataGridViewTextBoxColumn3.HeaderText = "Ocjena";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.Width = 125;
        // 
        // Obriši
        // 
        Obriši.HeaderText = "";
        Obriši.MinimumWidth = 6;
        Obriši.Name = "Obriši";
        Obriši.Text = "Obriši";
        Obriši.UseColumnTextForButtonValue = true;
        Obriši.Width = 125;
        // 
        // btnPrintaj
        // 
        btnPrintaj.Location = new Point(462, 324);
        btnPrintaj.Margin = new Padding(3, 2, 3, 2);
        btnPrintaj.Name = "btnPrintaj";
        btnPrintaj.Size = new Size(117, 22);
        btnPrintaj.TabIndex = 9;
        btnPrintaj.Text = "Printaj Uvjerenje";
        btnPrintaj.UseVisualStyleBackColor = true;
        btnPrintaj.Click += btnPrintaj_Click;
        // 
        // frmStudentiPredmeti
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(592, 357);
        Controls.Add(btnPrintaj);
        Controls.Add(dgvPolozeniPredmeti);
        Controls.Add(btnDodaj);
        Controls.Add(dtpDatumPolaganja);
        Controls.Add(cmbOcjene);
        Controls.Add(cmbPredmet);
        Controls.Add(lblImePrezime);
        Controls.Add(lblIndex);
        Controls.Add(pbSlikaStudenta);
        Margin = new Padding(3, 2, 3, 2);
        Name = "frmStudentiPredmeti";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "frmStudentiPredmeti";
        Load += frmStudentiPredmeti_Load;
        ((System.ComponentModel.ISupportInitialize) pbSlikaStudenta).EndInit();
        ((System.ComponentModel.ISupportInitialize) err).EndInit();
        ((System.ComponentModel.ISupportInitialize) dgvPolozeniPredmeti).EndInit();
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
    private Button btnPrintaj;
}
