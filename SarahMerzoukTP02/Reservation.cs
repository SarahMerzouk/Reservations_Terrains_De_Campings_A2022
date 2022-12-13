using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahMerzoukTP02
{
    public class Reservation
    {
        private int _noReservation;
        private int _noCamping;
        private string _nomClient;
        private string _courriel;
        private string _typePaiement;
        private DateTimePicker _debutReservation;
        private DateTimePicker _finReservation;
        private int _nbAdultes;
        private int _nbEnfants;
        private decimal _coutTotal;
        private string _terrain;

        public Reservation() { }

        public Reservation(int noReservation , int noCamping, string nomClient, string courriel, string payement, DateTimePicker debut, DateTimePicker fin, int nbAdultes, int nbEnfants, decimal cout, string pTerrain  )
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
            _terrain = pTerrain;
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

        public DateTimePicker getDebutReservation()
        {
            return _debutReservation;
        }

        public DateTimePicker getFinReservation()
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

        public decimal getCoutTotal()
        {
            return _coutTotal;
        }

        public string getTerrain()
        {
            return _terrain;
        }
    }
}
