using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.DALandBLL.Persistance.DAO;

namespace WpfApp1.Model.DALandBLL.Business.Mapper
{
    public class ActeurMapper
    {
        public static ActeurDAO Map(Acteur value)
        {
            return new ActeurDAO
            {
                id = value.id,
                role = value.role
            };
        }

        public static Acteur Map(ActeurDAO value)
        {
            return new Acteur
            {
                id = value.id,
                role = value.role
            };
        }

        public static List<Acteur> Map(List<ActeurDAO> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}