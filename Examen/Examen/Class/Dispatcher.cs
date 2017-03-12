using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Class
{
    class Dispatcher
    {
        string firstName;              
        int adjustment;

        
        public Dispatcher(string _name,int _adjustment)
        {
            FirstName = _name;
            Adjustment = _adjustment;
        }
        #region field
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public int Adjustment
        {
            get { return adjustment; }
            set { adjustment = value; }
        }
        #endregion
    }
}
