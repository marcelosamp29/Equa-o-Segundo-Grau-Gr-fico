using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGrafico_Bhaskara
{
    public static class Erro
    {
        public static bool erro;
        public static String mensagem;

        public static void setErro(bool _erro) { erro = _erro; }
        public static void setMensagem(String _mensagem) { erro = true; mensagem = _mensagem; }

        public static String getMensagem() { return mensagem; }
        public static bool getErro() { return erro; }
    }
}
