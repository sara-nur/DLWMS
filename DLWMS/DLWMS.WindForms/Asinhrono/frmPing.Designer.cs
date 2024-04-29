namespace DLWMS.WindForms.Asinhrono;

partial class frmPing
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
        txtIspis = new TextBox();
        btnPing = new Button();
        txtUrl = new TextBox();
        cmbBrojPonavljanja = new ComboBox();
        cmbPauza = new ComboBox();
        SuspendLayout();
        // 
        // txtIspis
        // 
        txtIspis.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
        txtIspis.Location = new Point(12, 54);
        txtIspis.Multiline = true;
        txtIspis.Name = "txtIspis";
        txtIspis.ScrollBars = ScrollBars.Both;
        txtIspis.Size = new Size(439, 310);
        txtIspis.TabIndex = 0;
        // 
        // btnPing
        // 
        btnPing.Location = new Point(357, 21);
        btnPing.Name = "btnPing";
        btnPing.Size = new Size(94, 29);
        btnPing.TabIndex = 1;
        btnPing.Text = "Ping";
        btnPing.UseVisualStyleBackColor = true;
        btnPing.Click += btnPing_Click;
        // 
        // txtUrl
        // 
        txtUrl.Location = new Point(12, 21);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(125, 27);
        txtUrl.TabIndex = 2;
        // 
        // cmbBrojPonavljanja
        // 
        cmbBrojPonavljanja.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBrojPonavljanja.FormattingEnabled = true;
        cmbBrojPonavljanja.Items.AddRange(new object[] { "1", "5", "10", "20" });
        cmbBrojPonavljanja.Location = new Point(143, 20);
        cmbBrojPonavljanja.Name = "cmbBrojPonavljanja";
        cmbBrojPonavljanja.Size = new Size(72, 28);
        cmbBrojPonavljanja.TabIndex = 3;
        // 
        // cmbPauza
        // 
        cmbPauza.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPauza.FormattingEnabled = true;
        cmbPauza.Items.AddRange(new object[] { "100", "200", "500", "1000", "2000" });
        cmbPauza.Location = new Point(221, 20);
        cmbPauza.Name = "cmbPauza";
        cmbPauza.Size = new Size(72, 28);
        cmbPauza.TabIndex = 4;
        // 
        // frmPing
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(465, 376);
        Controls.Add(cmbPauza);
        Controls.Add(cmbBrojPonavljanja);
        Controls.Add(txtUrl);
        Controls.Add(btnPing);
        Controls.Add(txtIspis);
        Name = "frmPing";
        Text = "frmPing";
        Load += frmPing_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtIspis;
    private Button btnPing;
    private TextBox txtUrl;
    private ComboBox cmbBrojPonavljanja;
    private ComboBox cmbPauza;
}
