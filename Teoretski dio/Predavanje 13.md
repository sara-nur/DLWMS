### Thread-ovi

<hr>

Za osiguranje pozitivnog korisničkog iskustva ključno je spriječiti zamrzavanje ili neodzivnost aplikacije. 



Kada pokrenemo aplikaciju, pokreće se glavna nit koja upravlja izvršavanjem. Npr, ako aplikacija mora čekati na vanjski resurs, može postati neodzivna. 



Da bismo to izbjegli, koristimo višenitno programiranje. Umjesto da sve zadatke izvršavamo u jednoj niti, stvaramo dodatne niti kako bismo izvršavali zadatke paralelno. Na primjer, umjesto da blokiramo glavnu nit čekanjem u jednoj metodi, stvaramo novu nit koja čeka na taj resurs, dok glavna nit nastavlja s drugim zadacima. 



Za potrebe demonstiranja dodacemo novu formu - frmIspis. Ideja je da odredjene poruke odnosno sadrzaj (response) koji dobijemo nakon pinganja neke lokacije odnosno vrijednosti njegovih propertija prikazemo unutar textbox-a. 

Na primjer: 

```c#
  private void frmPing_Load(object sender, EventArgs e)
  {
      PingGoogle();
      PingYahoo();
  }

  private void PingGoogle()
  {
      try
      {
          var ping = new Ping();
          for (int i = 0; i < 10; i++)
          {
              var odgovor = ping.Send("www.google.ba");
              txtIspis.Text += PingReplyToString(odgovor);
          }
      }
      catch (Exception ex)
      {
          txtIspis.Text = ex.Message;
      }
  }

  private void PingYahoo()
  {
      try
      {
          var ping = new Ping();
          for (int i = 0; i < 10; i++)
          {
              var odgovor = ping.Send("www.yahoo.ba");
              txtIspis.Text += PingReplyToString(odgovor);
          }
      }
      catch (Exception ex)
      {
          txtIspis.Text = ex.Message;
      }
  }

  private string PingReplyToString(PingReply odgovor)
  {
      return $"{odgovor.Address}\t{odgovor.RoundtripTime}\t{odgovor.Status}{Environment.NewLine}";
  }
```

Ovdje se adrese nesmetano ispisuju u nas textbox, medjutim ukoliko bi doslo do bilo kakvog zastoja u bilo kojoj od aktivnosti, na primjer ukoliko ne dobijemo odgovor i imamo neko vrijeme cekanja to moze znatno usporiti nasu aplikaciju ili mogucnost da vidimo neki sadrzaj. 

Za potrebe simulacije uspavacemo nas thread za 1000 milisekundi ili 1 sekundu, mozemo staviti 5 dio sekunde prilikom testiranja. 

Npr. u obje metode cemo dodati Thread.Sleep

```c#
 private void PingGoogle()
 {
     try
     {
         var ping = new Ping();
         for (int i = 0; i < 10; i++)
         {
             var odgovor = ping.Send("www.google.ba");
             txtIspis.Text += PingReplyToString(odgovor);
             Thread.Sleep(200); //uspavljujemo thread za petinu sekunde 
         }
     }
     catch (Exception ex)
     {
         txtIspis.Text = ex.Message;
     }
 }
```

Kada prilikom svakog poziva su oba threada uspavana za samo petinu sekunde, nasa aplikacija ili prikaz forme znatno kasni. Ovo se desava jer smo poziv metoda dodali u formLoad metodi. formLoad metoda je ona metoda koja se izvrsava neposredno prije prikaza forme

```c#
  private void frmPing_Load(object sender, EventArgs e)
  {
      PingGoogle();
      PingYahoo();
  }
```

Da bi nam se forma prikazala sto prije, dodacemo dugmic btnPing u ciji cemo Load premjestiti logiku poziva ovih threadova. 

Sada kada kliknemo na dugme Ping desice se cekanje od 4 sekunde prije nego sto dobijemo odgovor i nemamo nikakvu povratnu informaciju od ovog buttona o tome sta se desava. 

Ove dvije metode se odvijaju u glavnom Threadu trenutno, a nama je zelja da ove metode prepustimo zasebnim thread-ovima. 

Napravicemo Thread Yahoo koji ce biti zaduzen za metodu PingYahoo i napravicemo thread Google koji ce biti zaduzen za metodu PingGoogle. 

Za kreiranje Threadova koristimo Thread klasu: 

```c#
    private void btnPing_Click(object sender, EventArgs e)
    {

        Thread google = new Thread(PingGoogle);
        Thread yahoo = new Thread(PingYahoo);

        google.Start();
        yahoo.Start();
//instanciranje threadova ne znaci njihovo izvrsenje, tu nam je na raspolaganju metoda start. 
    }
```

Prilikom pokretanja dobicemo error u catch block-u. Razlog toga je zato sto main thread ne dozvoljava da se iz drugih thread-ova direktno komunicira sa njegovim kontrolama, u ovom slucaju se radi o kontroli txtIspis koja pripada glavnom Threadu. 

Jedan od nacina da rijesimo ovaj problem je da napravimo tzv "dijeljeni resurs". To je jedan property tipa string i ovim nasim metodama cemo reci da sadrzaj koji zele da ispisu dodaju u okviru ovog propertija i nemojte se direktno obracati kontroli txtIspis tako da cemo sada puniti ovaj ispis u obje metode.  

Sada se postavlja pitanje kada bi trebali sadrzaj ovog propertija prikazati unutar txtIspis metode. To mozemo raditi na kraju u btnClick metodi. 

```c#
    private void btnPing_Click(object sender, EventArgs e)
    {

        Thread google = new Thread(PingGoogle);
        Thread yahoo = new Thread(PingYahoo);

        google.Start();
        yahoo.Start();

        //PingGoogle();
        //PingYahoo();

        PrikaziSadrzaj(); //
        
    }

    private void PrikaziSadrzaj()
    {
        txtIspis.Text = Sadrzaj; // 
    }
```

Inicijalno ce nam se prikazati prazan txt jer u pozivu metode PrikaziSadrzaj() nismo cekali da se oba thread-a zavrse vec smo odmah otisli u izvrsenje ove metode te sadrzaj koji je u tom momentu bio unutar ovog properija  je zapravo bio prazan string i zato nista nije ispisano u nasem txtBoxu. Ukoliko opet kliknemo dugme Ping prikazace nam se nas sadrzaj iz razloga sto dok smo mi cekali ovi threadovi su se izvrsava te su punili sadrzaj propertija te kad smo drugi put kliknuli vec je postojala znacajna kolicina sadrzaja.  

```c#
private void btnPing_Click(object sender, EventArgs e)
{

    Thread google = new Thread(PingGoogle);
    Thread yahoo = new Thread(PingYahoo);

    google.Start();
    yahoo.Start();

    google.Join();
    yahoo.Join();

    PrikaziSadrzaj();
}
```

Koristimo Join jer zelimo da nasi google i yahoo threadovi prvo zavrse svoje izvrsenje pa tek onda da je ispisemo u textbox-u. Medjutim i u ovom slucaju smo napravili blokadu glavnog Thread-a zato sto ce Join metode zaustaviti izvrsenje glavnog thread-a odnosno ovaj dio ce cekati da se izvrse oba thread-a da se nastavi dalje. Ovo nam narusava smisao jer smo mi threadove kreirali da ne bismo morali zaustavljati glavni thread. 

Jedan od nacina koje mozemo iskorisiti da bismo komunicirali s nasim threadom je pozivom metode **BeginInvoke**. BeginInvoke od nas trazi neki action odnosno neku metodu koja ce se izvrsiti na glavnom threadu. 

Mozemo takodjer pomjeriti sadrzaj na kraj 

```c#
    private void PrikaziSadrzaj()
    {
        txtIspis.Text = Sadrzaj;
        PomjeriNaKraj();
    }

    private void PomjeriNaKraj()
    {
        txtIspis.SelectionStart = txtIspis.Text.Length;
    }
```



Sada cemo umjesto dvije metode kreirati jednu metodu kojoj cemo proslijediti vrijednosti koje su u ovom slucaju promjenjive, a to su npr. broj ponavljanja, adresa koja se pinga, duzinu uspavljivanja threada... 



