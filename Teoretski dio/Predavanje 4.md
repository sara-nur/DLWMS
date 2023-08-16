## Forme

```c#
var startnaForma = new Form1();
            
Application.Run(startnaForma); // u main metodi naznacavamo koja ce Forma prva pokrenuti, po defaultu ce biti Application.Run(new Form1()); 

```

**Imenovanje**

Konvekcija je da sve tipove imenujemo nekim prefixom koji jasno opisuje taj tip ili skracenicom koji opisuje taj tip. Ovo nam je posebno korisno jer će nam intelicence kada unesemo frm samo izlistati forme. npr. za formu je to txt, za button btn... Možemo dodati i sufix.



##  InitializeComponent (); 

```c#
 public frmXO( )
        {
            InitializeComponent (); 
 //drugi dio Forme, unutar nje je definisano sve što se nalazi u našoj formi. 
 //sve što mi promjenimo u Design-u Forme, ono će se reflektivati na InitializeComponentu. 
     
       }
```

Ovaj dio koda je izolovan i skriven, a za bilo kakve promjene na Formi, možemo korisiti Property Window. Bez da mijenjamo stvari kroz kod, ovaj propery window nam omogućava da izvršimo sve promjene lako za svaki dio Forme. Na ovaj način, promjene će se reflektovati u InitializeComponent bez da smo manualno pravili promjene. 



## Toolbox, Properties Window

Kada bi kreirali dugme kroz InitializeComponent manuelno, moramo se sjetiti da dodamo i sljedeći dio koda pored svih propertija: 

```c#
Controls.Add (button2); // u suprotnom, dugmic se nece prikazati
```

Ovim vidimo da nam je puno lakše i puno efikasnije da koristimo Toolbox i da prevlačimo ono što nam treba na našu formu. Time, on će sam da doda sav kod u pozadini bez da mi moramo da išta mijenjamo kroz kod. 

Ovo nam omogućava da se mi bavimo samo poslovnom logikom, a ne i dodavanjem Buttona, textbox-ova i slično. 



## Partial class

One nam služe za razdvajanje koda. Jedan dio klase - svi dijelovi koda koji se generišu, a drugi dio klase koji piše developer i kod koji bi se inače izgubio da je zajedno sa kodom koji se stalno generiše iznova. Mi ćemo moći pristupiti svim propertijima i iz jednog dijela, i iz drugog dijela kroz objekat te klase. 



## Events - događaji na koje će reagovati naše kontorle

Implementiramo metode koje će se automatski pozvati kada se nešto desi. npr. za dugmić, jedan od najkorištenijih metoda je click. 

```c#
public int Brojac { get; set; }
  

private void button1_Click( object sender , EventArgs e ) //naziv kontrole i naziv eventa
        {
            Brojac++;
            //this.Text = $"Klik {Brojac}"; //prikazuje koliko puta je dugmic kliknut u nazivu forme
             button1.Text = $"Klik {Brojac}"; //mijenja vrijednost unutar samog dugmica 
        }
//Kao prvi parametar se šalje onaj objekat koji je trigerovao tu metodu, npr. ovdje znamo da je to button1, pa je sender button1. Iako znamo da je u ovom slučaju sender button, a šalje se object. Object je bazni tip tako da će se on koristiti i za button, i za textbox... 
```

Sve ove metode su također vezane za InitializeComponent 



#### Forma - eventovi

Forma također ima svoje evente. 

**Mouse Event** 

```c#
 private void frmXO_MouseMove( object sender , MouseEventArgs e ) 
 //preko MouseEventArgs e on nam omogućuje da dobijemo X i Y kordinatu trenutne lokacije miša 
        {
            Text = $"X = {e.X} Y = {e.Y}"; //ispisuje X i Y lokaciju miša u imenu forme
     //this nije potrebno da koristimo 
        }
```



## XO Game

Kreiramo 9 dugmića, nakon toga je potrebno da omogućimo da klikom na dugme se prikaže **X** ili **O**.  

```c#
  if( button1.Text == "" ) //provjeravamo da li dugmic zauzet
            {
                if( Brojac % 2 == 0 ) //dodjeljujemo vrijednost X ili O 
                    button1.Text = "X";
                else
                    button1.Text = "O";
                Brojac++;
            }
```

Na ovaj način provjeravamo i postavljamo vrijednosti u button1. Međutim, mi imamo 9 dugmića koji bi imali identičan kod, sa razlikom u imenu button2, button3... Da bi izbjegli redundantnost, kreiramo metodu. 

```c#
  private void button2_Click( object sender , EventArgs e )
        {
            DugmicOdabran(sender); //ovjde je sender button2
        }

        private void DugmicOdabran(object sender)
        {
            if (sender is Button) //Ukoliko je sender dugmmic
            {
                var button = sender as Button; //postavimo vrijednost sendera kao button, (biće ime buttona koji se šalje, u našem slučaju button1, button2...)
                if( button.Text == "" )
                {
                    if( Brojac % 2 == 0 )
                        button.Text = "X";
                    else
                        button.Text = "O";
                     if (KrajIgre())
                        PostaviStatus(false);
                    Brojac++;
                }
            }
        }
```



Nakon toga, treba da kreiramo logiku provjere pobjednika. 

```c#
           private void PostaviStatus(bool enabled)
        {
            foreach (var kontrola in this.Controls)  //zelimo da prodjemo kroz sve kontrole unutar Controls
            {
                if (kontrola is Button)    //prvo provjeravamo da li kontrola button, ako jeste onda 
                    (kontrola as Button).Enabled = enabled;  //njegov property Enabled postavi kao enabled
                //Kada je Enabled postavljen na false za button onda necemo moci kliknuti na dugmic 
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale() ;
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                   ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu (button1 , button4 , button7) ||
                   ProvjeriPobjedu (button2 , button5 , button8) ||
                   ProvjeriPobjedu (button3 , button6 , button9);
        }

        private bool ProvjeriRedove()
        {
           return ProvjeriPobjedu(button1,button2,button3) ||
                  ProvjeriPobjedu(button4,button5,button6) ||
                  ProvjeriPobjedu(button7,button8,button9); 
        }

        private bool ProvjeriPobjedu(Button Button1, Button Button2, Button Button3)
        {
            var pobjeda= Button1.Text !="" && Button1.Text == Button2.Text && Button2.Text == Button3.Text;
            if (pobjeda)
                Button1.BackColor = Button2.BackColor = Button3.BackColor = Color.Blue;
            return pobjeda;
        }
```



Sada želimo da kreiramo mogućnost ponovnog započinjanja igre, pa ćemo kreirati još jedno dugme i moraćemo napraviti izmjene u ProvjeriStatus 

```c#
    private void PostaviStatus(bool enabled, bool resetText = false, bool resetColor = false)
        {
            foreach( var kontrola in this.Controls ) 
            {
                if (kontrola is Button) 
                {
                    var button = kontrola as Button;
                    if (button != btnNovaIgra)
                    {
                        button.Enabled = enabled; 
                        if (resetText) 
                            button.Text = "";
                        if (resetColor)
                            button.UseVisualStyleBackColor = true;
                    }
                }
            }
        }

//sada postavimo sve parametre na true u buttonu btnNovaIgra Click event
 private void button10_Click( object sender , EventArgs e )
        {
            PostaviStatus (true, true, true);
        }
```



Sada nam je još ostalo da se brojač mijenja, dakle da jednom počinje sa X, a naredni put sa O



```c#
 private void DugmicOdabran( object sender )
        {
            if( sender is Button )
            {
                var button = sender as Button;
                if( button.Text == "" )
                {
                    button.Text = Brojac % 2 == 0 ? "X" : "O"; //ako je vrijednost Brojaca parna postavi na X, ako nije na O

                    if( KrajIgre () )
                        PostaviStatus (false);

                    Brojac++;
                }
            }
        }
```



Također, kada želimo da šaljemo različit broj parametara na različitim mjestima, možemo da kreiramo klasu unutar koje ćemo objediniti sve što nam treba

```c#
        private void PostaviStatus( StatusDugmica  status)
        {
            foreach( var kontrola in this.Controls )
            {
                if( kontrola is Button )
                {
                    var button = kontrola as Button;
                    if( button != btnNovaIgra )
                    {
                        button.Enabled = status.Enabled;
                        if( status.ResetText )
                            button.Text = "";
                        if( status.ResetColor )
                            button.UseVisualStyleBackColor = true;
                    }
                }
            }
        }

    public class StatusDugmica
    {
        public bool Enabled { get; set; }
        public bool ResetText { get; set; }
        public bool ResetColor { get; set; }
    }

//na ovaj nacin mozemo da dodajemo koliko zelimo propertija u klasu StatusDugmica, na ovaj nacin ne afektiramo ni na koji nacin metodu PostaviStatus, mozemo da iskoristimo sve propertije ili npr. dva...

Sada mijenjamo i poziv u metodi DugmicOdabran
   if( KrajIgre () )
         PostaviStatus ( new StatusDugmica(){Enabled = false});

Također izmjene vršimo i u dugmetu
     private void button10_Click( object sender , EventArgs e )
        {
            PostaviStatus (new StatusDugmica(){Enabled = true, ResetColor = true, ResetText = true});
        }

//Na ovaj način se ne afektiraju drugi pozivi 
```



Sada možemo dodati opciju dodavanja imena. Možemo to dodati ili na početak ili u sklopu dugmeta nova igra. Za to smo kreirali novu formu, sa dva textbox-a i dva label-a. 

```c#
private void button1_Click( object sender , EventArgs e )
        {
            Igrac1 = txtIgrac1.Text;
            Igrac2 = txtIgrac2.Text;

            if (Igrac1 != "" && Igrac2 != "")
                Close();
        }
//Kada se unesu imena Igraca1 i Igraca2, pohranjujemo te vrijednosti i zatvaramo formu za unos imena.
```

 Zatim bi se trebali vratiti u našu formu XO

```c#
 public string XOIgrac1 { get; set; }
 public string XOIgrac2 { get; set; }

private void button10_Click( object sender , EventArgs e )
        {
            var unosImena = new frmXOIgraci ();
            unosImena.ShowDialog ();
     //sada imamo mogucnost da pristupimo imenima koje je korisnik unio na formi frmXOIgraci, mozemo dodati i property Igrac1 i Igrac2 i u ovo formu pa da u njih pohranjujemo vrijednosti 
            XOIgrac1 = unosImena.Igrac1;
            XOIgrac2 = unosImena.Igrac2;
            PostaviStatusDugmica (new StatusDugmica () { Enabled = true , ResetColor = true , ResetText = true });

        }
```

Sada možemo da na formi prikažemo ko igra sljedeći, to ćemo uraditi preko label-a. Pošto ćemo obavljati interakciju sa ovim label-om, mijenjaćemo mu sadržaj i sl. bitno nam je da imamo neki adekvatan naziv, npr lblNaredniIgrac
