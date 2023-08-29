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

    }
}
