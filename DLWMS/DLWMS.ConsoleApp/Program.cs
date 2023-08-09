using System;
using System.Text;
using DLWMS.ConsoleApp.Helpers;
using DLWMS.ConsoleApp.Predavanja.P1;
using DLWMS.ConsoleApp.Predavanja.P2;
using DLWMS.ConsoleApp.Predavanja.P3;

namespace DLWMS.ConsoleApp
{

    public class Program
    {


        public static void Main(string[] args )
        {
            //MainP1.Pokreni();
            //MainP2.Pokreni ();
            MainP3.Pokreni(new FileLogger());
        
        }
    }
}
