namespace WpfApp1.Model.DALandBLL.Persistance.DAO
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Action")]
    public class ActionDAO
    {
        public int id { get; set; }

        public string description { get; set; }

        public int id_Acteur { get; set; }

        [ForeignKey("id_Acteur")]
        public virtual ActeurDAO Acteur { get; set; }
    }
}