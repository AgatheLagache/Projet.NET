using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Controller;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1
{
    public class Start
    {
        public static void start()
        {
            IRestaurantModel restaurantModel = new RestaurantModel();
            IRestaurantView restaurantView = new RestaurantView();
            IRestaurantController restaurantController = new RestaurantController(restaurantModel, restaurantView);

            restaurantController.play();
        }
    }
}
