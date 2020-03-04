using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Traumschiff_Beamer {
    class Program {
        static void Main ( string [] args ) {
            Console.WriteLine ("Traumschiff");

            Traumschiff germania = new Traumschiff () { Name = "Germania" };
            Traumschiff persia = new Traumschiff () { Name = "Persia" };

            Thread germaniaThread = new Thread ( new ThreadStart(germania.Herumfahren));
            Thread persiaThread = new Thread ( new ThreadStart(persia.Herumfahren));

            //germaniaThread.Start ();
            persiaThread.Start ();


            //for ( int i = 0 ; i < 10 ; i++ ) {
            //    germania.Herumfahren ();
            //    persia.Herumfahren ();
            //    Thread.Sleep ( 1000 );
            //    Console.Clear ();
            //}
            

            Console.ReadLine ();
        }
    }
}
