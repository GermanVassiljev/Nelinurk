using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Nelinurk
    {
        int kõrgus;
        int laius;
        string tüüp;
        public string Tüüp
        {
            set
            {
                string tüüp;
                if (kõrgus == laius)
                {
                    tüüp = "Ruut";
                }
                else if (kõrgus != laius)
                {
                    tüüp = "Ristkülik";
                }
                else
                {
                    tüüp = "Ebakorrapärane ruut";
                }
            }
            get
            {
                return tüüp;
            }
        }
        public Nelinurk() { }
        public Nelinurk(int kõrgus, int laius)
        {

        }
        public double Ala
        {
            set
            {
                double S;
                if (tüüp=="Ruut")
                {
                    S = kõrgus * kõrgus;
                }
                else if (tüüp=="Ristkülik")
                {
                    S = kõrgus * laius;
                }

            }
            get
            {
                return S;
            }
        }
        public double Ümbermõõt
        { }
    }
}
