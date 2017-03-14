using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Class
{
    public class Dispatcher
    {
        //Диспетчер
        #region field
        public string firstName;
        Airplan air;
        int corectiovka;
        int score;

        #endregion

        #region ctor
        public Dispatcher(string _name,Airplan air)
        {
            this.firstName = _name;
            this.air = air;
            Random rand = new Random();
            corectiovka = rand.Next(-200, 200);
            
        }

        #endregion

        #region Method

        public void Info(int _speed,int _hight)
        {
            int hightcor = 7 * air.Speed - corectiovka;
            Console.WriteLine("{0},рекомендация === {1}",firstName,hightcor);
            int rez = air.Hight - hightcor;
            if (rez>=300 && rez<=600)
            {
                score += 25;
            }
            if (rez>=600&&rez<=1000)
            {
                score += 50;
            }
            if (air.Speed>1000)
            {
                score += 100;
                Console.WriteLine("Превысил скорость");
            }
            if (rez>1000)
            {
                throw (new Error(ErrorMessage.AirplanCrash));
            }
            if (score>1000)
            {
                throw (new Error(ErrorMessage.PilotLuzer));
            }
            if (air.Hight<=0 || air.Speed<=0)
            {
                throw (new Error(ErrorMessage.AirplanCrash));
            }

        }


        #endregion

       
    }
}
