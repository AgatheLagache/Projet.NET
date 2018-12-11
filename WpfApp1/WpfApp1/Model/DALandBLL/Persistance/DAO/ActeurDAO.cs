namespace WpfApp1.Model.DALandBLL.Persistance.DAO
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Acteur")]
    public class ActeurDAO
    {
        public int id { get; set; }

        public string role { get; set; }
    }
}