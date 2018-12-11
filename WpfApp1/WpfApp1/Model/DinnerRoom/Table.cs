using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.DinnerRoom
{
    public class Table
    {
        private int nbPlace;

        private bool isAvailable;

        List<Table> listTable = new List<Table>();

        Table(int nbPlace, bool isAvailable)
        {
            this.setNbPlace(nbPlace);
            this.setAvailability(isAvailable);
        }

        public int getNbPlace()
        {
            return 0;
        }

        public void setNbPlace(int place)
        {
            this.nbPlace = place;
        }

        public bool getAvailability()
        {
            return true;
        }

        public void setAvailability(bool available)
        {
            this.isAvailable = available;
        }
    }
}
