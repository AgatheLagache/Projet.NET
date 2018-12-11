using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Business;
using WpfApp1.Model.DALandBLL.Business.Mapper;
using WpfApp1.Model.DALandBLL.Persistance;

namespace WpfApp1.Model.DALandBLL.Service
{
    public class ActionScenarioService
    {
        private Context context;

        public ActionScenarioService()
        {
            context = new Context();
        }

        public void Add(ActionScenario actionScenario)
        {
            var entity = ActionScenarioMapper.Map(actionScenario);
            context.ActionScenario.Add(entity);
            context.SaveChanges();
        }

        //public void Delete(int id)
        //{
        //    var entity = (from c in context.ActionScenario where c.id == id select c).FirstOrDefault();
        //    if (entity != null)
        //    {
        //        context.Acteur.Remove(entity);
        //        context.SaveChanges();
        //    }
        //} To implement in case of evolution

        //public void Update(ActionScenario actionScenario)
        //{
        //    var entity = (from c in context.ActionScenario where c.id == actionScenario.id select c).FirstOrDefault();
        //    if (entity != null)
        //    {
        //        entity.ordre = actionScenario.ordre;
        //        context.SaveChanges();
        //    }
        //}

        public List<ActionScenario> Get()
        {
            return (from c in context.ActionScenario select ActionScenarioMapper.Map(c)).ToList();
        }

        public List<ActionScenario> GetByActionId(int id_action)
        {
            return (from c in context.ActionScenario where c.id_Action == id_action select ActionScenarioMapper.Map(c)).ToList();
        }

        public List<ActionScenario> GetByScenarioId(int id_scenario)
        {
            return (from c in context.ActionScenario where c.id_Scenario == id_scenario select ActionScenarioMapper.Map(c)).ToList();
        }
    }
}