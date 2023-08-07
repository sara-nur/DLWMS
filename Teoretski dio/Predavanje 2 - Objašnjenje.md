## Konekcija();

Simuliramo klasu koja će biti u stanju da komunicira sa bazom. Logika komunikacije s bazom je prepuštena ovoj klasi. 

```c#
 private static void KonekcijaNaBazu( )
        {
            Konekcija konekcija = new Konekcija(); //kreiramo objekat tipa Konekcija 
            List<Student> studenti = konekcija.GetStudentByGodinaStudija(1); //Kreiramo listu koja sadrži studente prve godine
            foreach(var student in studenti) //svaki objekat u ovoj listi će dobiti ime student u listi koja se naziva studenti 
            {
				Console.WriteLine(student);
            }

        }
```

Ostali dijeliovi koji povezivaju ovu metodu biće prikazana lista studenata. Ukoliko bude potrebe za mijenjanjem podataka, možemo ih mijenjati na jednom mjestu samo, a to je u klasi Konekcija. 

Ovako ne moramo da modifikujemo na svim slojevima, već samo na jednom, dakle u Data Sloju. 

Ona je zadužena za uspostavljanje konekcije i dohvatanje podataka. 



## Slojevi & VrijednostiReference();

- **Primitivni tipovi i objekti** - alociraju se na heap-u
- **Reference tipovi** - alociraju se na stack-u

U C++ nam je ključna riječ **new** značila izlazak sa sta	ck-a u dinamički dio memorije, a u C# to nije slučaj. 

Sada **new** radi **samo inicijalizaciju** odnosno govori compileru da želimo da postavimo vrijednost na neku defaultnu vrijednosst, ukoliko ne inicijalizujemo neku vrijednost onda je nećemo moći da koristimo jer compiler misli da smo zaboravili da ga iniciliziramo. 

```C#
  private static void VrijednostiReference( )
        {
            int a = new int ();
            int b = a;

            b = 20;
            
        }
//Vrijednosni tipovi podataka - kreira kopiju.
```

 

### *Struktura*

**Struct** je value tip. Ako imamo nešto što će se često mijenjati, bolje je da napravimo strukturu umjesto klase jer je izlazak u dinamički dio poprilično skup. 

```C#
 public struct DLStudent
    {
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }
    }
```

Kada smo na stack-u sve nam je pod rukom te kada izađemo iz određene metode, ono što je bilo na stack-u vezano za tu metodu se automatski dealocira. 

Dok u dinamičkom dijelu imamo **garbage collector** koji povremeno naizali pa prebacuje objekte iz jedne generacije u drugu u zavisnosti od toga koliko ih često treba dealocirati...

#### *Reference: Klasa Student - Dinamičko alociranje memorije*

```c#
Student student1 = new Student ()
            {
                Prezime = "Music" ,
                GodinaStudija = 1,
            };
            Student student2 = student1;
 //student1 i student2 posjeduju referencu na jedan te isti objekat

			Console.WriteLine(student1);
            Console.WriteLine(student2);
            student2.Prezime = "Modifikacija prezimena";
            Console.WriteLine(student1);
            Console.WriteLine(student2);

//Promjena će se izvršiti na oba objekta, i na student1 i na student2 

//Da bi se ispis izvršio ispravno, moramo editovati ToString() metodu u klasi Student!
```



#### *Value: Stuktura DLStudent - stack alociranje memorije* 

U primjeru kada radimo sa strukturama, pošto su oni value tipovi, sada imamo dva objekta. Iz objekta dlStudent1 se kopiraju vrijednosti u dlStudent2. Pošto su vrijednosti kopirane iz jednog u drugi, oni nisu povezani ni na koji način tako da modifikacijom jednog objekta ne utičemo na promjene u drugom objektu. 

```c#
 DLStudent dlStudent1 = new DLStudent ()
            {
                Prezime = "Prezime" ,
                GodinaStudija = 1 ,
            };

            DLStudent dlStudent2 = dlStudent1;

            Console.WriteLine (dlStudent1);
            Console.WriteLine (dlStudent2);
            student2.Prezime = "Modifikacija DL Studenta 2";
            Console.WriteLine (dlStudent1);
            Console.WriteLine (dlStudent2);

//Da bi se ispis izvršio ispravno, moramo editovati ToString() metodu u strukutri DLStudent!
```



## Nizovi();

```c#
 private static void Nizovi( )
    {
            Student[] studenti = new Student[3]; 
   //Svi reference tipovi se moraju alocirati u memoriji. 
   //Inicijalno svi članovi niza su postavljeni na null
   //Prije korištenja ovog niza, moramo da inicijalizujemo sve članove prvo. 
       for( int i = 0; i < studenti.Length; i++ )
            {
                studenti[i] = new Student (); //OBAVEZNA LINIJA!
                studenti[i].Prezime = $"Prezime{i}";
                studenti[i].GodinaStudija = i + 1;
                Console.WriteLine (studenti[i]);
            }
     
            DLStudent[] dlStudenti = new DLStudent[3]; 
   //value tipovi se automatski kreiraju na stack-u
   //Za razliku od niza studenata tipa Studenti, mi kod DLStudenta već imamo spremne objekte za korištenje. GodinaStudija je već postavljena na 0, dok je prezime prazno 
     for( int i = 0; i < dlStudenti.Length; i++ )
            {
                dlStudenti[i].Prezime = $"Prezime{i}";
                dlStudenti[i].GodinaStudija = i + 1;
                Console.WriteLine (dlStudenti[i]);
            }
     //Ovako možemo da postavimo vrijednosti za niz dlStudenti. 
   }
```



## PodrazumijevaneVrijednosti();

One zavise od tipa, numeričke vrijednosti će imati **0**, bool će biti **false**, a za reference tipove defaultna vrijednost će biti **null**. 

```c#
int a = new int (); //0 
int b; //
```

```c#
// public int MentorId { get; set; } - u klasi Student 

Student denis = null;
denis.MentorId = null; //nije moguce jer je MentorId tipa int - value tip. Null se moze dodijeliti samo reference tipovima

// public int? MentorId { get; set; } -> nullabilan MentorId

 Student marko = new Student ()
            {
                Prezime = "Neko" ,
                GodinaStudija = 1 ,
                MentorId = null ,
            };
```



### *Nullable*

**nullable** - null ne možemo dodijeliti value tipovima, zato imamo koncept nullable. 

To nam omogućava da value vrijednost ima null vrijednost. To radimo tako što stavimo **?** nakon **tipa podatka.** npr.

```C#
int ? test = null;
//Drugi nacin
Nullable<int> test2 = null;

//Nullable integer nam daje dva nova propertija, hasValue i Value

if(test.hasValue){ //hasValue vraca true ili false
	Console.WriteLine(test.Value); //Value vraca vrijednost
}  
```



## ProvjeraNullVrijednosti();

Provjera null vrijednosti na koje smo navikli. 

```c#
 Konekcija konekcija = new Konekcija ();
            Student student = konekcija.GetStudentByIndeks ("IB210012");
            if (student != null)
            {
                Console.WriteLine (student.Prezime);
            }

```

Međutim problem bi nastao kad aželimo da vidimo npr. 

```c#
student.Polozeni[i].Semestar.Naziv; //tada bi morali provjeriti svaku instancu da li je null sto bi bilo jako nepregledno.
```



### *?* 

Jednostavniji način bi bio da koristimo ugrađene mehanizme koji nam služe za provjeru nullova a to je **dodavanje znaka ?** prije vrijednosti ikojoj pokušavamo pristupiti

```c#
student?.Prezime // provjerava da li je null, ovo govori compileru da ne provjerava dalje ako je lijeva strana null. 

//Drugi nacin

string prezime = student?.Prezime??"PREZIME"; //ako je lijeva strana null onda ce Prezime biti postavljeno na vrijednost PREZIME, a ako lijeva strana nije prazna bice inicijalizovana njome
```



## SlanjeParametara();

### *ref*

```c#
   private static void SlanjeParametara( )
        {
            Student student = null;
            InicijalizujStudenta (student);
        }

        private static void InicijalizujStudenta( Student obj )
        {
            obj = new Student ()
            {
                Prezime = "Prezime" ,
                GodinaStudija = 1 ,
                MentorId = null ,
            };
        }
/*
Metoda InicijalizujStudenta mijenja stanje objekta obj, ali ni na koji način ne utiče na objekat student. Nakon što se metoda InicijalizujStudenta izvrši, sve vezano za nju se briše. 
    
Pošto nismo modifikovali objekat student, on će idalje biti null i desiće se nullException.

U ovom slučaju se parametri šalju po vrijednosti, a mi trebamo slati po referenci. 
*/
```



**Slanje po referenci** - u C# ključna riječ **ref** se navodi i prilikom poziva i prilikom deklaracije metode. 

```c#
  private static void SlanjeParametara( )
        {
            Student student = null;
            InicijalizujStudenta (ref student);
        }

        private static void InicijalizujStudenta( ref Student obj )
        {
            obj = new Student ()
            {
                Prezime = "Prezime" ,
                GodinaStudija = 1 ,
                MentorId = null ,
            };
        }

/* 
U ovom slučaju objekat student šaljemo po referenci, tako da sve promjene na objekat obj će se reflektovati na objekat student. 

U ovom slučaju obj će biti drugo ime za objekat student
*/
```



Također, slučajevi kada je korisno korisiti ref je kada imamo strukture, pošto se one gledaju kao value tipovi, one će se kopirati, da bi izbjegli konstantno kopiranje i time uštedili na memoriji, možemo korisiti ključnu riječ ref. 



### *out*

Ključna riječ **out** - služi nam da natjeramo metodu da izvrši inicijalizaciju odnosno modifikaciju prosljeđenog parametra. 

```c#
  private static void SlanjeParametara( )
        {
            Student student; //ne moramo da nulliramo jer nam out garantuje da će se objekat modifikovati 
            InicijalizujStudenta (out student);
            Console.WriteLine (student.Prezime);
        }

        private static void InicijalizujStudenta( out Student obj )
        {
            obj = new Student ()
            {
                Prezime = "Prezime" ,
                GodinaStudija = 1 ,
                MentorId = null ,
            };
        }
```

Zahvaljujući **out**-u **ne** moramo da **nuliramo** jer out osigurava da će parametar biti modifikovan. 

```C#
nt rezultat = 0;
int.TryParse ("65d4" , out rezultat); // prvi parametar je string, a drugi je parametar koji je označen sa out. 

//ova metoda pokušava da parsira string 654 u integer i da pohrani dobijenu vrijednost u varijablu rezultat. Ova metoda vraca bool vrijednost. 
```



### *in*

Ključna riječ **in** - poluconst, ona od nas zahtjeva da ni na koji način ne modifikujemo kompletan objekat. Sada moramo provjeravati da li je nesto null -> ne smije biti null jer želimo da pristupimo određenom propertiju tako da moramo inicijalizovati objekat. Oni su nam bitni radi postojećih metoda tako da znamo šta od njih možemo očekivati. 

```c#
 private static void SlanjeParametara( )
        {
            Student student = new Student (); //sada moramo da inicijalizujemo objekat jer sa in modifikujemo samo određene parametre nikad cijeli objekat
            InicijalizujStudenta (in student);
            Console.WriteLine (student.Prezime);

        }

        private static void InicijalizujStudenta( in Student obj )
        {
            obj.Prezime = "Prezime32";
        }
```



## Imutabilnost

**Imutabilnost** - kao koncept znači da su vrijednosti nakon inicijalizacije nepromjenjive. 

Postoje tipovi podataka koji su imutabilni. Ako želimo napraviti bilo kakvu modifitikikaciju, moraćemo napraviti potpuno novi objekat sa modificiranim vrijednostima. 

```c#
private static void Imutabilnost( )
        {
            string ime = "Denis";
            ime.ToUpper ();
            Console.WriteLine (ime); //Ispisati ce se Denis
        }
```



```c#
private static void Imutabilnost( )
        {
            string ime = "Denis";
            ime = ime.ToUpper (); 
//metoda ToUpper() kreira potpuno novi string u ovom slučaju i da bi reflektovali promjene moramo pohraniti vrijednost ime.ToUpper u ime. 
            Console.WriteLine (ime); //Ispisati ce se DENIS
        }

```



Isti slučaj imutabilnosti se može primjetiti i na sljedećem primjeru: 

```c#
  DateTime danas = DateTime.Now;
            danas.AddDays (2) 
            Console.WriteLine (danas.ToString ("dd.MM.yyyy"));
//i u ovom slučaju na konzoli će se ispisati originalni datum, promjene neće biti reflektovane, da bi se promjene primjenile na datum, moramo dodijeliti vrijednost danas.AddDays (2) varijabli danas

  DateTime danas = DateTime.Now;
            danas = danas.AddDays (2) 
            Console.WriteLine (danas.ToString ("dd.MM.yyyy"));
```



## Dekonstrukcija 

```C#
//metodu Deconstruct dodajemo u klasu Student, sa out garantujemo da ce se parametri inicijalizovati 
public void Deconstruct( out string prezime , out int godinaStudija )
        {
            prezime = Prezime;
            godinaStudija = GodinaStudija;
        }

//P2

  private static void Dekonstrukcija( )
        {
            Student obj = new Student ()
            {
                GodinaStudija = 1 ,
                MentorId = null ,
                Prezime = "Prezime" ,
            };

            string prezime;
            int godinaStudija;
            obj.Deconstruct (out prezime , out godinaStudija);

            (prezime, godinaStudija) = obj; //sada ova linija predstavlja isto sto i obj.Deconstruct (out prezime , out godinaStudija);
        }
```



#### *var*

Ključna riječ **var** - ne moramo navoditi tip podatka i on sam odredi tip podatka na osnovu onoga Što se nalazi s desne strane, mada ih nema poente korisitit s varijablama koje nisu inicijalizovane

```c#
var aktivan = true; 
car cijena = 3.4;

var ime; //ne mozemo koristiti var jer on nema na osnovu cega da prepozna tip 
```



## Params

Da ne bi morali kreirati više metoda za različit broj paramatera već da proglasimo parametre nizom, uz ključnu riječ **params**, možemo poslati niz, a i set vrijednosti. npr.

```c#
int suma1 = Sumiraj (new int[] { 2 , 34 , 8 , 6 });
int suma2 = Sumiraj ( 2 , 34 , 8 , 6 );

 private static int Sumiraj(params int[] niz)
        {
            var suma = 0;
            for ( int i = 0; i < niz.Length; i++ )
                suma += niz[i];
            return suma;
        }


//umjesto ovoga mozemo koristiti metodu Sum
private static int Sumiraj2( params int[] niz )
        {
            return niz.Sum ();
        }
//ili
private static int Sumiraj2( params int[] niz ) => niz.Sum ();

var tekst = string.Join ("+" , 2 , 35 , 8 , 6 , 34);
var tekst2 = string.Join ("-", "sara", "nur")

//Join prima tip object tako da joj možemo slati različite tipove podataka. Ova metoda je također primjer korištenja params-a
```





## Indekseri 

**Indekseri** -  to su operatori [], omogućava nam da pristupimo pojedinim elementima u nekom nizu. Kreiramo operator [], u C# koristimo ključnu riječ **this**.



```c#
//u Klasi student
int[] Ocjene = new int[30];

        public int this[int lokacija]
        {
            get { return Ocjene[lokacija]; }
            set { Ocjene[lokacija] = value; }
        }

//u metodi mainP2

 private static void Indekseri( )
        {
            var obj = new Student ()
            {
                GodinaStudija = 1 ,
                MentorId = null ,
                Prezime = "Prezime" ,
            };

            obj[0] = 6;  //idemo na lokaciju 0, a value ce biti 6
        }
```

