Predavanje 2

<hr>

Tipovi podataka:

- Primitivni tipovi i objekti - alociraju se na heap-u
- Reference tipovi - alociraju se na stacku

U C++ nam je ključna riječ znala izlazak na stack, a u C# to nije slučaj. Sada new radi samo inicijalizaciju odnosno govori compileru da želimo da postavimo vrijednost na neku defaultnu vrijednost, ukoliko ne inicijalizujemo neku vrijednost onda je nećemo moći da koristimo jer compiler misli da smo zaboravili da ga iniciliziramo. 



Vrijednosni tipovi podataka - kreira kopiju. Struktura je value tip. Ako imamo nešto što će se često mijenjati, bolje je da napravimo strukturu umjesto klase jer je izlazak u dinamički dio poprilično skup. 



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





    int suma1 = Sumiraj (new int[] { 2 , 34 , 8 , 6 });
    int suma2 = Sumiraj ( 2 , 34 , 8 , 6 );
    
     private static int Sumiraj(params int[] niz)
            {
                var suma = 0;
                for ( int i = 0; i < niz.Length; i++ )
                    suma += niz[i];
                return suma;
            }



**Indekseri** -  to su operatori [], omogućava nam da pristupimo pojedinim elementima u nekom nizu. Kreiramo operator [], u C# koristimo ključnu riječ this.



