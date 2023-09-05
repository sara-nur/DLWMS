using DLWMS.WindForms.Intro;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Reporting.WinForms;
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
        ReportParameterCollection rpc = new ReportParameterCollection();
        rpc.Add(new ReportParameter("pBrojIndeksa", "IB150051"));
        rpc.Add(new ReportParameter("pImePrezime", "Sara Nur"));
        rpc.Add(new ReportParameter("pStatus", "redovan"));
        rpc.Add(new ReportParameter("pAkademskaGodina", "2022/23"));


        var tabela = new dsDLWMS.PolozeniDataTable();
        var rand = new Random();
        for (int i = 0; i < 5; i++)
        {
            var red = tabela.NewPolozeniRow();
            red.Rb = (i + 1).ToString();
            red.Naziv = $"Predmet {i + 1}";
            red.Ocjena = rand.Next(6, 15).ToString();
            red.Datum = DateTime.Now.ToBiHFormat();
            tabela.AddPolozeniRow(red);
        }
        var rds = new ReportDataSource();
        rds.Name = "DataSet1";
        rds.Value = tabela;

        reportViewer1.LocalReport.DataSources.Add(rds);
        reportViewer1.LocalReport.SetParameters(rpc);
        reportViewer1.RefreshReport();
    }
}
