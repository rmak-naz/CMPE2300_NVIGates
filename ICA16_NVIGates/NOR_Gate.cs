using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA16_NVIGates
{
    class NOR_Gate : OR_Gate
    {
        public NOR_Gate(bool InputA, bool InputB)
            :base(InputA, InputB)
        {
        }

        protected override bool GetOutput()
        {
            return !base.GetOutput();
        }
    }
}
