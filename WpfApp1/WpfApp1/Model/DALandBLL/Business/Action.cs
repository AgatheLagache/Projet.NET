namespace WpfApp1.Model.DALandBLL.Business
{
    public class Action
    {
        public int id { get; set; }

        public string description { get; set; }

        public virtual Acteur Acteur { get; set; }
    }
}
