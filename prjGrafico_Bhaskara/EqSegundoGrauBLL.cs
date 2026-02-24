using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGrafico_Bhaskara
{
    public class EqSegundoGrauBLL
    {
        public static void validaDados(EqSegundoGrau eqSegundoGrau)
        {
            Erro.setErro(false);

            // VALOR A

            if (eqSegundoGrau.getA().Length == 0)
            {
                Erro.setMensagem("Valor {A} não pode estar vazio!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(eqSegundoGrau.getA());
                }
                catch
                {
                    Erro.setMensagem("Valor {A} precisa ser numérico!");
                    return;
                }
            }

            // VALOR B

            if (eqSegundoGrau.getB().Length == 0)
            {
                Erro.setMensagem("Valor {B} não pode estar vazio!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(eqSegundoGrau.getB());
                }
                catch
                {
                    Erro.setMensagem("Valor {B} precisa ser numérico!");
                    return;
                }
            }

            // VALOR C

            if (eqSegundoGrau.getC().Length == 0)
            {
                Erro.setMensagem("Valor {C} não pode estar vazio!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(eqSegundoGrau.getC());
                }
                catch
                {
                    Erro.setMensagem("Valor {C} precisa ser numérico!");
                    return;
                }
            }
        }
    }
}
