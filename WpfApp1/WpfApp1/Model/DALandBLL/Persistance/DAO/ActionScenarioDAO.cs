namespace WpfApp1.Model.DALandBLL.Persistance.DAO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ActionScenario")]
    public class ActionScenarioDAO
    {
        public int ordre { get; set; }
        public int actionId { get; set; }
        public int scenarioId { get; set; }
        [Key]
        [Column(Order = 0)]
        public virtual ActionDAO Action { get; set; }
        [Key]
        [Column(Order = 1)]
        public virtual ScenarioDAO Scenario { get; set; }
    }
}