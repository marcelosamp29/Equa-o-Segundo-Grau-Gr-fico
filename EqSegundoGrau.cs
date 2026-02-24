using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGrafico_Bhaskara
{
    public class EqSegundoGrau
    {
        private String a;
        private String b;
        private String c;

        public void setA(String _a) { a = _a; }
        public void setB(String _b) { b = _b; }
        public void setC(String _c) { c = _c; }

        public String getA() { return a; }
        public String getB() { return b; }
        public String getC() { return c; }
        public String calcDelta()
        {
            float valorA = float.Parse(a);
            float valorB = float.Parse(b);
            float valorC = float.Parse(c);

            return (Math.Pow(valorB, 2) - 4 * valorA * valorC).ToString();
        }

        public String calcX1(String delta)
        {
            float valorA = float.Parse(a);
            float valorB = float.Parse(b);
            //float valorC = float.Parse(c);
            float valorDelta = float.Parse(delta);

            return ((-valorB + Math.Sqrt(valorDelta)) / 2 * valorA).ToString("F3");
        }

        public String calcX2(String delta)
        {
            float valorA = float.Parse(a);
            float valorB = float.Parse(b);
            //float valorC = float.Parse(c);
            float valorDelta = float.Parse(delta);

            return ((-valorB - Math.Sqrt(valorDelta)) / 2 * valorA).ToString("F3");
        }
    }
}
