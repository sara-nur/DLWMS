namespace DLWMS.WindForms.P4___XO
{
    public partial class frmXOIgraci : Form
    {
        public frmXOIgraci( )
        {
            InitializeComponent ();
        }

        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }

        private void button1_Click( object sender , EventArgs e )
        {
            Igrac1 = txtIgrac1.Text;
            Igrac2 = txtIgrac2.Text;

            if( Igrac1 != "" && Igrac2 != "" )
                Close ();
        }

        private void txtIgrac1_TextChanged( object sender , EventArgs e )
        {

        }
    }
}
