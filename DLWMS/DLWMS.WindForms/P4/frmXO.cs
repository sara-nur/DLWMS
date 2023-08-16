using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WindForms
{
    public partial class frmXO : Form
    {
        public int Brojac { get; set; }
        public string XOIgrac1 { get; set; }
        public string XOIgrac2 { get; set; }


        public frmXO( )
        {
            InitializeComponent ();

        }

        private void frmXO_Load( object sender , EventArgs e )
        {
            PokreniNovuIgru ();
        }


        private void DugmicOdabran( object sender )
        {
            if( sender is Button )
            {
                var button = sender as Button;
                if( button.Text == "" )
                {
                    button.Text = Brojac % 2 == 0 ? "X" : "O";


                    if( KrajIgre () )
                        PostaviStatusDugmica (new StatusDugmica () { Enabled = false });

                    Brojac++;
                    PrikaziNarednogIgraca ();
                }
            }
        }

        private void PrikaziNarednogIgraca( )
        {
            lblNaredniIgrac.Text = Brojac % 2 == 0 ? XOIgrac1 : XOIgrac2;

        }

        private void PostaviStatusDugmica( bool enabled , bool resetText = false , bool resetColor = false )
        {
            foreach( var kontrola in this.Controls )
            {
                if( kontrola is Button )
                {
                    var button = kontrola as Button;
                    if( button != btnNovaIgra )
                    {
                        button.Enabled = enabled;
                        if( resetText )
                            button.Text = "";
                        if( resetColor )
                            button.UseVisualStyleBackColor = true;
                    }
                }
            }
        }
        //drugi nacin
        private void PostaviStatusDugmica( StatusDugmica status )
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

        private bool KrajIgre( )
        {
            return ProvjeriRedove () || ProvjeriKolone () || ProvjeriDijagonale ();
        }

        private bool ProvjeriDijagonale( )
        {
            return ProvjeriPobjedu (button1 , button5 , button9) ||
                   ProvjeriPobjedu (button3 , button5 , button7);
        }

        private bool ProvjeriKolone( )
        {
            return ProvjeriPobjedu (button1 , button4 , button7) ||
                   ProvjeriPobjedu (button2 , button5 , button8) ||
                   ProvjeriPobjedu (button3 , button6 , button9);
        }

        private bool ProvjeriRedove( )
        {
            return ProvjeriPobjedu (button1 , button2 , button3) ||
                   ProvjeriPobjedu (button4 , button5 , button6) ||
                   ProvjeriPobjedu (button7 , button8 , button9);
        }

        private bool ProvjeriPobjedu( Button Button1 , Button Button2 , Button Button3 )
        {
            var pobjeda = Button1.Text != "" && Button1.Text == Button2.Text && Button2.Text == Button3.Text;
            if( pobjeda )
                Button1.BackColor = Button2.BackColor = Button3.BackColor = Color.Blue;
            return pobjeda;
        }


        private void button1_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button2_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender); //button2
        }

        private void button3_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button4_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button5_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button6_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button7_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button8_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }

        private void button9_Click( object sender , EventArgs e )
        {
            DugmicOdabran (sender);
        }


        private void button10_Click( object sender , EventArgs e )
        {
            PostaviStatusDugmica (new StatusDugmica () { Enabled = true , ResetColor = true , ResetText = true });
            PokreniNovuIgru ();
        }

        private void PokreniNovuIgru( )
        {
            var unosImena = new frmXOIgraci ();
            unosImena.ShowDialog ();
            XOIgrac1 = unosImena.Igrac1;
            XOIgrac2 = unosImena.Igrac2;
            Brojac = 0;
            PrikaziNarednogIgraca ();
        }
    }


    public class StatusDugmica
    {
        public bool Enabled { get; set; }
        public bool ResetText { get; set; }
        public bool ResetColor { get; set; }
    }
}
