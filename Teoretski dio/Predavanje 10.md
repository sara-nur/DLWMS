## ORM - Object Relational Mapping

Ideja je da one podatke koje mi imamo u bazi podataka, kada se učitaju  u aplikaciju budu 

konvertovani odnosno mapirani u adekvatne objekte.

Mi kada programiramo želimo da radimo s objektima. 



### Entity Framework

Jedna vrsta ORM alata koji ćemo mi korisiti naziva se Entity Framework. To je Microsoftov alat, odnosno biblioteka ili nugget paket koji nam omogućava da ostvarimo interakciju između aplikacije i naše baze. 

Nas posebno interesuje njegova klasa koja se zove **DbContext**. To je klasa koja ustvari sadrži sve funkcionalnosti koje nam omogućavaju da ostvarimo interakciju između baze i aplikacije. 

Prvo ćemo kreirati bazu podataka u Microsoft SQL Serveru ili DB SQLite

Da bi koristili Entity Framework, moramo ga prvo instalirati. U C# na **DLWMS.Data > Dependencies > Manage NuGet Packages > EntityFrameworkCore** 

Mi ćemo u ovom slučaju instalirati packet **Microsoft.EntityFrameworkCore.Sqlite**



#### Pristupi kreiranja baze

1. DataBase first - kada baza postoji i mi na osnovu nje kreiramo klase 
2. Code first - Kada imamo klase i na osnovu klasa želimo da generišemo bazu.  



Nakon instaliranja EntityFrameworka, kreiramo klasu DbContext i ona će biti glavna za interakciju s bazom.

```c#
namespace DLWMS.Data;
internal class DLWMSDbContext  : DbContext //nasljedjujemo DbContext
{
    //prva stvar koja nam treba je putanja do baze i ona se zove Konekcijski String. 
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = C:\\Users\\Sara\\Desktop\\DLWMS.db"); //ovdje nikad ne kopirati iz eksternog filea putanju direktno vec prvo pastati u kod pa iz koda kopirati ovdje ili rucno napisati radi nevidljivih karaktera koje moze dodati 
    }
    //Nasa ova klasa takodjer moramo oznaciti s kojim tabelama radimo pa koristimo DB set. 
     public DbSet<Predmet> Predmeti { get; set; }
}


```

