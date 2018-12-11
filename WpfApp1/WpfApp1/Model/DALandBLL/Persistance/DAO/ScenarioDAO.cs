namespace WpfApp1.Model.DALandBLL.Persistance.DAO
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Scenario")]
    public class ScenarioDAO
    {
        public int id { get; set; }
        public string titre { get; set; }
    }
}