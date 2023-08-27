using DLWMS.Data;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.WindForms.Intro
{
    public partial class frmlinq : Form
    {
        public frmlinq()
        {
            InitializeComponent();
            //TipoviPodataka ();
            //AnonimniTipovi();
            //DodateMetode();
            Linq();
        }
        private void Linq()
        {
            var ocjene = new List<int>() { 6, 7, 8, 8, 7, 8, 9, 6 };

            var rezultat = from o in ocjene
                           where o > 7
                           select o;
            // o ce biti naziv za svakog clana liste ocjene 

            var godineStudija = new List<GodinaStudija>()
            {
                 new GodinaStudija() {Id = 1, Aktivan = true, Oznaka="1 GODINA", Opis="1 Godina Studija"},
                 new GodinaStudija() {Id = 2, Aktivan = false, Oznaka="2 GODINA", Opis="2 Godina Studija"},
                 new GodinaStudija() {Id = 3, Aktivan = true, Oznaka="3 GODINA", Opis="3 Godina Studija"},
                 new GodinaStudija() {Id = 4, Aktivan = false, Oznaka="4 GODINA", Opis="4 Godina Studija"},
            };

            var rezGodine = from godina in godineStudija
                            where godina.Aktivan == true
                            select new
                            {
                                Rb = godina.Id,
                                Ispis = godina.Oznaka,
                            };

            var rezGodine2 = godineStudija.Where(FiltrirajGodine2);

            var rezGodine3 = godineStudija.Where(godina => godina.Aktivan == true);

        }

        private bool FiltrirajGodine2(GodinaStudija godina) => godina.Aktivan == true;

        private bool FiltrirajGodine1(GodinaStudija godina)
        {
            return godina.Aktivan == true;
        }
        private void DodateMetode()
        {
            //var ime = "Haris";
            //var imeVelikaSlova = ime.VelikaSlova();
            var imePrezime = "Hare Mata";
            var enkript = imePrezime.Enkriptuj();
            var dekript = enkript.Dekriptuj();

            MessageBox.Show(DateTime.Now.ToBiHFormat());
        }
        private void AnonimniTipovi()
        {
            var obj = new { id = 1, indeks = 120021, ime = "Denis" };

            var tuple = (id: 1, indeks: 23532, ime: "Sara", prezime: "Nur");
            tuple.id = 2;
            tuple.indeks = 23532;

            TupleInfo(new dtoStudent() { Id = 1, Indeks = "23543", Ime = "Sara" });
        }
        private dtoStudent TupleInfo(dtoStudent obj)
        {
            return obj;
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
        private void frmlinq_Load(object sender, EventArgs e)
        {

        }
    }
    public class Eksterni
    {
        public void Printaj()
        {
            MessageBox.Show("Printam");
        }
    }
    public class dtoStudent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Indeks { get; set; }
        public string KrvnaGrupa { get; set; }
    }
    public static class DodateMetode
    {
        public static string ToBiHFormat(this DateTime obj)
        {
            return $"BiH Format -> {obj.ToString("dd.MM.yyyy hh:mm:ss")}";
        }
        public static void LoadData<T>(this ComboBox comboBox, List<T> dataSource,
         string displayMember = "Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public static string Enkriptuj(this string obj)
        {
            var enkriptovanSadrzaj = string.Empty;
            for (int i = 0; i < obj.Length; i++)
            {
                enkriptovanSadrzaj += (char) (Convert.ToInt16(obj[i] + i + 1));
            }
            return enkriptovanSadrzaj;
        }
        public static string Dekriptuj(this string obj)
        {
            var dekriptovanSadrzaj = string.Empty;
            for (int i = 0; i < obj.Length; i++)
            {
                dekriptovanSadrzaj += (char) (Convert.ToInt16(obj[i] + i - 1));
            }
            return dekriptovanSadrzaj;
        }
        public static string VelikaSlova(this string obj)
        {
            return obj.ToUpper();
        }
    }
}
