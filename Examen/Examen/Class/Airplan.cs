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
            //начальная высота чтобы не разбивался
            hight = 50;
            speed = 50;
            dispetchera = new List<Dispatcher>();
        }
        public void AddDisp(List<Dispatcher> disp)
        {
            Console.Clear();
            disp.AddRange(disp);
        }

        public void Flaing(int tempSpeed,int tempHight)
        {
            //if (dispetchera.Count<2)
            //{
            //    throw (new Error(ErrorMessage.TwoDispetcherNotFound));
            //}
            //коректировка высоты и скорости
            hight += tempHight;
            speed += tempSpeed;
            Console.WriteLine("Высота == {0} , Скорость == {1} ",Hight,Speed);

        }

    }
}
