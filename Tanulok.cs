using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyszerutanulok_20241205
{
    internal class Tanulok
    {
        string igszam;
        string nev;
        DateTime szulido;
        string osztaly;
        string irszam;
        string varos;
        string utca;

        public string Igszam { get => igszam; set => igszam = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szulido { get => szulido; set => szulido = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public string Irszam { get => irszam; set => irszam = value; }
        public string Varos { get => varos; set => varos = value; }
        public string Utca { get => utca; set => utca = value; }
    
        public Tanulok(string sor)
        {
            string[] db = sor.Split(';');
            igszam = db[0];
            nev = db[1];
            szulido = Convert.ToDateTime(db[2]);
            osztaly = db[3];
            irszam = db[4];
            varos = db[5];
            utca = db[6];
        }
    }
}
