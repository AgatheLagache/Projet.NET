using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Persistance.DAO;

namespace WpfApp1.Model.DALandBLL.Business.Mapper
{
    public class ActionScenarioMapper
    {
        public static ActionScenarioDAO Map(ActionScenario value)
        {
            return new ActionScenarioDAO
            {
                ordre = value.ordre,
                actionId = ActionMapper.Map(value.Action).id,
                scenarioId = ScenarioMapper.Map(value.Scenario).id
            };
        }

        public static ActionScenario Map(ActionScenarioDAO value)
        {
            return new ActionScenario
            {
                ordre = value.ordre,
                Action = ActionMapper.Map(value.Action),
                Scenario = ScenarioMapper.Map(value.Scenario)
            };
        }

        public static List<ActionScenario> Map(List<ActionScenarioDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}