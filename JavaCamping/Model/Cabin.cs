using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCamping.Model
{
    [Serializable]
    class Cabin
    {
        private int cabinID;
        public int CabinID
        {
            get { return cabinID; }
            set { cabinID = value; }
        }

        private string cabinName;

        public string CabinName
        {
            get { return cabinName; }
            set { cabinName = value; }
        }
        private bool cabinAvailable;

        public bool CabinAvailable
        {
            get { return cabinAvailable; }
            set { cabinAvailable = value; }
        }
        public Cabin(int CabinID, string CabinName, bool CabinAvailable)
        {
            this.cabinID = CabinID;
            this.cabinName = CabinName;
            this.cabinAvailable = CabinAvailable;
            
        }
    }
}
