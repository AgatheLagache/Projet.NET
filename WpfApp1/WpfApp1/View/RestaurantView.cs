using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.View
{
    class RestaurantView : IRestaurantView, IRestaurantController
    {
        public Restaurant Restaurant { get => restaurant; set => restaurant = value; }

        RestaurantView(Restaurant restaurant)
        {

        }

        start_Scenario()
        {

        }
    }
}
