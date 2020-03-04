using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Traumschiff_Beamer {
    class Traumschiff {
        public string Name { get; set; }
        public Koordinate Koordinate { get; set; }
        private Random zfg = new Random ();

        public void Herumfahren () {
            while ( true ) {
                this.Koordinate = BeschaffeNeueZielKoordinaten ();
                this.SchiffAnzeigen (Name);
                Thread.Sleep (3000);
            }
        }

        public void SchiffAnzeigen (string name) {
            Console.SetCursorPosition( this.Koordinate.X, this.Koordinate.Y );
            Console.Write ("-^-"+name);
        }

        public Koordinate BeschaffeNeueZielKoordinaten () {
            Koordinate k = new Koordinate ();
            int x = zfg.Next ( 0, 81 );
            int y = zfg.Next (0,26);
            k.X = x;
            k.Y = y;
            return k;
        }

    }
}
