using DLWMS.Data.Helpers;

namespace DLWMS.WindForms.Intro
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent ();
        }

        private void Form1_Load( object sender , EventArgs e )
        {
            Konekcija konekcija = new Konekcija ();
            List<_Student> studenti = konekcija.GetStudentByGodinaStudija (1);
            foreach( var student in studenti )
            {
                MessageBox.Show (student.ToString ());
            }
        }

        private void label1_Click( object sender , EventArgs e )
        {

        }
    }
}