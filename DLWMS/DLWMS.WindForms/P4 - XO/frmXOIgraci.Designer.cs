namespace DLWMS.WindForms.P4___XO
{
    partial class frmXOIgraci
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
            txtIgrac1 =  new TextBox () ;
            label1 =  new Label () ;
            label2 =  new Label () ;
            txtIgrac2 =  new TextBox () ;
            btnStart =  new Button () ;
            SuspendLayout ();
            // 
            // txtIgrac1
            // 
            txtIgrac1.Font =  new Font ("Segoe UI" , 15F , FontStyle.Regular , GraphicsUnit.Point) ;
            txtIgrac1.Location =  new Point (27 , 35) ;
            txtIgrac1.Margin =  new Padding (3 , 2 , 3 , 2) ;
            txtIgrac1.Name =  "txtIgrac1" ;
            txtIgrac1.Size =  new Size (197 , 34) ;
            txtIgrac1.TabIndex =  0 ;
            txtIgrac1.TextChanged +=  txtIgrac1_TextChanged ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Location =  new Point (27 , 16) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size (96 , 15) ;
            label1.TabIndex =  1 ;
            label1.Text =  "Ime prvog igrača" ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Location =  new Point (27 , 82) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size (104 , 15) ;
            label2.TabIndex =  3 ;
            label2.Text =  "Ime drugog igraca" ;
            // 
            // txtIgrac2
            // 
            txtIgrac2.Font =  new Font ("Segoe UI" , 15F , FontStyle.Regular , GraphicsUnit.Point) ;
            txtIgrac2.Location =  new Point (27 , 101) ;
            txtIgrac2.Margin =  new Padding (3 , 2 , 3 , 2) ;
            txtIgrac2.Name =  "txtIgrac2" ;
            txtIgrac2.Size =  new Size (197 , 34) ;
            txtIgrac2.TabIndex =  2 ;
            // 
            // btnStart
            // 
            btnStart.Font =  new Font ("Segoe UI" , 12F , FontStyle.Bold , GraphicsUnit.Point) ;
            btnStart.Location =  new Point (80 , 155) ;
            btnStart.Name =  "btnStart" ;
            btnStart.Size =  new Size (99 , 35) ;
            btnStart.TabIndex =  4 ;
            btnStart.Text =  "START" ;
            btnStart.UseVisualStyleBackColor =  true ;
            btnStart.Click +=  button1_Click ;
            // 
            // frmXOIgraci
            // 
            AutoScaleDimensions =  new SizeF (7F , 15F) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size (267 , 202) ;
            Controls.Add (btnStart);
            Controls.Add (label2);
            Controls.Add (txtIgrac2);
            Controls.Add (label1);
            Controls.Add (txtIgrac1);
            Margin =  new Padding (3 , 2 , 3 , 2) ;
            MaximizeBox =  false ;
            MinimizeBox =  false ;
            Name =  "frmXOIgraci" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "frmXOIgraci" ;
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private TextBox txtIgrac1;
        private Label label1;
        private Label label2;
        private TextBox txtIgrac2;
        private Button btnStart;
    }
}