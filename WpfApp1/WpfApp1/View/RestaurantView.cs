using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Controller;

namespace WpfApp1.View
{
    class RestaurantView : IRestaurantView, IRestaurantController
    {
        public IRestaurant Restaurant { get => restaurant; set => restaurant = value; }

        RestaurantView(IRestaurant restaurant)
        {

        }

        public IRestaurantController getRestaurantModel()
        {
            throw new NotImplementedException();
        }

        public IRestaurantController getRestaurantView()
        {
            throw new NotImplementedException();
        }
    }
}
