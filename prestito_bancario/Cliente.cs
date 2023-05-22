using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Cliente
    {
        //attributi
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private double _stipendio;
        
        //costruttore
        public Cliente(string Nome, string Cognome, string CodiceFiscale, double Stipendio)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.CodiceFiscale = CodiceFiscale;
            this.Stipendio = Stipendio;
        }

        //properties
        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome 
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string CodiceFiscale 
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public double Stipendio
        {
            get { return _stipendio; }
            set{ _stipendio = value; }
        }


        
    }
}
