## Delegati & Eventi

**Delegat** je potpis metode, odnosno pravilo kako ona mora da izgleda, a **Event** je niz pokazivača na metodu. 

Za pravljenje delegata koristimo ključnu riječ **delegate**, a nakon toga navodimo potpis. 

```c#
delegate void PotpisMetode(string s); //Kreirali smo neki pokazivac koji se zove PotpisMetode koji može pokazivati na bilo koju metodu koja ne vraća ništa i prihvata neku string poruku. 
```

npr

```c#
 public frmDelegati( )
        {
            InitializeComponent ();

            PotpisMetode p = PrvaGodina; //sada smo p usmjerili na prvu godinnu
        }

        delegate void PotpisMetode(string s);

        private void PrvaGodina(string poruka)
        {
            MessageBox.Show($"PRVA GODINA -> {poruka}");
        }
```

Delegat je definisao **pravilo** koje moraju poštovati sve metode koje žele biti dio nekog događaja. 

Sada kreiramo neki event. Za kreiranje eventa koristimo ključnu riječ **event**. 

Prva stvar kod događaja koju trebamo uraditi je navesti po kojem pravilu će metode biti dodavane odnosno koje pravilo metode moraju ispoštovati da bi bile dodate u ovaj događaj odnosno da bi ih ovaj događaj obavijestio da se on desio. 

```c#
event PotpisMetode DLWMSNotifikacije);

//U ovom slučaju, za dodavanje u niz pokazivača DLWMSNotifikafcije, mora poštovati pravilo koje se zove potpis metode. Također, svaka metoda koja želi biti niza DLWMSNotifikacije mora odgovarati pravilu PotpisMetode. 

```

Dodavanje metoda u određeni događaj, navedemo ime Događaja, i koriteći operator += mi ćemo željenu metodu dodati u listu onih kojih će biti pozvane kada se taj događaj desi.

```c#
DLWMSNotifikacije += PrvaGodina;
//Dakle ovdje prvo prolazimo kroz delegat PotpisMetode. Provjerava se da li je metoda PrvaGodina tipa void i prihvata string, ukoliko da dodaje se u niz DLWMSNotifikacije. 
```

Sada možemo kreirati i druge metode za potrebe testiranja niza DLWMSNotifikacije i delegata. 

```c#
  public frmDelegati( )
        {
            InitializeComponent ();
            PotpisMetode p = PrvaGodina;
            DLWMSNotifikacije += PrvaGodina;
            DLWMSNotifikacije += DrugaGodina;
            DLWMSNotifikacije += TrecaGodina;
        }

        delegate void PotpisMetode(string s);
        event PotpisMetode DLWMSNotifikacije;

        private void PrvaGodina(string poruka)
        {
            MessageBox.Show($"PRVA GODINA -> {poruka}");
        }

        private void DrugaGodina(string poruka)
        {
            MessageBox.Show ($"DRUGA GODINA -> {poruka}");

        }

        private void TrecaGodina( string poruka )
        {
            MessageBox.Show ($"TRECA GODINA -> {poruka}");

        }
```

Sada nam ostaje da označimo da se određeni događaj desio odnosno kada mi želimo da se dese ove DLWMSNotifikacije što će podrazumijevati poziv svih ovih metoda. 

Možemo kreirati button za provjeru. 

```c#
 private void button1_Click( object sender , EventArgs e )
        {
            DLWMSNotifikacije("Danasnja nastava iz predmeta PRIII ce biti odgodjena...");
        }

//Sada će se ovaj event okinuti klikom na kreirano dugme. Svaka metoda zahtjeva neki string, pa smo svakoj od metoda poslali navedeni string.
```

Također, korištenjem checkbox-ova možemo da ukinemo pretplatu na određenu metodu unutar samog eventa ukoliko je to nešto što želimo. 

```c#
  private void cbPrvaGodina_CheckedChanged( object sender , EventArgs e )
        {
            if (cbPrvaGodina.Checked)
                DLWMSNotifikacije += PrvaGodina; //ovjde uključujemo metodu ukoliko je checkbox označen
            else 
                DLWMSNotifikacije -= PrvaGodina; //ovdje je uklanjamo ukoliko checkbox nije označen
        }
```

S obzirom da će nam se ovaj kod ponavljati za svaku metodu koju želimo da dodamo ili ukinemo iz eventa, najbolje je ovo izdvojiti u posebnu metodu. 

```c#
private void PretplataNaDogadjaj(object sender, PotpisMetode potpis)
    //sender ce biti cbPrvaGodina, cbDrugaGodina...
    //potpis ce biti metoda PrvaGodina, DrugaGodina...
        {
            if( (sender as CheckBox).Checked ) //posto znamo da ce ovdje sender biti checkbox, mozemo ga posmatrati kao takvog tako da imamo pristup Checked()
                DLWMSNotifikacije += PrvaGodina;
            else
                DLWMSNotifikacije -= PrvaGodina;
        }

//a poruku preuzimamo iz textbox-a
private void button1_Click( object sender , EventArgs e )
        {
            DLWMSNotifikacije (txtPoruka.Text);
        }
```

Problem se može pojaviti kada želimo da pošaljemo poruku, a ne označimo nijednu metodu. Tada ćemo dobiti nullReferenceException. Da bi ovo izbjegli možemo korisiti Invoke. 

```c#
private void button1_Click( object sender , EventArgs e )
        {
            DLWMSNotifikacije?.Invoke (txtPoruka.Text); //sa Invoke nam dopusta da provjeravamo da li je null 
        }
```



## Function : Func

Function - gotovi delegat, template koji nam omogućava da preko njega definišemo pravilo na 17 različitih načina, odnosno sa 17 parametara što uključuje i povratnu vrijednost. 

npr.

```c#
Func<int,int> func = Saberi;
    //prvi clanovi su ulazni parametar, a zadnji clan je povratna vrijednost. 
    //Ovo nam omogucava da kreiramo pokazivac odnosno delegat na bilo koju metodu koja vraca integer i prima jedan integer

Func<int, float, string, int> func2 = Test;

int Test(int a, float b, string c) { return 0;} 

//pomocu ovog Func, to nam je skraćeni način koji nam omogućava da kreiramo delegat odnosno pokazivač na neku metodu. 

//Ovo nam je bitno u slučaju kada nemamo svoje delegate, možemo da koristimo Func 
```

Function nam daje širinu da propišemo izgled metode koja će biti pozvana za svakog člana. npr. u primjeru DLWMS sistema, ako želimo da sortiramo studente, function nam omogućava da ih sortiramo po indeksu, prosjeku ocjena, imenu ili bilo čemu drugom. 



## Action : Action

Pored Functiona imamo i Action koji ima generiču i običnu verziju. On je prvenstveno namjenjen void metodama ali im mi možemo definisati neke ulazne parametre. 



## Enumerisanje



```c#
private void YieldDemo()
        {
            Kandidat kandidat = new Kandidat();
            foreach (var ocjene in kandidat) //ovo ne bi bilo moguce bez koristenja interface-a IEnumerator 
                //uzimamo ocjenu koja se u okviru objekta kandidat sto ce ukljucivati poziv metode GetEnumerator, i svaki put kada mi zelimo da pristupimo ocjeni, varijabla ocjena ce biti inicijalizana sa narednom ocjene iz liste
              //odstupanje od naseg znanja je da kada kazemo return, ocekujemo da se neka metoda zavrsi i u ovom slucaju vrati ocjena[0], ona ce umjesto toga prvo otici u metodu GetEnumerator vratice 4 pa se vratiti u ovu for petlju pa ponovo otici i vratiti sada drugi clan niza sto je 5 i tako sve dok ne prodje citav niz ocjene. Dakle nastavlja od lokacije na kojoj je stalo. 
                
            {
                
            }
        }

public class Kandidat
    {
        List<int> ocjene = new List<int>() {4,5,3,4,5,3,3,4};

        public IEnumerator GetEnumerator()
        {
            
            
            for (int i = 0; i < ocjene.Count; i++)
            {
                yield return ocjene[i] ; //return ocjene[O]
                
              
            }
        }
    }
```

Ključna riječ yield nam omogućava da nastavimo izvršenje u ovom slučaju iteracije na mjestima gdje smo stali prilikom prošlog poziva 

Da nema yielda, svaki put bi vratili vrijednost na lokaciji 0 i time bi for petlja izgubila smisao. 

To nam omogućava da ne moramo svaki put od početka pregledati podatke 

Pregledamo ocjene kada dođemo do njih. Radimo enumerisanje u momentu kada nam ti podaci zatrebaju. 