using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8._2
{
    public class Boiler
    {
        public int k;

        public Boiler()
        {
            k = 0;
        }

        public event EventHandler<BoilerArgs> onAlarm;

        public void ProcessAlarm()
        {
            this.onAlarm(this, new BoilerArgs(k));
        }

        public bool AlarmIsNull
        {
            get { return (this.onAlarm == null); }
        }
       
    }

    public class BoilerArgs :EventArgs
    {
        private int pressure;
        public BoilerArgs(int n)
        {
            pressure = n;
        }

        public int Press
        {
            get { return pressure; }
        }
    }

}
