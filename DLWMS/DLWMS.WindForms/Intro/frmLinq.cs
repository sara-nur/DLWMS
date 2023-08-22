using System.Dynamic;

namespace DLWMS.WindForms.Intro
{
    public partial class frmlinq : Form
    {
        public frmlinq()
        {
            InitializeComponent();
            //TipoviPodataka ();
            AnonimniTipovi();
        }

        private void AnonimniTipovi()
        {

        }

        private void TipoviPodataka()
        {
            object ime = "Denis";
            object indeks = "123432";
            object ocjene = new List<int>();

            // PrikaziInfo (ime);

            dynamic student = "Sara Nur";
            student = "150005";
            student = new List<int>() { 2, 4, 3, 2, 3, 4, 3, 4 };

            //dynamic obj = GetEksterniObjekat ();  //dobijamo objekat za koji nemamo adekvantnu klasu i ne zelimo da je imamo
            //Jedino sto mi zelimo je da na ovom objektu pozovemo metodu recimo Printaj();
            //Potvrde (obj);

            dynamic objExp = new ExpandoObject();
            //objExp.Add(Ime,"Denis");
            //objExp.Add (indeks , 23532);

            objExp.Ime = "Sara";
            objExp.Indeks = "234222";
            objExp.Ocjene = new List<int>() { 2, 4, 4, 5, 3, 4, 5 };


            foreach (var osobine in objExp)
            {
                MessageBox.Show(osobine.ToString());
            }

            // Dictionary<int , string> studenti = new Dictionary<int , string> ();
            // studenti.Add (123443 , "Denis Mus");
            // studenti.Add (123544 , "Sara Nur");



            StudentInfo(objExp);


        }





        private void StudentInfo(dynamic objExp)
        {
            MessageBox.Show($"{objExp.Ime} {objExp.Indeks}");
        }

        private dynamic GetEksterniObjekat()
        {
            return new Eksterni();
        }
        private void Potvrde(dynamic obj)
        {
            obj.Printaj();
        }
        private void PrikaziInfo(object ime)
        {
            // throw new NotImplementedException ();
        }
    }
    public class Eksterni
    {
        public void Printaj()
        {
            MessageBox.Show("Printam");
        }
    }
}
