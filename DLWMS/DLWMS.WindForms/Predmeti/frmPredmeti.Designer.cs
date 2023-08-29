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
        ( ( System.ComponentModel.ISupportInitialize )  dgvPredmeti  ).BeginInit();
        SuspendLayout();
        // 
        // dgvPredmeti
        // 
        dgvPredmeti.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
        dgvPredmeti.Location =  new Point(12, 12) ;
        dgvPredmeti.Name =  "dgvPredmeti" ;
        dgvPredmeti.RowHeadersWidth =  51 ;
        dgvPredmeti.RowTemplate.Height =  29 ;
        dgvPredmeti.Size =  new Size(300, 188) ;
        dgvPredmeti.TabIndex =  0 ;
        // 
        // frmPredmeti
        // 
        AutoScaleDimensions =  new SizeF(8F, 20F) ;
        AutoScaleMode =  AutoScaleMode.Font ;
        ClientSize =  new Size(336, 216) ;
        Controls.Add(dgvPredmeti);
        Name =  "frmPredmeti" ;
        Text =  "frmPredmeti" ;
        Load +=  frmPredmeti_Load ;
        ( ( System.ComponentModel.ISupportInitialize )  dgvPredmeti  ).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dgvPredmeti;
}