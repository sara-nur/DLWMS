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
