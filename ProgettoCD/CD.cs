using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCD
{
    internal class CD
    {

        List<brano> brani = new List<brano>();

        string titolo;
        string autore;
        string listaDiBrani;

        public void costruttore(string titolo, string autore, List<brano> listaDiBrani )
        {
            this.titolo = titolo;
            this.autore = autore;
            this.listaDiBrani = brani;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public string toString()
        {
            return "schec che rec che reb be";
        }

        public string Durata()
        {
            return "non so come fare questo metodo.";
        }
    }
}
