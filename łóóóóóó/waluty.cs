using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class waluty
    {
        private double kurs;
        private string nazwa;

        public waluty(double kurs, string nazwa)
        {
            this.kurs = kurs;
            this.nazwa = nazwa;
        }

        public double getKurs()
        {
            return kurs;
        }

        public void setKurs(double kurs)
        {
            this.kurs = kurs;
        }
        public string getNazwa()
        {
            return nazwa;
        }



    }
}
