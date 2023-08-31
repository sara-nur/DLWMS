using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.Predmeti
{
    public partial class frmPredmeti : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPredmeti()
        {
            InitializeComponent();
        }
        private void frmPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }
        private void UcitajPredmete()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = db.Predmeti.ToList();
        }
        //‪C:\Users\Sara\Desktop\DLWMS.db
        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            ValidirajUnosPredmeta();
        }
        private void ValidirajUnosPredmeta()
        {

            var nazivPredmeta = txtNazivPredmeta.Text;
            var predmet = db.Predmeti.FirstOrDefault(
                p => p.Naziv == nazivPredmeta);

            if (predmet == null)
            {
                var noviPredmet = new Predmet
                {
                    Naziv = txtNazivPredmeta.Text
                };
                if (string.IsNullOrWhiteSpace(nazivPredmeta))
                    MessageBox.Show("Uneseno polje ne može biti prazno");
                else
                {
                    db.Predmeti.Add(noviPredmet);
                    db.SaveChanges();
                    UcitajPredmete();
                }
            }
            else
                MessageBox.Show("Uneseni predmet vec postoji!");
        }
    }
}
