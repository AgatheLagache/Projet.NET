using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Persistance.DAO;

namespace WpfApp1.Model.DALandBLL.Business.Mapper
{
    public class ScenarioMapper
    {
        public static ScenarioDAO Map(Scenario value)
        {
            return new ScenarioDAO
            {
                id = value.id,
                titre = value.titre
            };
        }

        public static Scenario Map(ScenarioDAO value)
        {
            return new Scenario
            {
                id = value.id,
                titre = value.titre
            };
        }

        public static List<Scenario> Map(List<ScenarioDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}