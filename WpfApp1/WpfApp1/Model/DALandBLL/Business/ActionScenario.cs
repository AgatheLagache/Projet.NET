namespace WpfApp1.Model.DALandBLL.Business
{
    public class ActionScenario
    {
        public int ordre { get; set; }
        public virtual Action Action { get; set; }
        public virtual Scenario Scenario { get; set; }
    }
}