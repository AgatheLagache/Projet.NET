namespace WpfApp1.Model
{
    public class History : IScenario
    {
        private int scenario;

        private History()
        {
            this.setScenario(this.chooseScenario());
            this.initializeScenario(this.scenario);
        }

        public int chooseScenario()
        {
            /* faire un random ou par variable entrée en paramètre */
            return 0;
        }

        public void initializeScenario(int numberScenario)
        {
            /* initialisation du scenario */
        }

        public int getScenario()
        {
            return 0;
        }

        public void setScenario(int numberScenario)
        {
            this.scenario = numberScenario;
        }
    }
}