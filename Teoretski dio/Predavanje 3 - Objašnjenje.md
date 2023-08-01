### ***<u>Predavanje 3</u>***



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



**Virtualna metoda** - slična je abstraktnoj metodi s tim da abstraktna metoda tjera izvedene klase da je implementiraju, a kod virtualne metode je očekivano ali nije obavezno. 



**Interface ** -u programiranju nam služe u kontekstu osiguranja određenih članova, propertija, atributa, metoda... Interface definiše ključna riječ interface, i nazivi interface se pišu sa velikim slovom I na početku, ovaj standard nam pomaže da lako prepoznamo interface. Ideja interface-a je da definišemo određeni set članova koje će klasa morati da posjeduje odnosno implementira. 

Kada neka klasa implementira interface, ona može da naslijedi neku klasu. npr. 

```c#
public class Korisnik: Osoba, IKorisnik{} // ovo je moguće jer interface nije klasa i ne vrši se nasljeđivanje već implementacija interface-a. Također za razliku od nasljeđivanje klasa, implementacija interface-a nema ograničenje, možemo implementirati koliko želimo interface-a. 
```

**Nasljeđivanje interface-a**

Ukoliko želimo da imamo metode koje se odnose samo na određene klase, a ne na sve koje implementiraju neki interface, možemo raditi nasljeđivanje interface-a. npr. 

public interface IStudent   : IKorisnik{}

Sada imamo pristup svim propertijima i metodama koje IKorisnik interface posjeduje i također možemo napraviti nove metode za interface IStudent. 



**Logiranje**

Obično se na ulaznoj metodi, na početku rada aplikacije dostavlja informacija ko je zadužen za logiranje.



**Repository**

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