using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA16_NVIGates
{
    class ICA16_NVIGates
    {
        static void Main(string[] args)
        {
            bool output;            

            Console.WriteLine("ICA 16 - NVI Gates\n");
            Console.WriteLine("{0,-7}{1,-7}{2,-7}{3,-7}{4,-7}", "A", "B", "C", "D", "output");
            Console.WriteLine("{0,-7}{0,-7}{0,-7}{0,-7}{1,-7}", "====", "=====");

            for (int a = 0; a < 2; ++a)
            {                   
                for (int b = 0; b < 2; ++b)
                {
                    for (int c = 0; c < 2; ++c)
                    {                        
                        for (int d = 0; d < 2; ++d)
                        {
                            output = RunCircuit(a==1, b==1, c==1, d==1);
                            Console.WriteLine("{0,-7}{1,-7}{2,-7}{3,-7}{4,-7}", a, b, c, d, output);
                        }
                    }
                }
            }            

            Console.ReadKey();
        }

        private static bool RunCircuit(bool A, bool B, bool C, bool D)
        {
            NAND_Gate NANDgate = new NAND_Gate(A, B);
            //Console.WriteLine("NAND Output: " + NANDgate.Output);
            AND_Gate ANDgate = new AND_Gate(NANDgate.Output, B);
            //Console.WriteLine("AND Output: " + ANDgate.Output);
            XOR_Gate XORgate = new XOR_Gate(C, D);
            //Console.WriteLine("XOR Output: " + XORgate.Output);
            NOR_Gate NORgate = new NOR_Gate(ANDgate.Output, C);
            //Console.WriteLine("NOR Output: " + NORgate.Output);
            OR_Gate ORgate = new OR_Gate(ANDgate.Output, NORgate.Output);
            //Console.WriteLine("OR Output: " + ORgate.Output);
            XNOR_Gate XNORgate = new XNOR_Gate(ORgate.Output, XORgate.Output);

            return XNORgate.Output;
        }
    }
}
