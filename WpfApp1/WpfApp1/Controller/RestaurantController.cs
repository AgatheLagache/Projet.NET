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
        private IScenario scenario;

        /* Instancie un nouveau controleur du restaurant */
        public RestaurantController(IRestaurantModel restaurantModel, IRestaurantView restaurantView)
        {
            this.setRestaurantView(restaurantView);
            this.setRestaurantModel(restaurantModel);
        }


        /* Récupère le model du restaurant et le retourne */
        public IRestaurantModel getRestaurantModel()
        {
            return this.restaurantModel;
        }


        private void setRestaurantModel(IRestaurantModel model)
        {
            this.restaurantModel = model;
        }

        /* Récupère la vue du restaurant et la retourne */
        public IRestaurantView getRestaurantView()
        {
            return this.restaurantView;
        }

        private void setRestaurantView(IRestaurantView view)
        {
            this.restaurantView = view;
        }

        public void startScenario()
        {
            scenario.initializeScenario(1);
        }

        public void play()
        {
            this.startScenario();
        }

        public void pause()
        {

        }

        public void replay()
        {

        }

        //public void speedUp()
        //{
        //}
    }
}
