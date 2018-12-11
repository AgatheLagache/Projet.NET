using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Persistance;
using WpfApp1.Model.DALandBLL.Business.Mapper;
using WpfApp1.Model.DALandBLL.Business;

namespace WpfApp1.Model.DALandBLL.Service
{
    public class ScenarioService
    {
        Context context;

        public ScenarioService()
        {
            context = new Context();
        }
        public void Add(Scenario scenario)
        {
            var entity = ScenarioMapper.Map(scenario);
            context.Scenario.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = (from c in context.Scenario where c.id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Scenario.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Scenario scenario)
        {
            var entity = (from c in context.Scenario where c.id == scenario.id select c).FirstOrDefault();
            if (entity != null)
            {
                entity.titre = scenario.titre;
                context.SaveChanges();
            }
        }

        public List<Scenario> Get()
        {
            return (from c in context.Scenario select ScenarioMapper.Map(c)).ToList();
        }

        public Scenario GetById(int id)
        {
            return (from c in context.Scenario where c.id == id select ScenarioMapper.Map(c)).FirstOrDefault();
        }
    }
}