namespace WpfApp1.Model.DALandBLL.Persistance.DAO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ActionScenario")]
    public class ActionScenarioDAO
    {
        public int ordre { get; set; }

        [Key]
        [Column(Order = 0)]
        public int id_Action { get; set; }

        [Key]
        [Column(Order = 1)]
        public int id_Scenario { get; set; }

        public virtual ActionDAO Action { get; set; }

        public virtual ScenarioDAO Scenario { get; set; }
    }
}