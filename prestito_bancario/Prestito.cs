using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Prestito
    {
        private double _ammontare;
        private double _rata;
        private DateTime _dataInizio;
        private DateTime _dataFine;
        private Cliente _intestario;

        public Prestito(double Ammontare, double Rata, DateTime DataInizio, DateTime DataFine, Cliente Intestatario)
        {
            this.Ammontare = Ammontare;
            this.Rata = Rata;
            this.DataInizio = DataInizio;
            this.DataFine = DataFine;
            this.Intestatario = Intestatario;
        }

        public double Ammontare 
        {
            get { return _ammontare; }
            set { _ammontare = value; }
        }

        public double Rata
        {
            get { return _rata; }
            set
            {
                _rata = value;
            }
        }

        public DateTime DataInizio 
        {
            get { return _dataInizio; }
            set
            {
                _dataInizio = value;
            }
        }

        public DateTime DataFine 
        {
            get { return _dataFine; }
            set
            {
                _dataFine = value;
            }
        }

        public Cliente Intestatario 
        {
            get { return _intestario; }
            set { _intestario = value; }
        }

        /*public override string ToString()
        {
            return string.Format("Ammontare: {0}\nRata: {1}\nDataInizio: {2}\nDataFine: {3}\nIntestatario:\n{4}",
                                   this.Ammontare,
                                   this.Rata,
                                   this.DataInizio,
                                   this.DataFine,
                                   this.Intestatario.ToString());
        }*/
    }
}
