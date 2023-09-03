using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WindForms.Izvjestaji;
public partial class frmIzvjestaji : Form
{
    public frmIzvjestaji()
    {
        InitializeComponent();
    }

    private void frmIzvjestaji_Load(object sender, EventArgs e)
    {
        reportViewer1.RefreshReport();
    }
}
