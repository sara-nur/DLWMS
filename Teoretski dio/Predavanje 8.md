## Object

```c#
 private void TipoviPodataka( )
        {
            object ime = "Denis";
            object indeks = "123432";
            object ocjene = new List<int> ();
        }
```

Prisjetimo se da je object bazni tip svim tipovima podatka, i u njega možemo pohraniti bilo koju vrijednost. Međutim, loša stvar objecta je to što imamo pristup samo metodama koje pripadaju tipu object. Ne možemo korisiti neke metode koje su npr specifične za tip string i sl. 



Tako da ukoliko bismo željeli da imamo pristup metodama specifičnim za tip podatka, onda bi morali raditi casting iz objecta ponovo u string. npr. 

```c#
	object ime = "Sara";
	var im = (string)ime;
```



### Boxing

Podrazumijeva proces u okviru kojeg mi primitivne tipove npr. int, string... konvertujemo u neki refentni tip - npr object, što znači da će sada ovaj value tip biti posmatran kao refence tip u tom nekom kontekstu baznog tipa. 



### Unboxing

Ako bismo željeli da vratimo konkretnu vrijednost u originalni tip, tu imamo obrnuti proces Unboxing. 



### Dynamic

Tip koji je najfleskibilniji sa aspekta kreiranja odnosno deklaracije i inicijalizacije, i on nam ne nameće nikako ograničenje. Jako je sličan generičkim klasama koje smo imali u C++.  

U generičim odnosno template klasama smo mogli napisati pozive koji ne postoje, recimo na nekom objektu unutar naše generičke klase smo mogli pozvati nepostojaću metodu. Dakle tu liniju koda naš compiler neće prijaviti problematičnom iz razloga što on još u tom momentu nije generisao neki konktreatan primjerak te klase. Runtime error ćemo dobiti kada pozovemo tu metodu koja ne postoji. 

```c#
dynamic student = "Sara Nur";
```

**dynamic** na neki način ima karakteristike i objecta i vara. **object**-a iz razloga što može pohraniti bilo koju vrijednost. a **var**-a zato što automatski detektuje koji tip podatka odnosno koju vrijednost mi želimo da čuvamo. 



Ono što je karakteristično za dynamic je to što možemo bez ikakvih problema dodijeliti različite vrijednosti u različitim linijama koda. Možemo mu proslijediti vrijednost tipa koji nije ni sličan inicijalnoj vrijednosti. npr prvo smo poslali string, pa integer, pa listu integera. 

```c#
        dynamic student = "Sara Nur";
        student = "150005";
        student = new List<int> () { 2 , 4 , 3 , 2 , 3 , 4 , 3 , 4 };
```



```c#
       dynamic obj = GetEksterniObjekat ();  
	//dobijamo objekat za koji nemamo adekvantnu klasu i ne zelimo da je imamo
	//Jedino sto mi zelimo je da na ovom objektu pozovemo metodu recimo Printaj();
        Potvrde (obj);

        private dynamic GetEksterniObjekat( )
        {
            return 12;
        }
        private void Potvrde( dynamic obj )
        {
            obj.Printaj ();
        }
```

Dakle, ovdje smo dobili neki objekat, ne znamo šta je niti nas pretjerano zanima, taj objekat prosljeđujemo metodi Potvrde, ulazimo u metodu i nad njim samo želimo da pozovemo metodu Printaj();



Sa **dynamic**-om najčešće se koristi **expand object**. 

```c#
 dynamic objExp = new ExpandoObject ();
 objExp.Ime = "Ime";
 objExp.Indeks = "234222";
 objExp.Ocjene = new List<int> () { 2 , 4 , 4 , 5 , 3 , 4 , 5 };
```

Ideja Expand Objecta je da mi možemo sada bez ikakvih problema njemu kao objektu dodjeliti propertije kakve god želimo. 

Mi smo pod navodnike kreirali neki novi tip i tom tipu automatski dodjelili propertije kao i tipove tih propertija. Ono što sada imamo mogućnost je 

```c#
StudentInfo (objExp);

        private void StudentInfo( dynamic objExp )
        {
            MessageBox.Show ($"{objExp.Ime} {objExp.Indeks}");
        }
```

Ovo je moguće jer je ExpandObject klasa koja implementira interface koji se zove **IDictionary<string, object?>**. 

```c#
  Dictionary<int , string> studenti = new Dictionary<int , string> ();
            studenti.Add (123443 , "Denis Mus");
            studenti.Add (123544 , "Sara Nur");
```

Kod Dictionary, prvi parametar je TKey što predstavlja ključ koji je jako sličan ključevima u bazi podatka. Znamo da tu ne bi trebalo biti nikakvih dupliranja i da bi oni jednoznačno trebali označavati jedan zapis. 

Ono što smo mi ovdje rekli je da se brojevi Indeksa ne bi trebali ponavljati. 

Upravo zbog toga možemo reći 

```c#
var imePrezime = studenti[123443]; //Ovaj operator ce nam vratiti string imePrezime koje je vezano za ovaj Indeks odnoso kljuc sto bi nama trebalo vratiti "Denis Mus" u ovom slucaju. 
```

Veza između Dictionarija i ovog našeg ExpandObjecta je jer je to mehanizam djelimično u pozadini na način da ovi propertiji budu naši Key-evi odnosno ne bi se trebali ponavljati,a ove desne vrijednosti će to postati vrijednosti. To znači da je to i razlog zašto je prvi tip u ExpandObjectu string, a desni object. S desne strane želimo imati širinu da možemo pohraniti bilo šta. 

```c#
 dynamic objExp = new ExpandoObject ();
            //objExp.Add(Ime,"Denis");
            //objExp.Add (indeks , 23532);

            objExp.Ime = "Ime";
            objExp.Indeks = "234222";
```

Na ovaj način, dozvoljavajući automatsko dodavanje članova isto kao da imamo Dictionary, mi kažemo koji je property i koja je njegova vrijednost. 

```c#
            foreach( var osobine in objExp )
            {
                MessageBox.Show (osobine.ToString ());
            }
```

želimo da prođemo kroz sve osobine koje se nalaze u objExp i sada bi trebali da dobijemo sve članove ovog Dictionarija. 



## Anonimni Tipovi

Anonimni Tip podatka kreiramo tako što nakon ključne riječi new, otvorimo vitiačaste zagrade i u njih stavimo set propertija 

```c#
 var obj = new { id = 1, indeks = 120021, ime = "Denis" };
//ovo se moze zapisati i na sljedeci nacin
_ = new { id = 1, indeks = 120021, ime = "Denis" };
```

Članovi anonimnih tipova su read-only vrijednosti. Možemo ih inicijalizovati u momentu kreiranja ali ne i nakon toga. 



Jako sličan koncept anonimnih tipova smo već radili. To je koncept Tuple. 

```c#
var tuple = (1,2432,"Denis"); 
```

Za razliku od anonimnog tipa, tuple nam dozvoljava da mijenjamo vrijednost naknadno. 

```c#
tuple.Item1 = 53; 
```

Ovdje pristupamo prvom članu, tuple automatski dodjeljuje Item1, Item2, Item3 i nisu pretjerano deskriptivni ali ih mi možemo imenovati. Ovdje ćemo za to korisiti operator :

```c#
var tuple = (id:1, inhdeks: 23432, ime:"sara");
tuple.id = 324;
tuple.indeks = 23432;
```



```c#
  private void AnonimniTipovi()
        {
            var obj = new { id = 1, indeks = 120021, ime = "Denis" };

            var tuple = (id: 1, indeks: 23532, ime: "Sara");
            tuple.id = 2;
            tuple.indeks = 23532;

            TupleInfo(tuple);
        }

        private (int, int, string, string) TupleInfo((int id, int indeks, string ime) tuple)
        {
            return tuple;
        }

//Sada ovo ne odgovara potpisu metode, da bi ovo moglo
 var tuple = (id: 1, indeks: 23532, ime: "Sara", Prezime:"Prezime");
```



Ovo je problem kada imamo metodu pozivamo iz dosta različitih dijelova koda. Ovjde dolazimo do koncepta korištenja dto klasa. 

## dto (data transfer object) Klasa

To su samo objekti koji služe za prenos podataka sa jedne lokacije na drugu. 

```c#
 TupleInfo(new dtoStudent() { Id = 1, Indeks = "23543", Ime = "Sara" });
        }

        private dtoStudent TupleInfo(dtoStudent obj)
        {
            return obj;
        }
```

Ovo nam je korisno jer ukoliko želimo da proširimo set vrijednosti koje želimo da pošaljemo, nećemo morati da intervenišemo u ostatku koda osim na onim mjestima gdje želimo da prosljedimo te specifične vrijednosti. 



### Extended metoda

Predstavlja mogućnost proširenja listu metoda za već postojeći tip podatka, npr. string. 

Da bismo se povezali s određenim tipom podatka treba nam statička klasa i statička metoda. Njih možemo imenovati kako želimo. 

U toj statičkoj metodi, na osnovu parametra koji joj šaljemo kažemo s kojim tipom podatka želimo da radimo.  Za to nam je na raspolaganju ključna riječ this, nakon toga navedemo tip podatka s kojim želimo da povežemo ovu metodu.

```c#
 public static class DodateMetode
    {
        public static string VelikaSlova(this string obj)
        {
            return obj.ToUpper();
        }
    }

  private void DodateMetode()
        {
            var ime = "Haris";
            var imeVelikaSlova = ime.VelikaSlova();
        }
```

Sada pored svih metoda kojima string ima pristup, imaće pristup i metodi VelikaSlova. Naravno, ovdje možemo samo pozvati metodu ToUpper, ali ideja je da možemo kreirati vlastite metode za određene potrebe koje imamo.

```c#
 public static class DodateMetode
    {
        public static string Enkriptuj(this string obj)
        {
            var enkriptovanSadrzaj = string.Empty;
            for (int i = 0; i < obj.Length; i++)
            {
              enkriptovanSadrzaj += (char) (Convert.ToInt16(obj[i] + i + 1));
            } 
            return enkriptovaniSadrzaj;
        }
      //Ova metoda nam predstavlja primitivni nacin enkriptovanja nekog sadrzaja privremeno 
     
      public static string Dekriptuj(this string obj)
        {
            var dekriptovanSadrzaj = string.Empty;
            for (int i = 0; i < obj.Length; i++)
            {
                dekriptovanSadrzaj += (char) (Convert.ToInt16(obj[i] + i - 1));
            }
            return dekriptovanSadrzaj;
        }
     //Ova metoda bi trebala da dekriptuje sadrzaj koji smo enkriptovali prethodnom metodom. 
     
    }
```



## Linq

Mogućnost pisanja querija iz samog programskog jezika. On nam omogućava da na jako sličan način pravimo upite bilo kojeg skladišta podataka sa kojima C# može da komunicira. 



U Linq **SELECT** dolazi posljednjim, a **FROM** i **WHERE** se koristi na identičan način. Ono što od nas Linq zahtjeva je nešto slično foreach-u, gdje odmah moramo da imenujemo varijablu koju ćemo korisititi za referenciranje svakog pojedinog člana. 



Selektovanje **čitavog objekta** 

```c#
var ocjene = new List<int>() { 6, 7, 8, 8, 7, 8, 9, 6 };

            var rezultat = from o in ocjene
                           where o > 7
                           select o;

//U ovom slučaju će nam prikazati listu koja zadovoljava ovaj uslov (prikazuje čitav objekat)
```



Selektovanje određenih **Propertija**

```c#
var rezGodine = from godina in godineStudija
                where godina.Aktivan == true
                select godina.Opis;

//Ovdje nam prikazuje selektovani property (Opis) objekta koji zadovoljava uslov
```



Selektovanje **novog objekta** 

```c#
var rezGodine = from godina in godineStudija
                where godina.Aktivan == true
                select new
                {
                    Rb = godina.Id,
                    Ispis = godina.Oznaka,
                };

//U ovom slučaju smo odabrali anonimni tip podatka. 
```



Što se tiče linq, malo kompleksniji upiti postaju jako nepregledni, zato su nam na raspologanju  set nekih extension metoda koje nam pojednostavljuju koncept pravljenja upita nad podacima. 



Te extension metode su nama najčešće dostupne putem metode **WHERE**. 

```c#
		//godineStudija.Where()
/*
Funtion je ustvari pokazivač na funkciju. Kao parametar where metode, kao parametar godinuStudija, a vraća bool. Svaka od tih godina će biti vraćena sa bool vrijednošću kojom će reći da li ona zadovoljava dati uslov ili ne 
*/
    
        var rezGodine2 = godineStudija.Where(FiltrirajGodine); //svaki put ce se ova metoda pozvati za svakog clana niza, svaki clan koji ispunjava uslov bice sastavni dio rezultata 

        private bool FiltrirajGodine(GodinaStudija godina)
        {
            return godina.Aktivan = true;
        }
```



```c#
var rezGodine3 = godineStudija.Where(godina => godina.Aktivan == true);

//Ovo je najčešći pristup koji ćemo koristiti. 
//Ovo je identičan pristup kao gore, samo što nismo morali kreirati još jednu metodu. 
```



Koncept Linq možemo implementirati kod Pretrage. 

```c#
 /* PRVI NACIN
var pretraga = txtPretraga.Text.ToLower ();
            var rezultat = new List<Student> ();
            
            foreach( var student in InMemoryDB.Studenti )
            {
                if( student.Ime.ToLower ().Contains (pretraga) || student.Prezime.ToLower ().Contains (pretraga) || student.BrojIndeksa.ToLower ().Contains (pretraga) )
                {
                    rezultat.Add (student);
               }


            }
            UcitajStudente (rezultat);
 */

//DRUGI NACIN

            var pretraga = txtPretraga.Text.ToLower();

            var rezultat = InMemoryDB.Studenti.Where(student =>
            student.Ime.ToLower().Contains(pretraga) ||
            student.Prezime.ToLower().Contains(pretraga) ||
            student.BrojIndeksa.ToLower().Contains(pretraga)).ToList();
	//sve pretvaramo u Listu jer nam metoda UcitajStudente ocekuje listu

            UcitajStudente(rezultat);

//TRECI NACIN

{ 
    	var rezultat = InMemoryDB.Studenti.Where(FiltrirajStudente).ToList();
            UcitajStudente(rezultat);
}

        private bool FiltrirajStudente(Student student)
        {
            var pretraga = txtPretraga.Text.ToLower();
            return student.Ime.ToLower().Contains(pretraga) ||
               student.Prezime.ToLower().Contains(pretraga) ||
               student.BrojIndeksa.ToLower().Contains(pretraga));
        }

```
