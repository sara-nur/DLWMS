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

Sada naš ReportViewer povezujemo sa našim reportom rptUvjerenje. To radimo tako što u Propertijima Report Viewera > LocalReport > ReportEmbededResource > Lokacija Reporta (U ovom slučaju DLWMS.WindForms.Izvjestaji\rptUvjerenje.rdlc). Takodjer u Dock opciji stavljamo Fill tako da Uvjerenje bude vidljivo preko citave forme.

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
        red.Ocjena = rand.Next(6, 10).ToString();
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



### Korištenje anonimnih tipova 

Sa kljucnom rijeci new i viticastim zagradama te navodjenem setom parametara odnosno propertija njihovih vrijednosti mi mozemo kreirati anonimne objekte. 

Sada dodajemo tabelu kao listu objekata. Kada radimo s objektima nemamo pretjeranu podrsku od intelisens-a tako da treba voditi racuna o tome da li je sve ispravno napisano. 

Zelimo da kreiramo 5 predmeta i da njih posaljemo izvjestaju, u prethodnom primjeru smo imali DataSet, a sada imamo listu objekata. Jedino sto nam je jako bitno jeste da ti objekti koje budemo slali budu identicnih naziva kao oni koje smo naveli u izvjestaju. 

```c#
var tabela = new List<object>();
var rand = new Random();
for (int i = 0; i < 5; i++)
{
    tabela.Add(new
    {
        Rb = (i + 1).ToString(),
        Naziv = $"Predmet {i + 1}",
        Ocjena = rand.Next(6, 10).ToString(),
        Datum = DateTime.Now.ToBiHFormat(),
    });       
}
```



#### Prosljedjivanje podataka samom izvjestaju i konverzija



Idealno za ovaj izvjestaj je forma koji smo kreirali za potrebu studenata, a to je frmStudentiPredmeti - ona nam je sluzila za dodavanje podataka o novopolozenim predmetima. Prosiricemo ovu formu dodavanjem dugmica Printaj Uvjerenje. 

Klikom na Printaj Uvjerenje, nas zadatak bi bio da podatke o polozenim predmetima, a potencijalno o samom studentu, spojimo u jedan jedinstveni objekat i da posaljemo nasem reportu da on to rendera i prikaze kako treba. 

Dakle, sada klikom na ovo dugme cemo kreirati jedan novi objekat u koji cemo smjestiti: Broj indeksa, Ime i Prezime i Listu Predmeta. 

Mi to sve mozemo slati kao pojedinacne parametre, ali za ove svrhe nam sluze DTO objekti (Data Transfer Objects). 

Prvo kreiramo klasu: 

```c#
public class dtoUvjerenjeOPolozenim
{
    public string BrojIndeksa { get; set; }
    public string ImePrezime { get; set; }
    public string Status { get; set; }
    public List<StudentPredmet> Polozeni { get; set; }
}

```



Zatim u eventu btnPrintaj_Click, kreiramo objekat u kojem cemo spojiti sve: 

```c#
 private void btnPrintaj_Click(object sender, EventArgs e)
 {
     var podaciZaPrint = new dtoUvjerenjeOPolozenim()
     {
         BrojI
     }
 }
```

- BrojIndeksa, ImePrezime i Status preuzimamo iz studenta koji je trenutno koristen za prikaz podataka, to mozemo provjeriti u pocetku nase forme, u ovom slucaju to je `   public Student student;`
- Polozeni preuzimamo iz DataGridView-a koji se u ovom slucaju zove `dgvPolozeniPredmeti`

- Uobicanjena procedura prezuimanja: `            Polozeni = dgvPolozeniPredmeti.DataSource as List<StudentPredmet>,` medjutim, mi smo kao DataSource postavili Binding Source, a unutar bindinga smo postavili  stvarne podatke: 

  ```c#
      private void UcitajPolozenePredmete()
      {
          var binding = new BindingSource();
  
          binding.DataSource = db.StudentiPredmeti.Where(
              polozeni => polozeni.StudentId == student.Id).ToList();
  
          dgvPolozeniPredmeti.DataSource = binding;
      }
  ```

  Zbog toga cemo prvo morati u okvriru dgv-a odnosno u okviru njegovog DataSourca prvo da udjemo u binding, pa onda da iz bindiga preuzmemo data source. 

  ```
  Polozeni = (dgvPolozeniPredmeti.DataSource as BindingSource).DataSource as List<StudentPredmet>,
  ```



Sada ove podatke prosljedjujemo nasoj formi za print: 

```c#
var frmIzvjestaji = new frmIzvjestaji(podaciZaPrint);
```

frmIzvjestaji nema ovakav konstruktor pa cemo ga mi generisati 

```c#
    public frmIzvjestaji(dtoUvjerenjeOPolozenim podaciZaPrint)
    {
        _podaciZaPrint = podaciZaPrint;
        InitializeComponent();
    }

//premjestili smo InitializeComponent(); u ovaj konstruktor i uklonili smo defaultni jer nema potrebe da ga imamo - ne treba se moci koristiti bez slanja podataka 
```



Sada cemo u frmIzvjestaji, umjesto hard codiranih vrijednosti iskoristiti stvarne vrijednosti. Ovdje preuzimamo podatke iz forme gdje se nalaze podaci o studentima i polozenim predmetima. 

```c#
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
```

Sada ćemo postaviti frmGlavna formu da se otvara prva, a sve ostale forme da se otvaraju unutar nje. 

Zato je razvijien koncept koji se naziva MDI  i on se aktivira setovanjem propertija isMdiContainer. On je defaultno postavljen na false, kada ga postavimo na true promijeni se boja. 

Dodajemo menu strip, u koji dodajemo FIle > Studenti > Kraj rada. 

U Studenti, postavljamo da se pokrece forma frmStudentiPretraga. 

```c#
       private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentiPretraga = new Studenti.frmStudentiPretraga();
            studentiPretraga.MdiParent = this; //ovim smo naznacili da je parent forma zapravo frmGlavna tj forma u kojoj se trenutno nalazi.
            studentiPretraga.Show();

        }
```

Ono sto je bitno u interakciji MDI parent-a je da se svakoj novoj formi moramo naznaciti ko joj je  parent forma. Te onda govorimo formi da se prikaze.
