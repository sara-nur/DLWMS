## Database first 

Kada je baza podataka razvijena prvo ili već postoji, a na osnovu toga treba da generišemo klase.



## Code first 

Prvo napišemo klase, pa na osnovu toga kreiramo bazu podatka. 



## Korelacija s bazom podatka 

npr. 

```c#
 public class Spol
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }

//Sada u studenta mozemo dodati klasu Spol da bi napravili relaciju 
public int SpolId {get; set; } //ovakav pristup cemo praktikovati 
public Spol Spol { get; set; }

//Imamo oba propertija, alat s kojim pristupamo bazi ce vjerovatno imati mogucnost da automatski ucita i objekat tipa spol na osnovu SpolId propertija. 

//To znaci da kada zelimo da ucitamo jednog studenta, mi preko SpolId pitamo za njegov Id, zatim idemo u tu tabelu, pokupimo Naziv odnosno oznaku spola i citav taj objekat ucitamo u property Spol. Na taj nacin necemo ucitavati Id korisniku vec objekat.  

//Mi zelimo da cuvamo samo Id referentnog podatka 
```

Ovakav pristup se naziva i **Navigacijski Property** zato što nam omogućavaju da preko studenta odemo u objekat tipa spol i da pristupimo nazivu. 



Nismo obavezni imamo i SpolId property i property referentnog tipa, ali nam je ovo korisno ukoliko hocemo da preko jednog objekta direktno pristupamo citavim podacima iz drugih referentnih tabela. 



## Entity Framework - naming konvencije

Konvencije koje nam omogućavaju da automatski prepoznaju koji id s kojim propertijem. 

1. Davanje identičnog imena kao i propertiju referentne klase sa dodatkom Id. (Kao gore što smo imali property koji se zove Spol tipa Spol i SpolId tipa int). 



### Combobox 

**SelectedIndex** - vraća redni broj odnosno index 

**SelectedValue** - vraća vrijednost koju smo mi označili kao value member 

**Text** - vraća Display Membera koji mi označimo 

**SelectedItem** - vraća kompletan odabrani objekat 

```c#
 student.Spol = cmbSpol.SelectedItem as Spol;

//u ucitaj podatke omogucavamo prikaz objekta spol
cmbSpol.SelectedItem = student.Spol;

//Da bi bio spol odabran kreiramo i UcitajSpolove

 private void UcitajSpolove()
        {
            cmbSpol.DataSource = InMemoryDB.Studenti;
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }


//Dodavanje liste u InMemoryDB
  public static List<Spol> Spolovi = GenerisanjeSpolova();

    private static List<Spol> GenerisanjeSpolova()
    {
        return new List<Spol>()
          {
              new Spol() {Id=1, Naziv="*****"},
              new Spol() {Id=1, Naziv="Ženski"},
              new Spol() {Id=1, Naziv="Muški"}
          };
    }
```



Već sada primjećujemo repeticiju prilikom učitavanja podataka. Možemo napraviti posebnu klasu npr. DataLoader za učitavanje podatka



```c#
public class DataLoader
    {
        public static void ToComboBox<T>(ComboBox comboBox, List<T> dataSource,
            string displayMember = "Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

        }
    }

//poziv
 private void UcitajSpolove()
        {
            DataLoader.ToComboBox(cmbSpol, InMemoryDB.Spolovi);
            //cmbSpol.DataSource = InMemoryDB.Spolovi;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }
```



## Relacije 

```c#
  public class PolozeniPredmet //sluzi kao medjutabela da bi prosirili informacije o Polozenim Predmetima 
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjene { get; set; }
    }
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }

 public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>(); // u konstruktoru pripremamo listu za koristenje
        }
```

Napravili smo posebnu formu za ucitavanje Polozenih Predmeta za oznacenog studenta. Kada korisnik klikne na bilo koju kolonu osim button na Predmet koloni, imace mogucnost da mofikuje vrijednosti. 

Kada korisnk odabere Polozeni button u Koloni predemti, otvara se nova forma sa polozenim predmetima. 



## Dodavanje Predmeta

```c#
 private bool PredmetVecDodat()
    {
        var odabraniPredmet = cmbPredmet.SelectedItem as Predmet;
        return odabraniStudent.PolozeniPredmeti.Where(
            polozeni => polozeni.Predmet.Id == odabraniPredmet.Id)
            .Count() > 0;
    }
```

Želimo da onemugućimo višestruko dodavanje istog predmeta. 

```c#
 if (PredmetVecDodat())
        {
            var poruka = Resursi.Get(Kljucevi.PodatakVecDodat);
            var ispis = string.Format(poruka, predmet.Naziv);
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

//Provjera validnosti i ispis odgovarajuce poruke.
```



## Exception za form

```c#
private void UcitajPolozenePredmete()
    {
        var binding = new BindingSource();
        binding.DataSource = odabraniStudent.PolozeniPredmeti;
        dgvPolozeniPredmeti.DataSource = binding;
    }
```

Ako se pojavi ovaj exception, potrebno je da upakujemo datasource u bindingsource, razlika je u tome što odabraneStudente ili bilo koju listu ne dodjeljujemo direktno DataGridView već prvo tu listu dodjelimo kao DataSource objektu tipa BindingSource jer je on mnogo efikasniji u handlanju DataSourcovima ovih kontrola. 

Sada to dodjeljumo preko wrapper klase, ona čini pakovanje i služi za izbjegavanje exceptiona. 
