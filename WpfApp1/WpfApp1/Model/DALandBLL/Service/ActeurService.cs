using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Persistance;
using WpfApp1.Model.DALandBLL.Business.Mapper;
using WpfApp1.Model.DALandBLL.Business;

namespace WpfApp1.Model.DALandBLL.Service
{
    public class ActeurService
    {
        Context context;

        public ActeurService()
        {
            context = new Context();
        }
        public void Add(Acteur acteur)
        {
            var entity = ActeurMapper.Map(acteur);
            context.Acteur.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = (from c in context.Acteur where c.id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Acteur.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Acteur acteur)
        {
            var entity = (from c in context.Acteur where c.id == acteur.id select c).FirstOrDefault();
            if (entity != null)
            {
                entity.role = acteur.role;
                context.SaveChanges();
            }
        }

        public List<Acteur> Get()
        {
            return (from c in context.Acteur select ActeurMapper.Map(c)).ToList();
        }

        public Acteur GetById(int id)
        {
            return (from c in context.Acteur where c.id == id select ActeurMapper.Map(c)).FirstOrDefault();
        }
    }
}