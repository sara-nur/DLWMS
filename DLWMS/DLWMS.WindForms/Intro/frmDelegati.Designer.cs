namespace DLWMS.WindForms.Intro
{
    partial class frmDelegati
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
            btnPosalji =  new Button () ;
            txtPoruka =  new RichTextBox () ;
            cbPrvaGodina =  new CheckBox () ;
            cbDrugaGodina =  new CheckBox () ;
            cbTrecaGodina =  new CheckBox () ;
            SuspendLayout ();
            // 
            // btnPosalji
            // 
            btnPosalji.Location =  new Point (133 , 228) ;
            btnPosalji.Name =  "btnPosalji" ;
            btnPosalji.Size =  new Size (141 , 29) ;
            btnPosalji.TabIndex =  0 ;
            btnPosalji.Text =  "Posalji" ;
            btnPosalji.UseVisualStyleBackColor =  true ;
            btnPosalji.Click +=  button1_Click ;
            // 
            // txtPoruka
            // 
            txtPoruka.Location =  new Point (12 , 12) ;
            txtPoruka.Name =  "txtPoruka" ;
            txtPoruka.Size =  new Size (360 , 139) ;
            txtPoruka.TabIndex =  2 ;
            txtPoruka.Text =  "" ;
            txtPoruka.TextChanged +=  txtPoruka_TextChanged ;
            // 
            // cbPrvaGodina
            // 
            cbPrvaGodina.AutoSize =  true ;
            cbPrvaGodina.Location =  new Point (12 , 164) ;
            cbPrvaGodina.Name =  "cbPrvaGodina" ;
            cbPrvaGodina.Size =  new Size (111 , 24) ;
            cbPrvaGodina.TabIndex =  3 ;
            cbPrvaGodina.Text =  "Prva Godina" ;
            cbPrvaGodina.UseVisualStyleBackColor =  true ;
            cbPrvaGodina.CheckedChanged +=  cbPrvaGodina_CheckedChanged ;
            // 
            // cbDrugaGodina
            // 
            cbDrugaGodina.AutoSize =  true ;
            cbDrugaGodina.Location =  new Point (129 , 164) ;
            cbDrugaGodina.Name =  "cbDrugaGodina" ;
            cbDrugaGodina.Size =  new Size (124 , 24) ;
            cbDrugaGodina.TabIndex =  4 ;
            cbDrugaGodina.Text =  "Druga Godina" ;
            cbDrugaGodina.TextAlign =  ContentAlignment.MiddleCenter ;
            cbDrugaGodina.UseVisualStyleBackColor =  true ;
            cbDrugaGodina.CheckedChanged +=  cbDrugaGodina_CheckedChanged ;
            // 
            // cbTrecaGodina
            // 
            cbTrecaGodina.AutoSize =  true ;
            cbTrecaGodina.Location =  new Point (254 , 164) ;
            cbTrecaGodina.Name =  "cbTrecaGodina" ;
            cbTrecaGodina.Size =  new Size (118 , 24) ;
            cbTrecaGodina.TabIndex =  5 ;
            cbTrecaGodina.Text =  "Treca Godina" ;
            cbTrecaGodina.UseVisualStyleBackColor =  true ;
            cbTrecaGodina.CheckedChanged +=  cbTrecaGodina_CheckedChanged ;
            // 
            // frmDelegati
            // 
            AutoScaleDimensions =  new SizeF (8F , 20F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size (384 , 292) ;
            Controls.Add (cbTrecaGodina);
            Controls.Add (cbDrugaGodina);
            Controls.Add (cbPrvaGodina);
            Controls.Add (txtPoruka);
            Controls.Add (btnPosalji);
            Name =  "frmDelegati" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Slanje Poruke" ;
            Load +=  frmDelegati_Load ;
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button btnPosalji;
        private RichTextBox txtPoruka;
        private CheckBox cbPrvaGodina;
        private CheckBox cbDrugaGodina;
        private CheckBox cbTrecaGodina;
    }
}