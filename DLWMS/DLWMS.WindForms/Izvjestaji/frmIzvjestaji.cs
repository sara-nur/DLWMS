using DLWMS.WindForms.Intro;
using DLWMS.WindForms.Studenti;
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
    private dtoUvjerenjeOPolozenim podaci;


    public frmIzvjestaji(dtoUvjerenjeOPolozenim podaciZaPrint)
    {
        InitializeComponent();
        podaci = podaciZaPrint;
    }

    private void frmIzvjestaji_Load( object sender , EventArgs e )
    {
        ReportParameterCollection rpc = new ReportParameterCollection ();
        rpc.Add (new ReportParameter ("pBrojIndeksa" , podaci.BrojIndeksa));
        rpc.Add (new ReportParameter ("pImePrezime" ,podaci.ImePrezime));
        rpc.Add (new ReportParameter ("pStatus" , podaci.Status));
        rpc.Add (new ReportParameter ("pAkademskaGodina" , podaci.AkademskaGodina));


        //var tabela = new dsDLWMS.PolozeniDataTable ();
        //var rand = new Random ();
        //for(int i = 0; i < 5; i++)
        //{
        //    var red = tabela.NewPolozeniRow ();
        //    red.Rb = (i + 1).ToString ();
        //    red.Naziv = $"Predmet {i + 1}";
        //    red.Ocjena = rand.Next (6 , 10).ToString ();
        //    red.Datum = DateTime.Now.ToBiHFormat ();
        //    tabela.AddPolozeniRow (red);
        //}

        //var rds = new ReportDataSource();
        //rds.Name = "DataSet1";
        //rds.Value = tabela;
        //reportViewer1.LocalReport.DataSources.Add(rds);


        //var tabela = new List<object>();
        //var rand = new Random();
        //for (int i = 0; i < 5; i++)
        //{
        //    tabela.Add(new
        //    {
        //        Rb = (i + 1).ToString(),
        //        Naziv = $"Predmet {i + 1}",
        //        Ocjena = rand.Next(6, 10).ToString(),
        //        Datum = DateTime.Now.ToBiHFormat(),
        //    });       
        //}

        var tabela = new List<object>();
        var rand = new Random ();
        for (int i = 0; i < podaci.Polozeni.Count; i++)
        {
            tabela.Add(new
            {
                Rb = (i+1).ToString(),
                Naziv = podaci.Polozeni[i].Predmet.Naziv,
                Ocjena = podaci.Polozeni[i].Ocjena.ToString(),
                Datum = podaci.Polozeni[i].Datum.ToBiHFormat(),
            });
        }

        var rds = new ReportDataSource ();
        rds.Name = "DataSet1";
        rds.Value = tabela;
        reportViewer1.LocalReport.DataSources.Add (rds);

        reportViewer1.LocalReport.SetParameters (rpc);
        reportViewer1.RefreshReport ();
    }
}
