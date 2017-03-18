using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Class;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Pilot pilot = new Pilot();
                pilot.Poleteli();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                
            }
            
            
            
            Console.ReadKey();
        }
    }
}
