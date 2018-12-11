using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Controller;
using WpfApp1.Model;

namespace WpfApp1.View
{
    class RestaurantView : IRestaurantView
    {
        public IScenario scenario { get => scenario; set => scenario = value; }

        public RestaurantView()
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
