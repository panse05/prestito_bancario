using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Prestito
    {
        private double _importo;
        private double _interesse;
        private DateTime _dataInizio;
        private DateTime _dataFine;
        private Cliente _intestatario;

        public Prestito(double Importo, double Interesse, DateTime DataInizio, DateTime DataFine, Cliente Intestatario)
        {
            this.Importo = Importo;
            this.Interesse = Interesse;
            this.DataInizio = DataInizio;
            this.DataFine = DataFine;
            this.Intestatario = Intestatario;
        }

        public double Importo 
        {
            get { return _importo; }
            set { _importo = value; }
        }

        public double Interesse
        {
            get { return _interesse; }
            set
            {
                _interesse = value;
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
            get { return _intestatario; }
            set { _intestatario = value; }
        }

        

        public override string ToString()
        {
            return $"Importo: {Importo}, Interesse: {Interesse}, Data inizio: {DataInizio.ToShortDateString()}, Data fine: {DataFine.ToShortDateString()}, Cliente: {Intestatario.Nome} {Intestatario.Cognome}";
        }
    }
}
