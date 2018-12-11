using System;
using System.Collections.Generic;
using WpfApp1.Model.DALandBLL.Business;
using WpfApp1.Model.DALandBLL.Service;

namespace test_bdd
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Test ActionScenario

            ActionScenarioService actionScenarioService;
            actionScenarioService = new ActionScenarioService();
            List<ActionScenario> test = actionScenarioService.GetByScenarioId(1);
            foreach (var action in test)
            {
                Console.WriteLine("Action : " + action.Action.description + ", Fait par : " + action.Action.Acteur.role);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            List<ActionScenario> test2 = actionScenarioService.GetByActionId(5);
            foreach(var scenario in test2)
            {
                Console.WriteLine("Action faite dans le scenario : " + scenario.Scenario.id + " en " + scenario.ordre);
            }
            Console.ReadLine();


            //Test Acteur

            //ActeurService acteurService;
            //acteurService = new ActeurService();
            //List<Acteur> test = acteurService.Get();
            //foreach (var acteur in test)
            //{
            //    Console.WriteLine("Acteur : " + acteur.role);
            //}
            //Console.Read();


            //Test Scenario

            //ScenarioService scenarioService;
            //scenarioService = new ScenarioService();
            //Scenario test = scenarioService.GetById(2);
            //Console.WriteLine("Scenario : " + test3.titre);
            //Console.Read();


            //Test Action

            //ActionService actionService;
            //actionService = new ActionService();
            //List<WpfApp1.Model.DALandBLL.Business.Action> test = actionService.GetByActeurId(1);
            //foreach (var action in test)
            //{
            //    Console.WriteLine("Acteur : " + action.description);
            //}
            //Console.Read();
        }
    }
}