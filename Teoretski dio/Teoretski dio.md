## Uvod

***C#*** je dosta napredniji u odnosu na C++;

***CRM (Object-Relational Mapping)*** - korištenjem Entity FrameWorka. 

***Entitiy Framework*** omogućava da vrlo jednostavno napravimo vezu sa bazom podataka. da dohvatimo ili dodamo neke podatke. 



## .NET

Osigurava platformu develepoerima koja će omogućiti razvoj aplikacija za gotovo sve segmente života, aplikacija, mobilnih aplikacija, aplikacija za konzole tipa Xbox...

*** CLM (Common Intermediate Language)***  prevodi iz intermediate jezika u mašinski kod kako bi se program mogao izvršiiti. 

***SDK (Software Development Kit)*** potreban nam je kada razvijamo aplikacije, međutim kada aplikaciju isporučujemo, biće nam potreban neki ***RunTime***. 

## .NET Platforma 

***.NET Framework*** vezan je za Microsoft odnosno Windows. Glavni nedostatak .NET Frameworka je što u sklopu Microsofta, što predstavlja značajno ograničenje kada govorimo o nastupu na nekoj široj sceni. 

TOK:  ***Razvoj aplikacije -> CLR -> .NET Platforma***

***.NET Framework:*** WPF, Windows Forms, ASP.NET

***.NET Core:*** UWP, ASP.NET Core

- Open-source, dostupan je na drugim platformama npr. Linux...
- Ima dodatne built-o


<hr>

Predavanje 1

<hr>

### **Namespace**

<hr> 

Namespace - za cilj ima da u okviru jednog prostora (logicne cjeline) osigura unikatnost imena. U programiranju ne mogu biti dvosmislenosti i moramo tačno znati na šta se odnosi. 

U C# namespace koji cemo korisiti imati ce ime naseg solutiona. npr solution nam se zove DLWMS.ConsoleApp pa se i namespace naziva DLWMS.ConsoleApp.

U različtim namespaceovima možemo imati istoimene entitete odnosno tipove podataka mada moramo voditi računa kada pristupamo određenom tipu na koji način to radimo.

`    internal class Program //internal znaci da je ta klasa dostupna na nivou odredjenog namespace-a.`

`static void Main(string[] args) //staticki elementi klase - dostupni su na nivou klase, za pristup njima nam nije potreban objekat i pristupamo diretkno preko klase. `



### **Funkcija i metoda**

<hr>

U okviru C# nema koncepta globalnih funckija kao što je to slučaj u C++, u C++ smo mogli kreirati globalne funkcije koje ne pripadaju nikome i koje je svako mogao pozivati. 

**U C# funkcije su organiziovane unutar klasa.** Funkcije koje su članice npr. main je članica Program klase, nazivamo **metode**. 



### Main metoda

<hr> 

Metoda Main je oznacena kao static, tipa void i prima niz stringova. 

**args** omogućava da našem programu pošaljemo set ulaznih vrijednosti na osnovu kojih on može započeti izvršenje programa.

Također u Debug dijelu (Path: right click na solution name> Properties> Debug) možemo navesti ulazne argumente prilikom testiranja aplikacije, odvajamo razmakom i ako unesemo fit mostar unmo, ovo će postati tri stringa koji će biti ulazne vrijednosti u ovaj naš program.

Console.WriteLine(); //<<cout<<" "<<endl; je metoda koja pripada klasi Console, WriteLine() je staticka metoda koja je javna i koja ne vraća ništa. 

Za ispis vrijednosti koje su dosle kao ulazne unutar main metode

`for (int i = 0; i < args.Length; i++)

```
        {
        Console.WriteLine(args[i]); 
        }`
```

### Tipovi podataka

<hr>

//Tip: ctrl + . (generise dio koda) + enter

`private static void TipoviPodataka()

```
    {
        throw new NotImplementedException();
    }`
```

Generise dio koda koji nije implementiran, defaultna implementacija  throw new NotImplementedException();  - javlja nam da dio koda nije implementiran i smanjuje mogućnost padanja programa ukoliko zaboravimo da uradimo implementaciju određene metode. 



### Interpolation

<hr>

Interpolation - omogućava generisanje i formiranje određenog stringa na osnovu različitih vrijednosti koji su dostupni u određenoj liniji koda. Interpolation podrazumijeva korištenja znaka $ prije sadržaja koji želimo povezati. 

npr. 

`  Console.WriteLine($"{ ime}  je aktivan sa prosjekom {prosjek}");`



### Pokazivači

<hr>

Da bi u C# koristili pokazivače moramo nazna;iti pokazivače kao nesiguran kod. Želimo da osiguramo da znamo da koristimo pokazivače i imamo dvije preventivne mjere. 

npr. da bi koristili 

`int* pok = &indeks;`

moramo taj dio coda označiti kao unsafe 

` unsafe

```
        {
        int* pok = &indeks;
        }`
```

te nakon toga moramo u propertijima omogućiti unsafe code. 



### Properties

<hr> 

Omogućava nam da u jednoj liniji koda napišemo i getter i setter. Snnipet: prop

`         public int Indeks { get ; set }`

Ukoliko zelimo da dodatno implementiramo getter i setter: 

 `        public int Indeks { get { return _indeks; } set { _indeks = value  } } ` 

ključna riječ value - vrijednost koja se nalazi s desne strane ovog propertija, npr mozemo reci 

`sara.Indeks = 30003; // mogli bi da koristimo kao javno dostupan atribut, a ne kao metodu.`   

  npr. 

`public int Indeks {

```
        get { return _indeks; } 
        set {
            if(value>200000 && value<400000)
            _indeks = value; }
    } //snippet je prop, zamjenjene metode settera i gettera`
```

   

### Vrste podataka - Value i reference tipovi

<hr>

Dvije vrste podataka koje cemo korisiti: value i reference tipovi

U programskom jeziku C++ imali smo ključnu riječ new koja nam je sugerisala da smo izašli sa stacka na heap (u dinamiču memoriju). 

C# predstavlja managed okruženje tj. razvojno okruženje u kojem se izvršava aplikacija - zaduženo je da upotpunosti upravlja memorijskim resursima. On vodi računa o alokaciji i dealokaciji u memoriji.

**Value tipovi (vrijednosni tipovi)** - tipovi podataka koji se uvijek pohranjuju na stacku, dakle tu govorimo o primitivnom tipu podataka: int, float, bool... 

` int a = 10;
  int b = a; //ovdje je b samo preuzela vrijednost a, ukoliko a promijenimo, b ce ostati nepromjenjeno
   a = 2000;`

``int a = new int(); //ova linija koda inicijalizuje varijablu a nekom defaultnom vrijednoscu`

`int b; //Obje su na stacku samo varijabla a ima neko defualtnu vrijednosti (a==0)Console.WriteLine();`

`if(b==0) // ne da nam da koristimo varijablu b jer nije inicijalizovana, stoga ne mozemo je porediti`

`Console.WriteLine();`



**Reference tipovi**

Reference tipovi kao što su klase, gdje se njihovi objekti odnosno vrijednosti pohranjuju na heap-u (u dinamickoj memoriji). 



Svi tipovi podataka bili oni value ili reference imaju jedan jedinstveni bazni tip podatka, a to je **object**. 

**Object** predstavlja najveći nivo u hijerarhiji nasljeđivanja. Kada imamo neki izvedeni tip njega možemo konvertovati u bazni, npr. 

`object objA = a;
 object objSara = sara;`

Kada je nešto tipa object imamo par metoda koje su nam dostupne, npr Equals, ToString, GetType... Svi objekti odnosno sve vrijednosti tipa object će pored svojih propertija i metoda imati i ove dodatne metode bez obzira što one nisu implementirane unutar klase npr. unutar klase Student nemamo ToString ali ga možemo korisiti. 



 `Console.WriteLine(sara);  //ako bi samo ovo ispisali dobili bi ispis gdje se nazali objekat sara, odnosno putanju  (DLWMS.Data.Student),//Ovo je bazna ToString metoda, ukoliko ne zelimo da se to desava i zelimo da ispisemo propertije objekta, moramo napraviti override u klasi Student`



`Ispisi(objA); //mozemo joj poslati sta god zelimo

```
        //To je moguce jer je tip object bazni tip svim tipovima sto znaci da ih u svakom momentu mozemo pretvoriti u taj tip i vratiti 
        Ispisi(objSara); `
```

### Dodatne informacije

<hr> 

Ukoliko imamo više projekata, da bi koristili neki projekat u drugom projektu moramo dodati referencu u drugi projekat. npr. ako imamo projekat DLWMS.ConsoleApp i projekat DLWMS.Data, da bi koristili projekat DLWMS.Data trebamo dodati referencu u DLWMS.ConsoleApp.





## **Predavanje 2**



Tipovi podataka:

- Primitivni tipovi i objekti - alociraju se na heap-u

- Reference tipovi - alociraju se na stacku

  ​

U C++ nam je ključna riječ znala izlazak na stack, a u C# to nije slučaj. Sada new radi samo inicijalizaciju odnosno govori compileru da želimo da postavimo vrijednost na neku defaultnu vrijednost, ukoliko ne inicijalizujemo neku vrijednost onda je nećemo moći da koristimo jer compiler misli da smo zaboravili da ga iniciliziramo. 



### Vrijednosni tipovi podataka - kreira kopiju. Struktura je value tip. Ako imamo nešto što će se često mijenjati, bolje je da napravimo strukturu umjesto klase jer je izlazak u dinamički dio poprilično skup. 

Podrazumijevane vrijednosti. 

One zavise od tipa, numeričke vrijednosti će imati 0, bool će biti false, a za reference tipove defaultna vrijednost će biti null. 

nullable - null ne možemo dodijeliti value tipovima, zato imamo koncept nullable. To nam omogućava da value vrijednost ima null vrijednost. To radimo tako što stavimo ? nakon tipa podatka. npr.

 int ? test = null;

student?.Prezime -> provjerava da li je null, ovo govori compileru da ne provjerava dalje ako je lijeva strana null. 

Drugi nacin

string prezime = student?.Prezime??"PREZIME"; //ako je lijeva strana null onda ce Prezime biti postavljeno na vrijednost PREZIME, a ako lijeva strana nije prazna bice inicijalizovana njome

Slanje po referenci - u C# ključna riječ ref se navodi i prilikom poziva i prilikom deklaracije metode.

Ključna riječ **out** - služi nam da natjeramo metodu da izvrši modifikaciju prosljeđenog parametra. 

Zahvaljujući outu ne moramo da nuliramo jer out osigurava da će parametar biti modifikovan. 

int.TryParse ("654" , out rezultat);      // prvi parametar je string, a drugi

//ova metoda pokušava da parsira string 654 u integer i da pohrani rezultat u rezultat. Ova metoda vraca bool vrijednost. 



Ključna riječ **in** - poluconst, ona od nas zahtjeva da ni na koji način ne modifikujemo kompletan objekat. Sada moramo provjeravati da li je nesto null -> ne smije biti null jer želimo da pristupimo određenom propertiju tako da moramo inicijalizovati objekat. Oni su nam bitni radi postojećih metoda tako da znamo šta od njih možemo očekivati. 

**Imutabilnost** - kao koncept znači da su vrijednosti nakon inicijalizacije nepromjenjive. 

**Dekonstrukcija**

Ključna riječ var - ne moramo navoditi tip podatka i on sam odredi tip podatka na osnovu onoga Što se nalazi s desne strane, mada ih nema poente korisitit s varijablama koje nisu inicijalizovane

**Params** - da ne bi morali kreirati više metoda za različit broj paramatera već da proglasimo parametre nizom, uz ključnu riječ params, možemo poslati niz, a i set vrijednosti. npr.



```
int suma1 = Sumiraj (new int[] { 2 , 34 , 8 , 6 });
int suma2 = Sumiraj ( 2 , 34 , 8 , 6 );

 private static int Sumiraj(params int[] niz)
        {
            var suma = 0;
            for ( int i = 0; i < niz.Length; i++ )
                suma += niz[i];
            return suma;
        }
```



**Indekseri** -  to su operatori [], omogućava nam da pristupimo pojedinim elementima u nekom nizu. Kreiramo operator [], u C# koristimo ključnu riječ this.



## **Predavanje 3**



**const & readonly**

**const** - mora biti inicijalizovan odmah

**readonly** - možemo ih inicijalizovati u konstrukutoru nakon čega oni postoji konstante. Nakon inicijalizacije se oni ne mogu mijenjati. 



**nasljeđivanje, is, as**

Logika nasljeđivanja je kao i u C++, ukoliko nam nešto nije dostupno jer nije javno, to možemo uraditi tako što ćemo pozvati konstruktor bazne klase. S razlikom da se prilikom poziva bazne klase u headeru umjesto imena klase piše ključna riječ base. U C++ klasa je mogla da naslijedi više klasa, u C# možemo naslijediti samo jednu baznu klasu!

**is, as** - slični dynamic cast operatoru - one vrše provjeru tipa i konverziju 

Da bi izbjegli null reference exception, 

```C#
     if(osoba is DLStudent )
     	{
            var dlStudent = osoba as DLStudent;
        }
```
Ovdje provjeravamo da li je osoba DLStudent. Ukoliko jeste, posmatraj je kao DLStudenta

Sada možemo da pristupimo i manipulišemo vrijednostima propertija 

**abstract class** - ne da nam da kreiramo objekte klase kada je abstraktna 

**Abstraktna metoda** - kada neku metodu proglasimo abstraktnom, to znači da svaku izvedenu klasu tjeramo da implementira tu metodu. Također, da bi metodu proglasili abstraktnom, klasa mora biti abstraktna. 

### 

**Virtualna metoda** - slična je abstraktnoj metodi s tim da abstraktna metoda tjera izvedene klase da je implementiraju, a kod virtualne metode je očekivano ali nije obavezno. 



**Interface ** -u programiranju nam služe u kontekstu osiguranja određenih članova, propertija, atributa, metoda... Interface definiše ključna riječ interface, i nazivi interface se pišu sa velikim slovom I na početku, ovaj standard nam pomaže da lako prepoznamo interface. Ideja interface-a je da definišemo određeni set članova koje će klasa morati da posjeduje odnosno implementira. 

Kada neka klasa implementira interface, ona može da naslijedi neku klasu. npr. 

public class Korisnik: Osoba, IKorisnik{} // ovo je moguće jer interface nije klasa i ne vrši se nasljeđivanje već implementacija interface-a. Također za razliku od nasljeđivanje klasa, implementacija interface-a nema ograničenje, možemo implementirati koliko želimo interface-a. 



**Nasljeđivanje interface-a**

Ukoliko želimo da imamo metode koje se odnose samo na određene klase, a ne na sve koje implementiraju neki interface, možemo raditi nasljeđivanje interface-a. npr. 

public interface IStudent   : IKorisnik{}

Sada imamo pristup svim propertijima i metodama koje IKorisnik interface posjeduje i također možemo napraviti nove metode za interface IStudent. 



**Logiranje**

Obično se na ulaznoj metodi, na početku rada aplikacije dostavlja informacija ko je zadužen za logiranje.



**Repository**

Kreiramo generički interface 

​    public interface IRepository<T>

Ovim interface-om želimo da nametnemo listu metoda koje će biti potrebne za komunikaciju s bazom podatka. 

​    public class Repository<T> : IRepository

Unutar jedne klase želimo da objedinimo logiku pristupa bazi podataka svim drugim tipovima. 

Repository pravimo tako da logiku save, update i delete ne bi morali implementirati za svaku klasu vec one mogu samo da implementiraju interface Repository. 



**Disposable repository**

Koristimo ga kada želimo da oslobodimo resurse što prije, počevši od momenta kad nam taj resurs nije više potreban. 

To možemo postići sa ključnom riječi **using**. Osnovno pravilo kod korištenja using ključne riječi je da tip podatka treba imati metodu koja će automatski biti pozvana. Ta metoda bi trebala biti zadužna za otpuštanje tog resursa, npr. zatvaranje file, konekcije i sl. Na raspolaganju imamo interface **IDisposable**. On će nam nametnuti da implementiramo metodu **dispose**. Metodu možemo kreirati u klasi i bez korištenja interface-a IDisposable ali korištenjem njega osiguravamo da ćemo implementirati metodu dispose. 



Forme

**partial** 

**Initialize component** - sam izgled forme 



## Predavanje 4



































