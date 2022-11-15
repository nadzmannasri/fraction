using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    class fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
            { get { return _numerator; }
              set { _numerator = value;}
            }
        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }
        public Double Value()
        {
            return ((double) _numerator )/ _denominator;
        }
    }
}
