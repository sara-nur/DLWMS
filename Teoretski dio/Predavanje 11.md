## Baza

Bazu podataka ćemo prebaciti u root direktorij našeg projekta. Također, desnim klikom na bazu > Properties > Copy to Output Directory > Copy if newer. Ovim ćemo osigurati da će naš ovaj fajl biti kopiran kada bude updatovan. On će se sačuvati u debug file-u odnosno u bin folderu.

Moramo i bazu lokacije baze da promjenimo, i želimo da lokacija baze bude neposredno pored exit file-a, to možemo uraditi tako što ćemo samo upisati naziv baze

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <connectionStrings>
        <add name="DLWMSPutanja"
            connectionString ="Data Source = DLWMS.db"
             />
    </connectionStrings>
</configuration>

```



## Relacije 

#### <u>One to many relacija</u>

npr. Imamo tabelu Studenti i referentnu tabelu Spolovi. U tabeli Studenti držimo samo Id koji se odnosi na spol. Preko Id-a provjeravamo da li spol Muški ili Ženski. Jedna osoba može biti samo jednog spola, dok tabela spolovi može imati mnogo referenca (postoji mnogo ljudi muškog i ženskog spola). 

##### *Studenti*

| Id   | Ime    | Prezime  | SpolID |
| :--- | :----- | :------- | :----- |
| 1    | Denis  | Mušić    | 1      |
| 2    | Emina  | Junuz    | 2      |
| 3    | Jasmin | Azemović | 1      |



##### *Spolovi*

| Id   | Naziv  |
| ---- | ------ |
| 1    | Muški  |
| 2    | Ženski |



u SQL Lite kada kreiramo tabelu spolovi trebamo je povezati sa studentima. To radimo tako što u Tabeli studenti kreiramo SpolId označimo da je Foreign Key > na Tabelu Spolovi > Na properti Id



##### Učitavanje Spolova

npr. Prilikom učitavanje spolova, program će nam na ovoj liniji pasti. On neće imati učitan spol. 

Dva koncepta: 

1. **Lazy Loading** - kada podatke dobijamo onda kada su nam potrebni. 
2. **Eager Loading -** podrazumijeva da mi explicite kažemo koje podatke želimo. Automatsko učitavanje podataka nosi dozu komfora, međutim i znatno performansno košta jer ćemo mi u zavisnosnosti od definisanje, u momentima učitati mnoštvo objekata. 

S druge strane, eager loading je malo efikasniji, ali od nas traži da eksplicite naglasimo koje navigacijske propertije odnosno koje relacije sa objektom mi želimo da učitamo. 

Jedan od načina kako mi možemo učitati i one dodatne navigacijske propertije je koristeći metodu **Include**. 

**Metoda Include**  

```c#
//frmUcitajPodatkeOStudentu
private void UcitajPodatkeOStudentu()
        {
           /*
           ostatak koda 
           */
            cmbSpol.SelectedValue = student.Spol?.Id; //sada ce Spol predstavljati objekat 
        } 



//frmStudentiPretraga
 private void UcitajStudente(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? db.Studenti.Include("Spol").ToList(); //zelimo da ucitamo iz baze sve studente iz tabele Studenti i za svakog Studenta zelimo da uključimo objekat Spol. 
     //drugi nacin
      dgvStudenti.DataSource = studenti ?? db.Studenti.Include(s => s.Spol).ToList(); //malo bolji nacin radi lakse provjere, odmah ce nam biti oznaceno ukoliko nesto pogresno unesemo. 
        }
```

Zahvaljujući naming konvenciji, on će odmah prepoznati da je SpolId polje vezano za Property Spol. 



### <u>Many to many relacija</u>

Ona nam omogućava da koristimo neku međutabelu u okviru koje ćemo mi pohraniti podatke  u kontekstu njihovih Id-ijeva, a ne nekih njihovih preciznih vrijednosti kao što je bio slučaj sa predhodne dvije tabele. 

npr. 

##### *Predmeti*

| Id   | Naziv              |
| ---- | ------------------ |
| 1    | Programiranje I    |
| 2    | Operativni Sistemi |
| 3    | Marketing          |



Ono što nas sada inteteresuje je da čuvamo podatke o položenim predmetima za svakog studenta. Tako da ćemo mi kreirati tabelu StudentiPredmeti koja će pored vlastitog Id-a, imati i Id studenta i Id Predmeta te Ocjenu i Datum polaganja. 

##### *StudentiPredmeti*

| Id   | StudentId | PredmetId | Ocjena | Datum      |
| ---- | --------- | --------- | ------ | ---------- |
| 1    | 1         | 1         | 8      | 12.08.2009 |
| 2    | 1         | 3         | 7      | 12.08.2009 |
| 3    | 2         | 2         | 9      | 13.09.2010 |

Više studenata može položiti jedan predmet, dok jedan student može imati više položenih predmeta. 

```c#
namespace DLWMS.Data
{
    [Table("StudentiPredmeti")]

    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public Student Student { get; set; }    
        public int StudentId { get; set; }
        public DateTime Datum { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjene { get; set; }
    }
}

//Također u DLWMSDbContext trebamo dodati DbSet za ovu tabelu
        public DbSet<StudentPredmet> StudentiPredmeti { get; set; }
```

