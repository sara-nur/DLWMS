using DLWMS.Data;
using DLWMS.WindForms.Helpers;
using DLWMS.WindForms.P5___Prijava;

namespace DLWMS.WindForms.Studenti
{
    public partial class frmStudentiNovi : Form
    {
        private Student student;
        public frmStudentiNovi(Student odabraniStudent = null)
        {
            InitializeComponent();
            this.student = odabraniStudent ?? new Student();
        }
        private void frmStudentiNovi_Load(object sender, EventArgs e)
        {
            UcitajGodinuStudija();
            UcitajSpolove();
            if (student.Id == 0)
                NoviStudent();
            else
                UcitajPodatkeOStudentu();
        }
        private void UcitajSpolove()
        {
            DataLoader.ToComboBox(cmbSpol, InMemoryDB.Spolovi);
            //cmbSpol.DataSource = InMemoryDB.Spolovi;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }
        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
            cbGodinaStudija.SelectedValue = student.GodinaStudija;
            txtBrojIndeksa.Text = student.BrojIndeksa;
            txtEmail.Text = student.Email;
            txtLozinka.Text = student.Lozinka;
            cbAktivan.Checked = student.Aktivan;
            pbSlikaStudenta.Image = student.Slika;
            cmbSpol.SelectedItem = student.Spol;
        }
        private void NoviStudent()
        {
            GenerisiBrojIndeksa();
            GenerisiLozinku();
            OznaciAktivnogStudenta();
        }
        private void OznaciAktivnogStudenta()
        {
            cbAktivan.Checked = true;
        }
        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GenerisiLozinku();
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value;
                student.GodinaStudija = (int) cbGodinaStudija.SelectedValue;
                student.BrojIndeksa = txtBrojIndeksa.Text;
                student.Email = txtEmail.Text;
                student.Lozinka = txtLozinka.Text;
                student.Aktivan = cbAktivan.Checked;
                student.Slika = pbSlikaStudenta.Image;
                student.Spol = cmbSpol.SelectedItem as Spol;


                var poruka = Kljucevi.PodaciUspjesnoModifikovani;

                if (student.Id == 0)
                {
                    student.Id = InMemoryDB.Studenti.Count() + 1;
                    InMemoryDB.Studenti.Add(student);
                    poruka = Kljucevi.PodaciUspjesnoDodati;
                }

                MessageBox.Show($"{Resursi.Get(poruka)} {student}",
                    Resursi.Get(Kljucevi.Informacija),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                new frmPrijava();
            }
        }
        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Kljucevi.ObaveznaVrijednost) &&
            Validator.ValidirajKontrolu(txtPrezime, err, Kljucevi.ObaveznaVrijednost) &&
            Validator.ValidirajKontrolu(cbGodinaStudija, err, Kljucevi.ObaveznaVrijednost) &&
            Validator.ValidirajKontrolu(txtBrojIndeksa, err, Kljucevi.ObaveznaVrijednost) &&
            Validator.ValidirajEmail(txtEmail, err, Kljucevi.EmailVecPostoji) &&
            Validator.ValidirajKontrolu(pbSlikaStudenta, err, Kljucevi.ObaveznaVrijednost);
        }
        private void UcitajGodinuStudija()
        {
            DataLoader.ToComboBox(cbGodinaStudija, InMemoryDB.GodineStudija, "Oznaka");

            //cbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            //cbGodinaStudija.DisplayMember = "Oznaka";
            //cbGodinaStudija.ValueMember = "Id";
        }
        private void GenerisiPodatke()
        {
            txtEmail.Text = $"{txtIme.Text}.{txtPrezime.Text}@edu.fit.ba".ToLower();
        }
        private void GenerisiBrojIndeksa()
        {
            txtBrojIndeksa.Text = $"IB{((DateTime.Now.Year) - 2000) * 10000 + InMemoryDB.Studenti.Count() + 1}";
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }
        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            GenerisiLozinku();
        }
        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlikaStudenta.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

    public class DataLoader
    {
        public static void ToComboBox<T>(ComboBox comboBox, List<T> dataSource,
            string displayMember = "Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

        }
    }

}
