## Data Sloj

Kreiramo klasu Student. Ukoliko želimo da imamo podršku za komplikovanije tipove podataka kao što su Image, moramo dodati biblioteku. 

**DLWMS.Data > Dependencies > Manage NuGet Packages... > System.Drawing.Common > Install**



## DataViewGrid

Želimo da omogućimo učitavanje studenata u DataGridView. 

Kreiramo Klasu Studenti, GodinaStudija, u našoj InMemoryDb kreiramo liste istih za Generisanje.  

```c#
 public static List<Korisnik> Korisnici = GenerisiKorisnike();
    public static List<Student> Studenti = GenerisiStudente();
    public static List<GodinaStudija> GodineStudija = GenerisiGodineStudija();

    private static List<GodinaStudija> GenerisiGodineStudija()
    {
        return new List<GodinaStudija>()
        {
            new GodinaStudija()
            {
                Id = 1,
                Aktivan = true,
                Oznaka = "1 - GODINA", 
                Opis = "Prva godina studija"
            },
            new GodinaStudija()
            {
                Id = 2,
                Aktivan = true,
                Oznaka = "2 - GODINA",
                Opis = "Druga godina studija"
            },
            new GodinaStudija()
            {
                Id = 3,
                Aktivan = true,
                Oznaka = "3 - GODINA",
                Opis = "Treca godina studija"
            },
            new GodinaStudija()
            {
                Id = 4,
                Aktivan = true,
                Oznaka = "4 - GODINA",
                Opis = "Cetvrta godina studija"
            }
        };
    }

    private static List<Student> GenerisiStudente()
    {
        return new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Aktivan = true, 
                Email = "sara.nur@edu.fit.ba", 
                Ime = "Sara", 
                Prezime = "Nur",
                BrojIndeksa = "IB20000",
                Lozinka = "Sara",
                DatumRodjenja = new DateTime(2000,4,16), 
                GodinaStudija = 1,
                Slika = null
            },
            new Student()
            {
                Id = 2,
                Aktivan = true,
                Email = "jasmin.nezic@edu.fit.ba",
                Ime = "Jasmin",
                Prezime = "Nezic",
                BrojIndeksa = "IB20001",
                Lozinka = "Jasmin",
                DatumRodjenja = new DateTime(2000,4,16),
                GodinaStudija = 1,
                Slika = null
            }
        };
    }

    private static List<Korisnik> GenerisiKorisnike()
    {
        return new List<Korisnik>()
        {
            new Korisnik()
            {
                Id = 1,
                Aktivan = true,
                Email = "admin@edu.fit.ba",
                Ime = "Administrator",
                Prezime = "FIT",
                KorisnickoIme = "admin",
                Lozinka = "admin",
            }
        };
    } 
```



U Load forme pozivamo metodu UcitajStudente, a UcitajStudente glasi

```c#
 private void UcitajStudente()
        {
            dgvStudenti.DataSource
        }
```

DataSource od nas očekuje da mu damo listu podataka koje će on prikazati u obliku tabele. Svaki red predstavlja jedan objekat. 



Naravno, u DataGridView ne trebamo prikazivati osjetljive podatke. On će također sam prepoznati različite tipove i tako ih prikazati. 



Također, u DataGridView bi mogli da omogućimo editovanje, brisane i dodavanje gdje će se promjene urađene u DataGridView automatski odraziti na izvor podatka. Naravno. to ćemo rijetko dozvoljavati i isključićemo sve opcije. 



Na Edit Columns editujemo koje kolone želimo da prikažemo. Ovdje ih imenujemo i dajemo im header ime. Nakon toga treba da kazemo gdje ce naši propertiji biti prikazani, dakle u koju kolonu u DataGridView. 



Da bi ih povezali, u Edit Columns ćemo u **Data > DataPropertyName** dijelu dodati ime propertija koji želimo da prikažemo. 



Ukoliko želimo da popunimo prazan prostor u DataGridView određenim kolonama, u Edit Columns možemo da dodamo za kolone koje želimo da popune prazan prostor, u **Layout > AutoSizeMode > Fill**



Da bi se promjene koje smo napravili u DataGridView zapravo prikazale, koristimo 

```c#
 public frmStudentiPretraga( )
        {
            InitializeComponent ();
            dgvStudenti.AutoGenerateColumns = false; //nemoj Auto Generisati kolone
        }
```

Na propertijima DataGridView > SelectionMode > FullRowSelection, na ovaj način selekcija neće biti na nivou jedne ćelije već jednog reda. 



## Dodavanje novog studenta

**FileDialog** - omogućava nam da učitamo neki file u formu 



### ComboBox Podaci

**DisplayMember** - ukoliko neka klasa ima više propertija,  omogućava nam da prikažemo jedan property



**ValueMember** - ono što želimo preuzeti nakon korisnikog odabira. To je najčešće ID. 



**SelectedIndex** - najsličniji našim indeksima koje smo savladali kod nizova. Dakle to je način organizovanja. Zahvaljujući ovom indeksu mi možemo znati da li je korisnik napravio selekciju. 



### Validacija Podataka

```c#
 private bool ValidanUnos( )
        {
            return Validator.ValidirajKontrolu (txtIme , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtPrezime , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (cbGodinaStudija , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtBrojIndeksa , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtEmail , err , Kljucevi.EmailVecPostoji) &&
                   Validator.ValidirajKontrolu (pbSlikaStudenta , err , Kljucevi.ObaveznaVrijednost);
        }

//Sada moramo da promijenimo metodu ValidirajKontrolu, ona nam je prije primala textbox. 
```

```c#
public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string kljuc)
    {
        var valid = true;
        if(kontrola is TextBox  && string.IsNullOrWhiteSpace(kontrola.Text))
            valid = false; //validacija nije validna ako uslov nije ispunjen
        else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex<0)
            valid = false;
        else if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
            valid = false;

        if(!valid)
            err.SetError(kontrola, Resursi.Get(kljuc));
        else 
            err.Clear();
        return valid;
    }
```



### Učitavanje slike

```c#
 private void btnUcitajSliku_Click( object sender , EventArgs e )
        {
            if( openFileDialog1.ShowDialog () == DialogResult.OK )
            {
                var putanja = openFileDialog1.FileName;
                pbSlikaStudenta.Image = Image.FromFile (putanja);
                lblPutanja.Text = putanja;
            }
        }
```

openFileDialog, otvara file explorer. Ukoliko korisnik odabere sliku prikaži je 



## Editovanje postojećeg studenata

Editovanje studenta ćemo omogućiti u DataGridView duplim klikom na red 

```c#
 private void dgvStudenti_CellContentClick( object sender , DataGridViewCellEventArgs e )
        {
            var OdabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
     //SelectedRowns - dobijamo niz selektovanih redova ukoliko to želimo da dozvolimo - ovdje uzimamo prvod odabranog iako je dozvoljeno više studenata
     //DataBoundItem - u ovom slučaju je to objekat koji je ispisan u tom redu. U našem slučaju to je Student 
        }
```





```c#
//Prvi nacin

public frmStudentiNovi( Student odabraniStudent ) : this //sa ovim this u ovom konstruktoru pozivamo i defualtni konstruktor
        {
            this.odabraniStudent = odabraniStudent;
        }

//Drugi nacin
//Uklonim skroz defaultni konstruktor, i u nas konstruktor stavimo da se moze poslati student ali i ne mora
 public frmStudentiNovi( Student odabraniStudent = null )
        {
            InitializeComponent ();
            this.odabraniStudent = odabraniStudent ?? new Student(); //ukoliko se nije poslao student, kreiraj nam novog studenta 
     //ovim smo dobili to da ne moramo vise nigdje reci new Student()
     //sada moramo da pristupamo odabraniStudent 
        }

```





```c#
  if( student.Id == 0 ) //ako je Id 0, znamo da ne postoji vec u bazi jer je tek instaniran u konstruktoru 
                {
                    student.Id = InMemoryDB.Studenti.Count () + 1; 
                    InMemoryDB.Studenti.Add (student);
      //jedino tada mu dodjeljujemo id i dodajemo ga u bazu. 
                }
```

