using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.Controller
{
    public class RestaurantController : IRestaurantController
    {
        /* déclaration du model restaurant de l'interface IRestaurantModel */
        private IRestaurantModel restaurantModel;

        /* déclaration de la vue restaurant de l'interface IRestaurantView */
        private IRestaurantView restaurantView;

        /* Instancie un nouveau controleur du restaurant */
        RestaurantController(IRestaurantModel restaurantModel, IRestaurantView restaurantView)
        {
            this.setRestaurantView();
            this.setRestaurantModel();
        }

        /* Récupère le model du restaurant et le retourne */
        public IRestaurantController getRestaurantModel()
        {
            return this.restaurantModel;
        }


        private void setRestaurantModel(IRestaurantModel model)
        {
            this.restaurantModel = model;
        }

        /* Récupère la vue du restaurant et l retourne */
        public IRestaurantController getRestaurantView()
        {
            return this.restaurantView;
        }

        private void setRestaurantView(IRestaurantView view)
        {
            this.restaurantView = view;
        }

        public void startScenario()
        {

        }

        public void pause()
        {
            //mythread.
        }

        public void replay()
        {

        }

        public void speedUp()
        {

        }
    }
}
