## const & readonly

**const** - mora biti inicijalizovan odmah

**readonly** - možemo ih inicijalizovati u konstrukutoru nakon čega oni postoji konstante. Nakon inicijalizacije se oni ne mogu mijenjati. 

```c#
   public const string Naziv = "DLWMS";
        public readonly string KonekcijskiString;

        public Konfiguracija(string konekcijskiString)
        {
            KonekcijskiString = konekcijskiString;
        }
```



## nasljeđivanje, is, as

Logika nasljeđivanja je kao i u C++, ukoliko nam nešto nije dostupno jer nije javno, to možemo uraditi tako što ćemo pozvati konstruktor bazne klase. S razlikom da se prilikom poziva bazne klase u headeru umjesto imena klase piše ključna riječ base. U C++ klasa je mogla da naslijedi više klasa, u C# možemo naslijediti samo jednu baznu klasu!

Primjer:

```c#
 public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }
    }


  public class DLStudent : Osoba
    {
        public string Indeks { get; set; }

        public DLStudent(string indeks, string ime, string prezime)
            :base(ime,prezime)
        {
            Indeks = indeks;
        }

    }
```

```c#
private static void Nasljedjivanje()
        {
            Osoba osoba = new Osoba("Sara", "Prez");
            Osoba dlStudent = new DLStudent("IB23543", "Sara", "Nur");
        }

//Sada pomocu nasljedivanja, Osoba moze pokazivati na Osobu ali i na DLStudenta jer DLStudent nasljedjuje klasu Osoba. 
```



**is, as** - slični dynamic cast operatoru - one vrše provjeru tipa i konverziju 

Da bi izbjegli null reference exception, 

```C#
     if(osoba is DLStudent ) // da li je osoba DLStudent 
     	{
            var dlStudent = osoba as DLStudent; //osobu posmatramo kao DLStudent
        }
```

Ovdje provjeravamo da li je osoba DLStudent. Ukoliko jeste, posmatraj je kao DLStudenta

Sada možemo da pristupimo i manipulišemo vrijednostima propertija 



## abstract class (metode, virtual)

**abstract class** - ne da nam da kreiramo objekte klase kada je abstraktna 

```c#
  public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }

    }
//sada ne mozemo kreirati objekte tipa Osoba, ali mozemo kreirati objekte koje nasljedjuju klasu Osoba, npr DLStudent. 
```



**Abstraktna metoda** - kada neku metodu proglasimo abstraktnom, to znači da svaku izvedenu klasu tjeramo da implementira tu metodu. Također, da bi metodu proglasili abstraktnom, klasa mora biti abstraktna. 



```c#
  public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }

              public abstract string PredstaviSe(); //sada svaka klasa koja nasljedjuje klasu Osoba mora da implentira metodu PredstaviSe()

    }

//u klasi DLStudent

  public class DLStudent : Osoba
    {
        public string Indeks { get; set; }

        public DLStudent(string indeks, string ime, string prezime)
            :base(ime,prezime)
        {
            Indeks = indeks;
        }

      //sada obavezno moramo da implentiramo ovu metodu jer je u baznoj klasi navedena kao abstraktna. 
        public override string PredstaviSe()
        {
            return $"{Indeks} - {Ime} - {Prezime}";
        }
    }
```



**Virtualna metoda** - slična je abstraktnoj metodi s tim da abstraktna metoda tjera izvedene klase da je implementiraju, a kod virtualne metode je očekivano ali nije obavezno. 

```c#
  public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }

        public abstract string PredstaviSe();


        public virtual string Info()
        {
            return $"{Ime} {Prezime}";
        }

    }
    
    //u klasi DLStudent
    
    public class DLStudent : Osoba
    {
        public string Indeks { get; set; }

        public DLStudent(string indeks, string ime, string prezime)
            :base(ime,prezime)
        {
            Indeks = indeks;
        }

        public override string PredstaviSe()
        {
            return $"{Indeks} - {Ime} - {Prezime}";
        }
        
        //nismo obavezni da implentiramo metodu Info, ali mozemo ukoliko zelimo jer je ona u baznoj klasi proglasena virtuelnom. 

        public override string Info()
        {
            return $"{Indeks} - {base.Info()}";
        }
    }
    
    
```



## Interface

**Interface ** -u programiranju nam služe u kontekstu osiguranja određenih članova, propertija, atributa, metoda... Interface definiše ključna riječ interface, i nazivi interface se pišu sa velikim slovom I na početku, ovaj standard nam pomaže da lako prepoznamo interface. Ideja interface-a je da definišemo određeni set članova koje će klasa morati da posjeduje odnosno implementira. 



```c#
	public interface IKorisnik
    {
        string KorisnickoIme { get; set; }
        string Lozinka { get; set; }
        bool Prijava();
    }

    public class Korisnik : IKorisnik //Klasa Korisnik implenetira interface IKorisnik
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public bool Prijava( )
        {
            throw new NotImplementedException ();
        }
    }
```



```c#
IKorisnik korisnik = new Korisnik(); //s obzirom da klasa Korisnik implementira interface IKorisnik, imamo pristup svim propertijima koje se nalaze u interface-u IKorisnik
```

Kada neka klasa implementira interface, ona može da naslijedi neku klasu. npr. 

```c#
public class Korisnik: Osoba, IKorisnik{} // ovo je moguće jer interface nije klasa i ne vrši se nasljeđivanje već implementacija interface-a. Također za razliku od nasljeđivanje klasa, implementacija interface-a nema ograničenje, možemo implementirati koliko želimo interface-a. 
```



### Nasljeđivanje interface-a

Ukoliko želimo da imamo metode koje se odnose samo na određene klase, a ne na sve koje implementiraju neki interface, možemo raditi nasljeđivanje interface-a. npr. 

```c#
    public interface IKorisnik
    {
        string KorisnickoIme { get; set; }
        string Lozinka { get; set; }
        bool Prijava();
    }                           

    public interface IStudent
    {
        bool PrijaviIspit();
    }
```

Sada imamo pristup svim propertijima i metodama koje IKorisnik interface posjeduje i također možemo napraviti nove metode za interface IStudent. 

```c#
    private static void Interfejsi()
        {
            IKorisnik korisnik = new Korisnik();
            IKorisnik dlStudent = new DLStudent("IB234532", "Denis", "Mare");
//sada mozemo da kreiramo dlStudent tipa IKorisnik koji pokazuje na DLStudenta iako DLStudent ne inpmentira interface IKorisnik vec Istudent. Ovo je moguce jer interface IStudent nasljedjuje interface IKorisnik 
        }
```



```c#
   IKorisnik korisnik = new Korisnik();
   IKorisnik dlStudent = new DLStudent("IB234532", "Denis", "Mare");

   PrijaviKorisnika(korisnik);
   PrijaviKorisnika(dlStudent);

	private static void PrijaviKorisnika(IKorisnik korisnik)
        {
            throw new NotImplementedException();
        }

//sada kao parametar mozemo da saljemo i interface. Ovdje se zahtjeva bilo ko ko na direktan ili indirektan nacin implementira interface IKorisnik. Ovdje mozemo poslati bilo koji objekat koji implementira IKorisnik ili IStudent, jer IStudent nasljedjuje IKorisnik. 
```



## Logiranje

Obično se na ulaznoj metodi, na početku rada aplikacije dostavlja informacija ko je zadužen za logiranje.

npr. u Bankarskom okruzenju to bi bile transakcije, prijave, odjave, i mnogi drugi detalji. 

Lokacije na kojima se mogu izvrsiti logiranja: 

1. **Baza podataka**
2. **File-ovi**
3. **Web servis (API)**

Ukoliko imamo mnostvo aplikacija zelimo na jednom mjestu da objedinimo sva logiranja i da imamo konstantan monitoring logiranja u okviru naseg API-ja. 



```c#
public interface ILogger
    {
        void Log(object message);
    }

public class DBLogger : ILogger
  {
    private const string putanja = "Server = 192.168.1.10;MyDataBase = DLWMS";
        public void Log(object message)
        {
            throw new NotImplementedException();
        }
  }
```

Kada neko pošalje poruku kroz Log metodu, mi bi tu poruku trebali da pohranimo u bazu podataka. 

Pohrana u bazu bi vjerovatno podrazumijevala neki objekat koji bi znao kako da komunicira s bazom. 

```c#
  // Baza podataka
    public class DBLogger : ILogger
    {
        private const string Putanja = "Server = 192.168.1.10;MyDataBase = DLWMS";

        public void Log(object message)
        {
            Console.WriteLine($"DBLog -> {Putanja}\nData-> {DataExtractor.GetData(message)}");
        }
    }

    // File Loger
    public class FileLogger : ILogger
    {
        private const string Putanja = @"c:\logs\dlwms_log.txt";

        public void Log( object message )
        {
            Console.WriteLine ($"FileLog -> {Putanja}\nData-> {DataExtractor.GetData (message)}");
        }
    }

    // Web servis - API
    public class WebServisLogger : ILogger
    {
        private const string Putanja = @"uri:log.fit.ba;token: 321321-sdf1312sdf0";

        public void Log( object message )
        {
            Console.WriteLine ($"WebServisLog -> {Putanja}\nData-> {DataExtractor.GetData (message)}");
        }
    }
```

Informaciju o tome ko je zaduzen za logiranje, obicno dobijemo na pocetku. 

Primjeri linformativnih poruka koje mi zelimo da logiramo 

```c#
   private static ILogger _logger;
        public static void Pokreni(ILogger logger ) 
        {
            _logger = logger;
            // ono sto smo prihvatili kao objekat koji  je zaduzen za logiranje, mi zelimo da sacuvamo referencu na njega u okviru naseg _loggera
            Logiranje();
        }     

	private static void PrijaviKorisnika(IKorisnik korisnik)
        {
            _logger.Log("Korisnik prijavljen...");
        }

   private static void Interfejsi()
        {
            _logger.Log("Savladali smo interfejse...");
        }
```

Mi u ovom momentu nemamo predstavu ko će raditi logiranje, dakle da li će biti pohranjeno u bazu, u file ili na neki web servis nas ne zanima. Mi smo dobili nekoga ko ima log metodu i mi ćemo je pozivati kad nam ona bude potreba. 

```c#
  public static void Main(string[] args )
        {
            MainP3.Pokreni(new DBLogger()); //zahvaljujuci interfaceima na jednom mjestu definisemo ko ce biti zaduzen za logiranje, a aftektira cijelu aplikaciju 
      
           // MainP3.Pokreni(new FileLogger());
           // MainP3.Pokreni(new WebServisLogger());
      
      //ovdje specifiziramo ko ce se baviti logiranjem. 
      //Ideja je da se upotpunosti oslonimo na interface tako da ne bi morali na nivou svake klase kreirati objekte koji bi bili zaduzeni za logiranje
        }
```



## Repository

Kreiramo generički interface 

```c#
public interface IRepository<T>
```

Ovim interface-om želimo da nametnemo listu metoda koje će biti potrebne za komunikaciju s bazom podatka. 

```c#
public class Repository<T> : IRepository
```

Unutar jedne klase želimo da objedinimo logiku pristupa bazi podataka svim drugim tipovima. 

Repository pravimo tako da logiku save, update i delete ne bi morali implementirati za svaku klasu vec one mogu samo da implementiraju interface Repository. 



**Disposable repository**

Koristimo ga kada želimo da oslobodimo resurse što prije, počevši od momenta kad nam taj resurs nije više potreban. 

To možemo postići sa ključnom riječi **using**. Osnovno pravilo kod korištenja using ključne riječi je da tip podatka treba imati metodu koja će automatski biti pozvana. Ta metoda bi trebala biti zadužna za otpuštanje tog resursa, npr. zatvaranje file, konekcije i sl. 

Na raspolaganju imamo interface **IDisposable**. On će nam nametnuti da implementiramo metodu **dispose**. Metodu možemo kreirati u klasi i bez korištenja interface-a IDisposable ali korištenjem njega osiguravamo da ćemo implementirati metodu dispose. 



**Forme**

**partial** 

**Initialize component** - sam izgled forme 