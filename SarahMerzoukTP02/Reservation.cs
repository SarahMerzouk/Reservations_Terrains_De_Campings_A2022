using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahMerzoukTP02
{
    internal class Reservation
    {
        private int _noReservation;
        private int _noCamping;
        private string _nomClient;
        private string _courriel;
        private string _typePaiement;
        private DateTime _debutReservation;
        private DateTime _finReservation;
        private int _nbAdultes;
        private int _nbEnfants;
        private float _coutTotal;

        public Reservation() { }

        public Reservation(int noReservation , int noCamping, string nomClient, string courriel, string payement, DateTime debut, DateTime fin, int nbAdultes, int nbEnfants, float cout  )
        {
            _noReservation = noReservation;
            _noCamping = noCamping;
            _nomClient = nomClient;
            _courriel = courriel;
            _typePaiement = payement;
            _debutReservation = debut;
            _finReservation = fin;
            _nbAdultes = nbAdultes;
            _nbEnfants = nbEnfants;
            _coutTotal = cout;
        }

        public int getNoReservation()
        {
            return _noReservation;
        }

        public int getNoCamping()
        {
            return _noCamping;
        }

        public string getNomClient()
        {
            return _nomClient;
        }

        public string getCourriel()
        {
            return _courriel;
        }

        public string getTypeDePaiement()
        {
            return _typePaiement;
        }

        public DateTime getDebutReservation()
        {
            return _debutReservation;
        }

        public DateTime getFinReservation()
        {
            return _finReservation;
        }

        public int getNbAdultes()
        {
            return _nbAdultes;
        }

        public int getNbEnfants()
        {
            return _nbEnfants;
        }

        public float getCoutTotal()
        {
            return _coutTotal;
        }
    }
}
