using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA16_NVIGates
{
    public abstract class Gate
    {
        // input states
        protected bool _A;
        protected bool _B;
        public Gate(bool InputA, bool InputB)
        {
            _A = InputA;
            _B = InputB;
        }
        public bool Output
        {
            get
            {
                return GetOutput();
            }
        }
        // do derived specific implementation
        protected abstract bool GetOutput();
    }
}
