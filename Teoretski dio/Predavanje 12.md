## Izvještaji

Što se tiče izvještavanja (reportinga) običnu tu govorimo o dvije različite komponente. 

1. **Komponenta za kreiranje izvještaja** 
   Ona je zadužena za dizajnerski aspekt tog izvještaja dakle omogućava nam da odredimo gdje će se određeni podaci prikazivati, da dodamo neke slike, tabele...
   Možemo je dodati preko ekstenzija > RDLC ekstenzija - to je Microsoftov] Report Designer 
2. **Prikaz izvještaja koji su generisani**
   Ne odnosi se samo na ono što mi vidimo na ekranu već nas prvenstveno interesuje i ono što mi možemo i nakon prikaza izvještaja, a to je da li ga možemo eksportovovati u različite formate, da li ga možemo printati...
   Instaliramo je preko NuGet Paketa > Manage NuGet Packages > ReportViewerCore.NETCore. Ova verzija nije upotpusnosti prilagođena novijim verzijama još uvijek. 

Što se tiče svih ovih komponenti oni se znatno razlikuju,a prvenstveno zavise od naših potreba.

Dodajemo novu formu (frmIzvjestaji) i novi report (rptUvjerenje).  

Na formu frmIzvjestaji, prevlacimo reportViewer, u ovoj verziji, on nije vidjljiv na Formi, prikazuje se slično kao errorProvider. 

Da bi nam se prikazao Report Viewer na formi, moramo da napravimo izmjene u InitializeComponent-u. 

```c#
		//
        // frmIzvjestaji
        // 
        AutoScaleDimensions =  new SizeF(8F, 20F) ;
        AutoScaleMode =  AutoScaleMode.Font ;
        ClientSize =  new Size(800, 450) ;
        //reportViewer moramo dodati kao kontrolu
        Controls.Add(reportViewer1);
        Name =  "frmIzvjestaji" ;
        Text =  "Izvjestaj" ;
        Load +=  frmIzvjestaji_Load ;
        ResumeLayout(false);

//Sada ce nam biti vidljiv na formi. 
```

Sada naš ReportViewer povezujemo sa našim reportom rptUvjerenje. To radimo tako što u Propertijima Report Viewera > LocalReport > ReportEmbededResource > Lokacija Reporta (U ovom slučaju DLWMS.WindForms.Izvjestaji\rptUvjerenje.rdlc).

Međutim naš rptUvjerenje idalje ne zna da on treba biti EmbededReport tako da na njegovim Propertijima > Build Action > Embeded resource. 

Na ovaj način smo omogućili dostupnost ovog izvještaja našem Report Viewer-u. 



Još jedna stvar koju trebamo ručno dodati za reportViewer, a inače automatski bude dodana je refresher. 

```c#
public partial class frmIzvjestaji : Form
{
    public frmIzvjestaji()
    {
        InitializeComponent();
    }

    private void frmIzvjestaji_Load(object sender, EventArgs e)
    {
        reportViewer1.RefreshReport();   //ovim omogućimo da se sve što smo dodali prikaže na formi. 
    }
}
```



Uvezivanje propertija sa reportom

```c#
    private void frmIzvjestaji_Load(object sender, EventArgs e)
    {
        ReportParameterCollection rpc = new ReportParameterCollection();
        rpc.Add(new ReportParameter("pBrojIndeksa", "IB150051"));
        rpc.Add(new ReportParameter("pImePrezime", "Sara Nur"));
        rpc.Add(new ReportParameter("pStatus", "redovan"));
        rpc.Add(new ReportParameter("pAkademskaGodina", "2022/23"));

        reportViewer1.LocalReport.SetParameters(rpc);
        reportViewer1.RefreshReport();
    }
```



Sada u naš folder Izvjestaji dodajemo DataSet. Cilj je da u ovaj DataSet napravilo replikaciju baze podataka. 

Za prikaz kreirane tabele u DataSetu, u ReportViewer-u dodamo tabelu. 

Omogućavanje prikazivanje tabele u Izvjestaju 

```c#
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
```

Kada smo kreirali tabelu, treba da taj dataset, iskoristimo za inicijalizaciju data sourca u samom izvjestaju. 

```c#
    var rds = new ReportDataSource();
    rds.Name = "DataSet1";
    rds.Value = tabela;

reportViewer1.LocalReport.DataSources.Add(rds);
```
