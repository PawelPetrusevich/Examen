using System;
using System.Collections.Generic;
using Examen.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Class
{
    class Pilot
    {
        int score;
        List<Dispatcher> dispetchera;
        Airplan air;

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public delegate void Palet(int h,int s);
        public event Palet PaletEvent;

        public Pilot()
        {
            dispetchera = new List<Dispatcher>();
            air = new Airplan();
            Score = 0;
        }

        public void AddDispetcher(List<Dispatcher> dispetchera)
        {
            string nameDispetcher;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите имя {0}=го диспетчера",dispetchera.Count);
                nameDispetcher = Console.ReadLine();
                if (nameDispetcher.Length > 0)
                {
                    //при создании добавляем подписку на событие
                    Dispatcher tempDisp = new Dispatcher(nameDispetcher, air);
                    dispetchera.Add(tempDisp);
                    PaletEvent += tempDisp.Info;
                }

            }
            while (nameDispetcher.Length > 0);
            air.AddDisp(dispetchera);
        }

        public void Poleteli()
        {
            ConsoleKeyInfo cmd;
            Console.TreatControlCAsInput = true; //реагирование на shift
            PaletEvent += air.Flaing;
            
            
            do
            {
                //проблемы с выводом каректировки
                Console.Clear();
                Console.WriteLine("Управление самолетом(ESC -выход)");
                Console.WriteLine("(Right: + 50км/ч, Left: -50км/ч, Shift- Right : +150км/ч, Shift- Left: -150км/ч)");
                Console.WriteLine("(Up: +250м, Down: -250м, Shift- Up: +500м, Shift- Down: -500м)");
                Console.WriteLine("1 -добавить диспетчера");
                Console.WriteLine();                
                Console.WriteLine("{0},  {1}", air.Hight, air.Speed);


                cmd = Console.ReadKey();
                if (cmd.Key == ConsoleKey.D1)
                {
                    AddDispetcher(dispetchera);
                }
                //упровление самолетом
                if (dispetchera.Count > 2)
                {

                    if ((cmd.Modifiers & ConsoleModifiers.Shift) != 0)
                    {
                        switch (cmd.Key)
                        {
                            case ConsoleKey.RightArrow: PaletEvent(150, 0); break;
                            case ConsoleKey.LeftArrow: PaletEvent(-150, 0); break;
                            case ConsoleKey.UpArrow: PaletEvent(0, 500); break;
                            case ConsoleKey.DownArrow: PaletEvent(0, -500); break;
                        }
                    }
                    if ((cmd.Modifiers & ConsoleModifiers.Shift) == 0)
                    {
                        switch (cmd.Key)
                        {
                            case ConsoleKey.RightArrow: PaletEvent(50, 0); break;
                            case ConsoleKey.LeftArrow: PaletEvent(-50, 0); break;
                            case ConsoleKey.UpArrow: PaletEvent(0, 250); break;
                            case ConsoleKey.DownArrow: PaletEvent(0, -250); break;
                        }

                    }
                }
                else
                {

                    Console.WriteLine("Нехватает диспетчеров");

                }
                //foreach (var item in dispetchera)
                //{
                //    Console.WriteLine(item.rez);
                //}
                //Console.ReadKey();

            }
            while (cmd.Key!=ConsoleKey.Escape);
        }

    }
}
