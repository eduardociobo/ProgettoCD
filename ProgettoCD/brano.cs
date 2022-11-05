using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCD
{
    internal class brano
    {
        string titolo, autore;
        double durata;

        public brano(string titolobrano, double duratabrano)
        {
            titolo = titolobrano;
            durata = duratabrano;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public double getDurata()
        {
            return durata;
        }

        public void setTitolo(string titolodacambiare)
        {
            titolo = titolodacambiare;
        }

        public void setAutore(string autoredacambiare)
        {
            autore = autoredacambiare;
        }

        public void setDurata(string duratadacambiare)
        {
            durata = Convert.ToDouble(duratadacambiare);
        }

        public string toString()
        {
            return "L'autore del brano " + titolo + " è: " + autore + " e la durata è di " + durata + " minuti.";
        }

        public bool shortSong(double tempo)
        {
            if(durata < tempo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
