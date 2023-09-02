using DLWMS.Data;
using DLWMS.WindForms.Intro;
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.Studenti;
public partial class frmStudentiPredmeti : Form
{
    public Student odabraniStudent;
    DLWMSDbContext db = new DLWMSDbContext();

    public frmStudentiPredmeti(Student odabraniStudent)
    {
        InitializeComponent();
        dgvPolozeniPredmeti.AutoGenerateColumns = false;   //da bi prikazao samo kolone koje smo mi definisali
        this.odabraniStudent = odabraniStudent;
    }

    private void frmStudentiPredmeti_Load(object sender, EventArgs e)
    {
        UcitajPolozenePredmete();
        UcitajPodatkeOStudentu();
        UcitajPredmete();
        cmbOcjene.SelectedIndex = 0;
    }

    private void UcitajPredmete()
    {
        cmbPredmet.LoadData(db.Predmeti.ToList());
        // cmbPredmet.LoadData(InMemoryDB.Predmeti);
    }

    private void UcitajPodatkeOStudentu()
    {
        pbSlikaStudenta.Image = ImageHelper.FromByteToImage(odabraniStudent.Slika);
        lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
        lblIndex.Text = odabraniStudent.BrojIndeksa;
    }

    private void UcitajPolozenePredmete()
    {
        var binding = new BindingSource();

        binding.DataSource = db.StudentiPredmeti.Where(
            polozeni => polozeni.StudentId == odabraniStudent.Id).ToList();

        dgvPolozeniPredmeti.DataSource = binding;
    }

    private void btnDodaj_Click(object sender, EventArgs e)
    {

        var predmet = cmbPredmet.SelectedItem as Predmet;

        if (PredmetVecDodat())
        {
            var poruka = Resursi.Get(Kljucevi.PodatakVecDodat);
            var ispis = string.Format(poruka, predmet.Naziv);
            MessageBox.Show(ispis, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (ValidanUnos())
        {
            var polozeni = new StudentPredmet
            {
                // Id = db.StudentiPredmeti.Count() + 1,
                Datum = dtpDatumPolaganja.Value,
                Ocjena = int.Parse(cmbOcjene.Text),
                PredmetId = predmet.Id,
                StudentId = odabraniStudent.Id
            };
            db.StudentiPredmeti.Add(polozeni);
            db.SaveChanges();
            UcitajPolozenePredmete();
        }
    }

    private bool PredmetVecDodat()
    {
        var odabraniPredmet = cmbPredmet.SelectedItem as Predmet;
        return db.StudentiPredmeti.Where(
            polozeni => polozeni.PredmetId == odabraniPredmet.Id    //PredmetId ulazi samo u medjutabelu 
            && polozeni.StudentId == odabraniStudent.Id)       //Student.Id ulazi u studenta pa tek trazi ID
            .Count() > 0;
    }

    private bool ValidanUnos()
    {
        return
            Validator.ValidirajKontrolu(cmbPredmet, err, Kljucevi.ObaveznaVrijednost) &&
            Validator.ValidirajKontrolu(cmbOcjene, err, Kljucevi.ObaveznaVrijednost);
    }

    private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var odabraniRed = dgvPolozeniPredmeti.Rows[e.RowIndex].DataBoundItem as StudentPredmet;
        if (MessageBox.Show("Da li ste sigurni da zelite da obrisete odabrani red?", "Oznacite Yes/No", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            if (odabraniRed != null)
            {
                _ = db.StudentiPredmeti.Remove(odabraniRed);
                db.SaveChanges();
                UcitajPolozenePredmete();
            }
            MessageBox.Show($"Predmet {odabraniRed.Predmet.Naziv} uspjesno obrisan!");
        }
        else
            return;



    }

    private void cmbPredmet_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
