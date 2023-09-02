using DLWMS.Data;
using DLWMS.WindForms.Helpers;
using DLWMS.WindForms.Intro;
using DLWMS.WindForms.P5___Prijava;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WindForms.Studenti
{
    public partial class frmStudentiNovi : Form
    {
        private Student student;

        DLWMSDbContext db = new DLWMSDbContext();


        public frmStudentiNovi(Student odabraniStudent = null)
        {
            InitializeComponent();
            this.student = odabraniStudent ?? new Student();
            dgvUloge.AutoGenerateColumns = false;
        }
        private void frmStudentiNovi_Load(object sender, EventArgs e)
        {
            UcitajGodinuStudija();
            UcitajSpolove();
            UcitajUloge();
            if (student.Id == 0)
                NoviStudent();
            else
                UcitajPodatkeOStudentu();
        }

        private void UcitajUloge()
        {
            cmbUloga.LoadData(db.Uloge.ToList());
        }
        private void UcitajSpolove()
        {
            cmbSpol.LoadData(db.Spolovi.ToList());
            //cmbSpol.LoadData(InMemoryDB.Spolovi);
            //DataLoader.ToComboBox(cmbSpol, InMemoryDB.Spolovi);
            //cmbSpol.DataSource = InMemoryDB.Spolovi;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }
        private void UcitajGodinuStudija()
        {
            cbGodinaStudija.LoadData(InMemoryDB.GodineStudija);
            //DataLoader.ToComboBox(cbGodinaStudija, InMemoryDB.GodineStudija, "Oznaka");
            //cbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            //cbGodinaStudija.DisplayMember = "Oznaka";
            //cbGodinaStudija.ValueMember = "Id";
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
            pbSlikaStudenta.Image = ImageHelper.FromByteToImage(student.Slika);
            cmbSpol.SelectedValue = student.Spol?.Id;
            UcitajUlogeStudenta();
        }

        private void UcitajUlogeStudenta()
        {
            dgvUloge.DataSource = null;
            dgvUloge.DataSource = student.Uloga.ToList();
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
                student.Slika = ImageHelper.FromImageToByte(pbSlikaStudenta.Image);
                student.Spol = cmbSpol.SelectedItem as Spol;


                var poruka = Kljucevi.PodaciUspjesnoModifikovani;

                if (student.Id == 0)
                {
                    //student.Id = InMemoryDB.Studenti.Count() + 1;
                    //InMemoryDB.Studenti.Add(student);
                    poruka = Kljucevi.PodaciUspjesnoDodati;
                    db.Studenti.Add(student);  //ovim dodajemo podatke u nas DbSet koji se zovu studenti 
                }
                else
                    db.Entry(student).State = EntityState.Modified;
                db.SaveChanges(); //tek ovim podatke spremamo u bazu 

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
        private void GenerisiPodatke()
        {
            txtEmail.Text = $"{txtIme.Text}.{txtPrezime.Text}@edu.fit.ba".ToLower();
        }
        private void GenerisiBrojIndeksa()
        {
            txtBrojIndeksa.Text = $"IB{((DateTime.Now.Year) - 2000) * 10000 + db.Studenti.Count() + 1}";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            var odabranaUloga = cmbUloga.SelectedItem as Uloga;
            if (UlogaVecPostoji(odabranaUloga))
            {
                MessageBox.Show($"Student vec ima ulogu {odabranaUloga.Naziv} !");
            }
            else
            {
                student.Uloga.Add(odabranaUloga);
                UcitajUlogeStudenta();
            }

        }

        private bool UlogaVecPostoji(Uloga odabranaUloga)       //dovrsiti verifikaciju 
        {
            return student.Uloga.Any(uloga => uloga.Id == odabranaUloga.Id);
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
