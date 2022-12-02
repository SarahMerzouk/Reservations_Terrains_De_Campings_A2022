using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahMerzoukTP02
{
    public class Camping
    {
        private string chemin = Application.StartupPath + "\\"; // bin/debug/nte-window6.0

        private int _noCamping;
        private string _nomCamping;
        private int _nbTerrains;
        private string _cheminImage;
        private string _nomFichierCamping;

        public Camping(int pNoCamping, string pNomCamping, int pNbTerrains, string pCheminImage, string pNomFichier)
        {
            _noCamping = pNoCamping;
            _nomCamping = pNomCamping;
            _nbTerrains = pNbTerrains;
            _cheminImage =  chemin + pCheminImage;
            _nomFichierCamping = pNomFichier;
        }

        public Camping() { }

        public int getNoCamping()
        {
            return _noCamping;
        }

        public string getNomCamping()
        {
            return _nomCamping;
        }

        public int getNbTerrains()
        {
            return _nbTerrains;
        }

        public string getCheminImage()
        {
            return _cheminImage;
        }

        public string getNomFichierDuCamping()
        {
            return _nomFichierCamping;
        }

    }
}
