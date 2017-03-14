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
        public delegate void Palet(int h,int s);
        public event Palet PaletEvent;

        public Pilot()
        {
            dispetchera = new List<Dispatcher>();
            air = new Airplan();
            score = 0;
        }

        public void AddDispetcher()
        {
            string nameDispetcher;
            do
            {
                Console.Clear();
                Console.WriteLine("Ввудите имя диспетчера");
                nameDispetcher = Console.ReadLine();
                if (nameDispetcher.Length > 0)
                {
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
            Console.TreatControlCAsInput = true;
            Console.WriteLine("Управление самолетом стандартное. Esc == выход.1 == дабавить диспетчера");
            ConsoleKeyInfo cmd = Console.ReadKey();
            do
            {


                if (cmd.Key == ConsoleKey.D1)
                {
                    air.AddDisp(dispetchera);
                }
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
                    Console.WriteLine("Не хватает пилотов");

                }
            }
            while (cmd.Key!=ConsoleKey.Escape);
        }

    }
}
