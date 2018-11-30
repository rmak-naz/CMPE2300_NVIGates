using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA16_NVIGates
{
    class OR_Gate : Gate
    {
        public OR_Gate(bool InputA, bool InputB)
            :base(InputA, InputB)
        {
        }

        protected override bool GetOutput()
        {
            return (_A | _B) == true ? true : false;
        }
    }
}
