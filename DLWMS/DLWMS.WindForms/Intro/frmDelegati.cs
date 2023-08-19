using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WindForms.Intro
{
    public partial class frmDelegati : Form
    {
        public frmDelegati( )
        {
            InitializeComponent ();
            PotpisMetode p = PrvaGodina;
           
        }

        delegate void PotpisMetode( string s );
        event PotpisMetode DLWMSNotifikacije;

        private void PrvaGodina( string poruka )
        {
            MessageBox.Show ($"PRVA GODINA -> {poruka}");
        }

        private void DrugaGodina( string poruka )
        {
            MessageBox.Show ($"DRUGA GODINA -> {poruka}");

        }

        private void TrecaGodina( string poruka )
        {
            MessageBox.Show ($"TRECA GODINA -> {poruka}");

        }

        private void frmDelegati_Load( object sender , EventArgs e )
        {

        }

        private void button1_Click( object sender , EventArgs e )
        {
           // DLWMSNotifikacije?.Invoke(txtPoruka.Text);
           // Func<int,int> func = Saberi;
           YieldDemo();
        }

        int Test(int a, float b, string c) { return 0;}
        int Saberi(int broj){ return broj+broj;}
        int Hvadriraj(int broj){ return broj*broj;}
        int Kubiraj(int broj){ return broj*broj*broj; }

        delegate int MatMetoda(int metode);

        private event MatMetoda Izracunaj;

        private int Calc(MatMetoda metoda, params int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                suma += metoda (niz[i]);
            }
            return suma;
        }

        private void PretplataNaDogadjaj( object sender , PotpisMetode metoda )
        {
            if( ( sender as CheckBox ).Checked )
                DLWMSNotifikacije += metoda;
            else
                DLWMSNotifikacije -= metoda;
        }

        private void cbPrvaGodina_CheckedChanged( object sender , EventArgs e )
        {
            PretplataNaDogadjaj (sender , PrvaGodina);
        }

        private void cbDrugaGodina_CheckedChanged( object sender , EventArgs e )
        {
            PretplataNaDogadjaj (sender , DrugaGodina);
        }

        private void cbTrecaGodina_CheckedChanged( object sender , EventArgs e )
        {
            PretplataNaDogadjaj (sender , TrecaGodina);
        }

        private void txtPoruka_TextChanged( object sender , EventArgs e )
        {

        }

        private void YieldDemo()
        {
            Kandidat kandidat = new Kandidat();
            foreach (var ocjene in kandidat)
            {
                
            }
        }

    }
                          
    public class Kandidat
    {
        List<int> ocjene = new List<int>() {4,5,3,4,5,3,3,4};

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ocjene.Count; i++)
            {
                yield return ocjene[i] ;
            }
        }
    }


}
