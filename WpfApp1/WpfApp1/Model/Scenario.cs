using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WpfApp1.Model
{
    public class Scenario : IScenario
    {
        private int scenario;

        Scenario()
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
