using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.DinnerRoom
{
    public class MaitreHotel
    {
        private static MaitreHotel uniqueInstance;
        protected MaitreHotel()
        {

        }

        public static MaitreHotel Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new MaitreHotel();
            }
            return uniqueInstance;
        }

        public void askNumberPerson()
        {
            /* demande le nombre de client à l'entrée du restaurant */
        }

        public void chooseTable()
        {
            /* choix de la table en fonction du nombre de personnes */
        }

        public void askHeadWaiter()
        {
            /* appelle le chef de rang pour placer les clients sur la bonne table */
        }

        public void giveOrder()
        {
            /* donne les ordres au chef de rang */
        }

        public void takePaysbill()
        {
            /* prend les paiements des clients */
        }
    }
}
