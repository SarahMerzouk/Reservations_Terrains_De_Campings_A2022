using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahMerzoukTP02
{
    internal class Camping
    {

        private int _noCamping;
        private string _nomCamping;
        private int _nbTerrains;
        private string _cheminImage;

        public Camping(int pNoCamping, string pNomCamping, int pNbTerrains, string pCheminImage)
        {
            _noCamping = pNoCamping;
            _nomCamping = pNomCamping;
            _nbTerrains = pNbTerrains;
            _cheminImage = pCheminImage;
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

    }
}
