## Uvod

***C#*** je dosta napredniji u odnosu na C++;

***CRM (Object-Relational Mapping)*** - korištenjem Entity FrameWorka. 

***Entity Framework*** omogućava da vrlo jednostavno napravimo vezu sa bazom podataka, da dohvatimo ili dodamo neke podatke. 



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



## Namespace


Namespace - za cilj ima da u okviru jednog prostora (logicne cjeline) osigura unikatnost imena. U programiranju ne mogu biti dvosmislenosti i moramo tačno znati na šta se odnosi. 

U C# namespace koji cemo korisiti imati ce ime naseg solutiona. npr solution nam se zove DLWMS.ConsoleApp pa se i namespace naziva DLWMS.ConsoleApp.

```C#
using System;
using System.Text;
using DLWMS.ConsoleApp.Helpers; // ako dodamo na vrh using DLWMS.ConsoleApp.Helpers onda naš program ne zna na koji namespace se Encoder odnosi 

namespace DLWMS.ConsoleApp
{

    public class Program
    {
        public static void Main(string[] args )
        {
            Encoder en1; //Odnosi se na Encoder koji se nalazi u System
            Helpers.Encoder en2; //pošto smo stavili using, moramo naznačiti na šta se odnosi
          //  DLWMS.ConsoleApp.Helpers.Encoder en2; //Nalazi se na Encoder koji se nalazi u Helpers, možemo i dodati using DLWMS.ConsoleApp.Helpers;
            Console.WriteLine ("Hello World");
             
        }
    }
}
```

U različtim namespaceovima možemo imati istoimene entitete odnosno tipove podataka mada moramo voditi računa kada pristupamo određenom tipu na koji način to radimo.

```c#
internal class Program //internal znaci da je ta klasa dostupna na nivou odredjenog namespace-a.

static void Main(string[] args) //staticki elementi klase - dostupni su na nivou klase, za pristup njima nam nije potreban objekat i pristupamo diretkno preko klase. 
```



## Funkcija i metoda


U okviru C# nema koncepta globalnih funckija kao što je to slučaj u C++, u C++ smo mogli kreirati globalne funkcije koje ne pripadaju nikome i koje je svako mogao pozivati. 

**U C# funkcije su organiziovane unutar klasa.** Funkcije koje su članice npr. main je članica Program klase, nazivamo **metode**. 



## Main metoda


Metoda Main je oznacena kao static, tipa void i prima niz stringova. 

**args** omogućava da našem programu pošaljemo set ulaznih vrijednosti na osnovu kojih on može započeti izvršenje programa.

Također u Debug dijelu (Path: right click na solution name> Properties> Debug) možemo navesti ulazne argumente prilikom testiranja aplikacije, odvajamo razmakom i ako unesemo fit mostar unmo, ovo će postati tri stringa koji će biti ulazne vrijednosti u ovaj naš program.

Console.WriteLine(); //<<cout<<" "<<endl; je metoda koja pripada klasi Console, WriteLine() je staticka metoda koja je javna i koja ne vraća ništa. 

Za ispis vrijednosti koje su dosle kao ulazne unutar main metode

```c#
for (int i = 0; i < args.Length; i++)
{
     Console.WriteLine(args[i]); 
}
```

Kada su metode statičke ne moramo instancirati njihove objekte.



## Tipovi podataka


```c#
//Tip: ctrl + . (generise dio koda) + enter

private static void TipoviPodataka()
        {
            throw new NotImplementedException();
        }
```


Generise dio koda koji nije implementiran, defaultna implementacija  throw new NotImplementedException();  - javlja nam da dio koda nije implementiran i smanjuje mogućnost padanja programa ukoliko zaboravimo da uradimo implementaciju određene metode. 



## Interpolation 


Interpolation - omogućava generisanje i formiranje određenog stringa na osnovu različitih vrijednosti koji su dostupni u određenoj liniji koda. Interpolation podrazumijeva korištenja znaka $ prije sadržaja koji želimo povezati. 

npr. 

```c#
Console.WriteLine($"{ ime}  je aktivan sa prosjekom {prosjek}");

//Drugi primjer
 private static void TipoviPodataka( )
        {
            int Indeks = 220022;
            string imePrezime = "Sara Nur";
            bool aktivan = false;
            double skolarina = 2000;

            Console.WriteLine ($"{Indeks} je student {imePrezime} aktivan {aktivan} skolarina {skolarina}");
        }
```



## Pokazivači 


Da bi u C# koristili pokazivače moramo nazna;iti pokazivače kao nesiguran kod. Želimo da osiguramo da znamo da koristimo pokazivače i imamo dvije preventivne mjere. 

npr. da bi koristili 

`int* pok = &indeks;`

moramo taj dio coda označiti kao unsafe te nakon toga moramo u propertijima omogućiti unsafe code. 

```c#
unsafe
   {
        int* pok = &indeks;
   }
```



## Klase - properties 

Omogućava nam da u jednoj liniji koda napišemo i getter i setter. **Snnipet: prop**

```c#
public int Indeks { get ; set }
```

Ukoliko zelimo da dodatno implementiramo getter i setter: 

```c#
public int Indeks { get { return _indeks; } set { _indeks = value  } } 
```

ključna riječ value - vrijednost koja se nalazi s desne strane ovog propertija, npr mozemo reci 

```c#
sara.Indeks = 30003; // mogli bi da koristimo kao javno dostupan atribut, a ne kao metodu. 
```

  npr. 

```c#
public int Indeks {
            get { return _indeks; } 
            set {
                if(value>200000 && value<400000)
                _indeks = value; }
        } //snippet je prop, zamjenjene metode settera i gettera
```

   

Također, možemo navesti sve atribute imenom prilikom kreiranja objekta, na ovaj način ne moramo po redoslijedu dodavati atribute kao što bi to morali inače. 

```c#
Student zanin = new Student (indeks: 22343 , prezime: "Vojic" , ime: "Zanin");

```

Sada smo direktno izvšili interakciju sa Propertijima. 

```c#
Student jasmin = new Student ()
            {
                Prezime = "Jasminovic" ,
                GodinaStudija = 1,
            };


//Ovo je ekvivalentno sljedecem:
jasmin.Prezime = "Jasminovic";
jasmin.GodinaStudija = 1;
```

**DTO - Data Transfer Object** 



## Vrste tipova podataka - Value i Reference tipovi


Dvije vrste podataka koje cemo korisiti: value i reference tipovi

U programskom jeziku C++ imali smo ključnu riječ new koja nam je sugerisala da smo izašli sa stacka na heap (u dinamiču memoriju). 

C# predstavlja managed okruženje tj. razvojno okruženje u kojem se izvršava aplikacija - zaduženo je da upotpunosti upravlja memorijskim resursima. On vodi računa o alokaciji i dealokaciji u memoriji.



### *Value tipovi (vrijednosni tipovi)*

Tipovi podataka koji se uvijek pohranjuju na stacku, dakle tu govorimo o primitivnom tipu podataka: int, float, bool... 

```c#
int a = 10;
int b = a; //ovdje je b samo preuzela vrijednost a, ukoliko a promijenimo, b ce ostati nepromjenjeno
   a = 2000;

int indeks = new int (); //iako imamo ključnu riječ new koja je u C++ značila izlazak sa stack-a i prezlazak na heap, u C# to nije slučaj. Svi primitivni tipovi uglavnom ostaju na stack-u-

int indeks1 = 0;
int indeks2 = indeks1;
//vrijednost iz indeksa1 se kopira u indeks2, promjene u jednom se ne reflektuju na drugi

int a = new int(); //ova linija koda inicijalizuje varijablu a nekom defaultnom vrijednoscu

int b; //Obje su na stacku samo varijabla a ima neko defualtnu vrijednosti (a==0)Console.WriteLine();

if(b==0) // ne da nam da koristimo varijablu b jer nije inicijalizovana, stoga ne mozemo je porediti

Console.WriteLine();
```



### ***Reference tipovi***

Reference tipovi kao što su klase, gdje se njihovi objekti odnosno vrijednosti pohranjuju na heap-u (u dinamickoj memoriji). 

```c#
Student sara = new Student(123432, "Sara", "Nur"); //na heap-u
Student denis = sara;

// u objekat denis se pohranjuje adresa objekta sara, promjene na jednom objektu se reflektuju na drugi objekat
```



## Bazni Tip - Object 

Svi tipovi podataka bili oni value ili reference imaju jedan jedinstveni bazni tip podatka, a to je **object**. 

**Object** predstavlja najveći nivo u hijerarhiji nasljeđivanja. Kada imamo neki izvedeni tip njega možemo konvertovati u bazni, npr. 

```c#
object objA = a;
object objSara = sara;
```



Kada je nešto tipa object imamo par metoda koje su nam dostupne, npr **Equals**, **ToString**, **GetType**... 

Svi objekti odnosno sve vrijednosti tipa object će pored svojih propertija i metoda imati i ove dodatne metode bez obzira što one nisu implementirane unutar klase npr. unutar klase Student nemamo ToString ali ga možemo korisiti. 

Nedostatak je to što castanje nečega u object će učiniti da ono izgubi svoje  propertije 



```c#
Student denis = new Student (223344 , "Denka" , "Music");
object objStudent = denis;

if( objStudent is Student )
    {
         //uradiNesto 
    }
//Prije nekog casta npr možemo provjeriti da li je objekt tipa Student npr. 
```



```c#
Console.WriteLine(sara);  //ako bi samo ovo ispisali dobili bi ispis gdje se nazali objekat sara, odnosno putanju  (DLWMS.Data.Student),//Ovo je bazna ToString metoda, ukoliko ne zelimo da se to desava i zelimo da ispisemo propertije objekta, moramo napraviti override u klasi Student


Ispisi(objA); //mozemo joj poslati sta god zelimo
            //To je moguce jer je tip object bazni tip svim tipovima sto znaci da ih u svakom momentu mozemo pretvoriti u taj tip i vratiti 
            Ispisi(objSara); 
```



## Nova verzija Metode

U klasi Student nemamo ToString() metodu pa se poziva ToString metoda od bazne klase (object - ukoliko ne postavimo neku drugu klasu kao baznu, object se automatski dodjeljuje)

```c#
Student denis = new Student(12432, "Denis", "Music");
 Console.WriteLine (denis); //Ispisace rutu - DLWMS.Data.Student
// ovo je ekvivalentno ovome 
 Console.WriteLine (denis.ToString());
```

Da bi mogli ispisati podatke onako kako mi želimo, moramo da overridamo metodu ToString()

```c#
 public override string ToString( )
        {
            return $"({_indeks}) {_ime} {Prezime} {GodinaStudija}";
        }
```



### *Dodatne informacije*

Ukoliko imamo više projekata, da bi koristili neki projekat u drugom projektu moramo dodati referencu u drugi projekat. npr. ako imamo projekat DLWMS.ConsoleApp i projekat DLWMS.Data, da bi koristili projekat DLWMS.Data trebamo dodati referencu u DLWMS.ConsoleApp.

Class Library Projekat - onaj Projekat koji nema interface, on uglavnom služi kao neki kod koji će biti servis usluga drugim slojevima, bibliotekama, interface-ima...
