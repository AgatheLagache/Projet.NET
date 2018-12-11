using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.Controller
{
    public interface IRestaurantController
    {
        IRestaurantModel getRestaurantModel();

        IRestaurantView getRestaurantView();

        void play();
    }
}
