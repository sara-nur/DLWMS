using DLWMS.Data;
using DLWMS.WindForms.Intro;
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.Studenti;
public partial class frmStudentiPredmeti : Form
{
    private Student odabraniStudent;

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

    private void UcitajPredmete() => cmbPredmet.LoadData(InMemoryDB.Predmeti);

    private void UcitajPodatkeOStudentu()
    {
        pbSlikaStudenta.Image = odabraniStudent.Slika;
        lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
        lblIndex.Text = odabraniStudent.BrojIndeksa;
    }

    private void UcitajPolozenePredmete()
    {
        var binding = new BindingSource();
        binding.DataSource = odabraniStudent.PolozeniPredmeti;
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

            odabraniStudent.PolozeniPredmeti.Add(new PolozeniPredmet()
            {
                Id = odabraniStudent.PolozeniPredmeti.Count() + 1,
                Datum = dtpDatumPolaganja.Value,
                Ocjene = int.Parse(cmbOcjene.Text),
                Predmet = predmet
            });
            UcitajPolozenePredmete();
        }
    }

    private bool PredmetVecDodat()
    {
        var odabraniPredmet = cmbPredmet.SelectedItem as Predmet;
        return odabraniStudent.PolozeniPredmeti.Where(
            polozeni => polozeni.Predmet.Id == odabraniPredmet.Id)
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
        var odabraniRed = dgvPolozeniPredmeti.Rows[e.RowIndex].DataBoundItem as PolozeniPredmet;
        if (MessageBox.Show("Da li ste sigurni da zelite da obrisete odabrani red?", "Oznacite Yes/No", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            if (odabraniRed != null)
            {
                _ = odabraniStudent.PolozeniPredmeti.Remove(odabraniRed);
                UcitajPolozenePredmete();
            }
            MessageBox.Show($"Predmet {odabraniRed.Predmet.Naziv} uspjesno obrisan!");
        }
        else
            return;



    }
}
