using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Nelinurk
    {
        double kõrgus;
        double laius;
        double diagonaal;
        int süstimine;
        int süstimine_2;
        private string tüüp;
        double S;
        double P;

        public string Tüüp
        {

            get
            {
                if (kõrgus == laius)
                {
                    Console.WriteLine("Kirjuta Nelinurga nurk.");
                    süstimine = int.Parse(Console.ReadLine());
                    if (süstimine == 90)
                    {
                        tüüp = "Ruut";
                    }
                    else if (süstimine == 60)
                    {
                        tüüp = "Romb";
                    }
                }
                else if (kõrgus != laius)
                {
                    
                    if (süstimine == 90)
                    {
                        tüüp = "Ristkülik";
                    }
                    else
                    {
                        tüüp = "Rööpkülik";
                    }
                }
                return tüüp;
            }
        }
        public Nelinurk() { }
        public Nelinurk(double Kõrgus, double Laius)
        {
            kõrgus = Kõrgus;
            laius = Laius;
        }
        public double Kõrgus
        {
            set { if (kõrgus == 0) kõrgus = value; }
            get
            {
                return kõrgus;
            }
        }
        public double Laius
        {
            set { if (laius == 0) laius = value; }
            get
            {
                return laius;
            }
        }
        public double Ala
        {
            get
            {
                if (tüüp == "Ruut")
                {
                    S = kõrgus * kõrgus;
                }
                else if (tüüp == "Ristkülik")
                {
                    S = kõrgus * laius;
                }
                return S;
            }
        }
        public double Ümbermõõt
        {
            get
            {
                if (tüüp == "Ruut")
                {
                    P = kõrgus * 4;
                }
                else if (tüüp == "Ristkülik")
                {
                    P = (kõrgus + laius) * 2;
                }
                return P;
            }
        }
        public double Diagonaal
        {
            get
            {
                diagonaal = Math.Sqrt(kõrgus * kõrgus + laius * laius) ;
                return diagonaal;
            }
        }
        public int Kivisüsi
        {
            get
            {
                if (tüüp=="Ruut")
                {
                    süstimine_2 = 90;
                }
                else if (tüüp=="Romb")
                {
                    süstimine_2 = 120;
                }
            }
        }
        public void Info()
        {
            Console.WriteLine("Tüüp on {0}. Ala on {1} cm^2 ja ümbermõõt on {2} cm. Diagonaal on {3}", Tüüp, Ala, Ümbermõõt, Diagonaal);
        }
    }
}
