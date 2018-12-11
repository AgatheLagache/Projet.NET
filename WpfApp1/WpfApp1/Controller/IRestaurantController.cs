using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controller
{
    public interface IRestaurantController
    {
        IRestaurantController getRestaurantModel();

        IRestaurantController getRestaurantView();
    }
}
