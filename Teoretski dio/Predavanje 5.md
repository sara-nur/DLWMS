## InMemoryDB

```c#
  
private static List<Korisnik> GenerisiKorisnike()
     {
    var korisnik = new Korisnik()
            {
                Id = 1,
                Aktivan = true,
                Email = "admin@edu.fit.ba",
                Ime = "Administrator",
                Prezime = "FIT",
                KorisnickoIme = "admin",
                Lozinka = "admin",
            };
            
            var Lista = new List<Korisnik>();
            Lista.Add(korisnik);
            return Lista;
     } 

//Ovu logiku jednostavnije možemo napisati na sljedeći način


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

//Vrati novu listu Korisnika i pritome unutar te liste odmah dodaj novog korisnika sa sljedecim vrijednostima njegovih propertija odnosno atributa. 
```

Kod prijave, kreirali smo formu za unos korisničkog imena i lozinke. Prilikom klika na dugme Prijava treba da provjerimo da li su korisnicko ime i lozinka validni 

```c#
private void btnPrijava_Click( object sender , EventArgs e )
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            
            if (!string.IsNullOrWhiteSpace(korisnickoIme) &&
                !string.IsNullOrWhiteSpace(lozinka)) //razlicito od prazno
            {
                //sada provjeravamo da li se podaci koje je korisnik unio nalaze u bazi podataka 
				  foreach (var korisnik in InMemoryDB.Korisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme &&
                        lozinka == korisnik.Lozinka)
                    {
						 if (korisnik.Aktivan)
                            MessageBox.Show($"Dobrodosli {korisnik}");
                        else
                            MessageBox.Show($"{korisnik} vas nalog nije aktivan")
                  
                    }

                }
            } 
            	/* 
            	koristimo string.IsNullOrWhiteSpace jer ukoliko budemo radili 
            	klasičnu provjeru sa korisnickoIme!="", tada ako korisnik
                unese razmak, uslov će biti zadovoljen što ne želimo da se
				desi 
				*/
            


        }
```



## Resursi i ključevi

Umjesto pisanja ovih MessageBox poruka, mozemo da kreiramo resource file u kojem cemo unijeti naziv kljuca npr DobroDosli koji ima vrijednost Dobro nam dosli. Na taj nacin mozemo ove poruke korisiti na vise mjesta. 

Nakon kreiranja resource file-a potrebno ga je dodati, u nasem slucaju u frmPrijava. 

Mozemo kreirati zasebnu klasu Resursi.

```c#
public class Resursi
    {

        private static ResourceManager Menadzer = new ResourceManager (Kljucevi.NazivResourceFajla , Assembly.GetExecutingAssembly ());

        public static string Get(string kljuc)
        {
             return Menadzer.GetString(kljuc);
        }

    }

    public class Kljucevi
    {
        public const string NazivResourceFajla = "DLWMS.WindForms.Resource1";
         public const string DobroDosli = "DobroDosli";
        public const string NalogNijeAktivan = "NalogNijeAktivan";
    }

//ostatak koda 
//poziv reusursa
    
if (korisnik.Aktivan)
     MessageBox.Show($"{Resursi.Get(Kljucevi.DobroDosli)} {korisnik}");
else
     MessageBox.Show($"{korisnik} {Resursi.Get (Kljucevi.NalogNijeAktivan)}");
                    }
//ostatak koda

```

Na ovaj nacin, poruke koje zelimo da koristimo na vise mjesta mozemo da smjestimo u resurs fajs, kreiramo klasu resursi i kljuce. Kada zelimo da promjenimo sadrzaj poruke, to radimo samo na jednom mjestu. Ovo je posebno korisno kada imamo jako puno poruka

Također

```c#
[0], Vas korisnicki nalog nije aktivan //sadrzaj u resource file-u, u ovom slučaju, [0] znači da će vrijednost prvog parametara kojeg pošaljemo određenoj metodi biti zamjenjeno sa ovom lokacijom [0]. 

Da pošaljemo korisnika, [0] bi bila zamjenjena sa korisnickim imenom npr
```



### MessageBox

Sa MessageBox-om postoji 21 način da pošaljemo vrijednosti parametara na osnovu čega će on prilagoditi svoj ispis. 

npr.

```c#
  MessageBox.Show ($"{Resursi.Get (Kljucevi.DobroDosli)}{korisnik}",
                        Resursi.Get (Kljucevi.Informacija),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
```



### Validacija Podataka

Kada zelimo da naznacimo korisniku da nije unio podatke u polje koje je obavezan, mozemo koristiti **errorprovider**.

Na formu prevučemo errorProvider iz Toolboxa.Promijenićemo ime na err

```c#
 if( string.IsNullOrWhiteSpace (korisnickoIme) )
            {
                err.SetError(txtKorisnickoIme, " PORUKA ");
                return false;
            }

            if (string.IsNullOrWhiteSpace(lozinka) )
            {
                err.SetError (txtLozinka , " PORUKA ");
                return false;
            }
            err.Clear(); //ovo uklanja prethodne errore ukoliko se uslov ispuni, medjutim, da bi ovo radilo trebali bi imati neke if elsove. Da to ne bi radili, ovo sve cemo objediniti cijelu ovu logiku u jednu metodu kojom cemo slati kontrolu koja bi trebala zadovoljiti odredjeni uslov

            return true;
```



```c#
     private bool ValidanUnos( )
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, err, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(txtLozinka, err, Kljucevi.ObaveznaVrijednost);
        }
     //u metodi ValidirajKontrolu zelimo da validiramo razlicite vrste kontrola, ne samo textbox, medjutim za sad cemo ostaviti textbox

    public class Validator
    {
        public static bool ValidirajKontrolu(TextBox textBox, ErrorProvider err, string kljuc)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                 err.SetError(textBox, Resursi.Get(kljuc));
                 return false;
            }
            err.Clear();
            return true;
        }
    }

//naravmo u ResourceFile i u Resurse dodajemo ObaveznaVrijednost
```

Zatim želimo da kreiramo klasu u kojoj ćemo držati sve podatke koji su nam često potrebni 

```c#
 public class DLWMSApp
    {
        public static Korisnik Korisnik; //cuva podatke trenutno logiranog korisnika, u nasu formu dodamo 
     //DLWMSApp.Korisnik = korisnik;
     //new frmGlavna().Show(); //takodjer mozemo ucitati narednu formu ako sve prodje kako treba
    }
```



### Generisanje lozinke 

```c#
 private string GenerisiLozinku(int brojZnakova=10)
        {
            var generisanaLozinka = "";
            var karakteri = "qwertyuiopasdfghjkl;'zxcvbnm,-1234567890-=QWERTYUIOPASDFGHJKLČĆŽĐŠŠYXCVBNM";
            var rand = new Random();
            for (int i = 0; i < brojZnakova; i++) 
            {
                var lokacija = rand.Next(0, karakteri.Length); // 0-60 npr , ukoliko je rand vrijednost 2 on ce otici u karakteri i uzeti vrijednost koja se nalazi na lokaciji 2, u ovom slucaju to ce biti slovo "e". Ovo ce se ponavljati dok ne dodje do broja znakova 
                generisanaLozinka += karakteri[lokacija];
            }

            return generisanaLozinka;
        }
```

