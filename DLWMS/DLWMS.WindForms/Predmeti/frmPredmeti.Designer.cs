namespace DLWMS.WindForms.Predmeti;

partial class frmPredmeti
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
        dgvPredmeti =  new DataGridView() ;
        txtNazivPredmeta =  new TextBox() ;
        btnDodajPredmet =  new Button() ;
        ( ( System.ComponentModel.ISupportInitialize )  dgvPredmeti  ).BeginInit();
        SuspendLayout();
        // 
        // dgvPredmeti
        // 
        dgvPredmeti.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
        dgvPredmeti.Location =  new Point(12, 81) ;
        dgvPredmeti.Name =  "dgvPredmeti" ;
        dgvPredmeti.RowHeadersWidth =  51 ;
        dgvPredmeti.RowTemplate.Height =  29 ;
        dgvPredmeti.Size =  new Size(480, 188) ;
        dgvPredmeti.TabIndex =  0 ;
        // 
        // txtNazivPredmeta
        // 
        txtNazivPredmeta.Location =  new Point(12, 27) ;
        txtNazivPredmeta.Name =  "txtNazivPredmeta" ;
        txtNazivPredmeta.Size =  new Size(380, 27) ;
        txtNazivPredmeta.TabIndex =  1 ;
        // 
        // btnDodajPredmet
        // 
        btnDodajPredmet.Location =  new Point(398, 27) ;
        btnDodajPredmet.Name =  "btnDodajPredmet" ;
        btnDodajPredmet.Size =  new Size(94, 29) ;
        btnDodajPredmet.TabIndex =  2 ;
        btnDodajPredmet.Text =  "Dodaj" ;
        btnDodajPredmet.UseVisualStyleBackColor =  true ;
        btnDodajPredmet.Click +=  btnDodajPredmet_Click ;
        // 
        // frmPredmeti
        // 
        AutoScaleDimensions =  new SizeF(8F, 20F) ;
        AutoScaleMode =  AutoScaleMode.Font ;
        ClientSize =  new Size(504, 281) ;
        Controls.Add(btnDodajPredmet);
        Controls.Add(txtNazivPredmeta);
        Controls.Add(dgvPredmeti);
        Name =  "frmPredmeti" ;
        Text =  "frmPredmeti" ;
        Load +=  frmPredmeti_Load ;
        ( ( System.ComponentModel.ISupportInitialize )  dgvPredmeti  ).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvPredmeti;
    private TextBox txtNazivPredmeta;
    private Button btnDodajPredmet;
}