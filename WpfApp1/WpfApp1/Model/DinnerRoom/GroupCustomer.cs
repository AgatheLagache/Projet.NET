using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.DinnerRoom
{
    public class GroupCustomer
    {
        List<Customer> groupCustomer = new List<Customer>();

        public void isHere()
        {
            /* client vient d'arriver */
        }

        public void getNumberPerson()
        {
            /* retourner le nombre de client dans la liste */
        }

        public void exitRestaurant()
        {
            /* suppression du groupe de client */
        }

        public void paysbill()
        {
            /* méthode de paiement */
        }
    }
}
