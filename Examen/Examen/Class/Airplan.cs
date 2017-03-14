using Examen.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    //Самалет
    public class Airplan
    {
        int hight;
        int speed;
        private List<Dispatcher> dispetchera;
        #region Property
        public int Hight
        {
            get
            {
                return hight;
            }

            set
            {
                hight = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        #endregion
        public Airplan()
        {
            hight = 50;
            Speed = 50;
            dispetchera = new List<Dispatcher>();
        }
        public void AddDisp(List<Dispatcher> disp)
        {
            disp.AddRange(disp);
        }

        public void Flaing(int tempHight,int tempSpeed)
        {
            if (dispetchera.Count<2)
            {
                throw (new Error(ErrorMessage.TwoDispetcherNotFound));
            }

            hight += tempHight;
            Speed += tempSpeed;

        }

    }
}
