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
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WindForms.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }
        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void UcitajStudente(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? db.Studenti.Include(s => s.Spol).ToList();
        }
        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;

            Text = $"Red: {e.RowIndex} Kolona: {e.ColumnIndex}";

            Form forma = null;


            if ( odabraniStudent != null )
            {
                if ( dgvStudenti.CurrentCell is DataGridViewButtonCell )
                    forma = new frmStudentiPredmeti(odabraniStudent);
                else
                    forma = new frmStudentiNovi(odabraniStudent);
                forma.ShowDialog();
                UcitajStudente();
            }
        }
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            var frmStudent = new frmStudentiNovi();
            if ( frmStudent.ShowDialog() == DialogResult.OK )
                UcitajStudente();
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            //var pretraga = txtPretraga.Text.ToLower ();
            //var rezultat = new List<Student> ();
            //
            //foreach( var student in InMemoryDB.Studenti )
            //{
            //    if( student.Ime.ToLower ().Contains (pretraga) || student.Prezime.ToLower ().Contains (pretraga) || student.BrojIndeksa.ToLower ().Contains (pretraga) )
            //    {
            //        rezultat.Add (student);
            //    }
            //}
            //UcitajStudente (rezultat);

            //UcitajStudente(InMemoryDB.Studenti.Where(FiltrirajStudente).ToList());
            UcitajStudente(db.Studenti.Where(FiltrirajStudente).ToList());

        }
        private bool FiltrirajStudente(Student student)
        {
            var pretraga = txtPretraga.Text.ToLower();
            return student.Ime.ToLower().Contains(pretraga) ||
               student.Prezime.ToLower().Contains(pretraga) ||
               student.BrojIndeksa.ToLower().Contains(pretraga);
        }
    }
}
