using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjGrafico_Bhaskara
{
    public partial class EqSegundoGrauIHM : Form
    {
        #region Inicialização dos Componentes
        public EqSegundoGrauIHM()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        #endregion       

        #region Método Validação
        public void ValidarCampos()
        {
            if (txtA.Text != "" && txtB.Text != "" && txtC.Text != "")
            {
                btnCalcular.Enabled = true;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        #endregion

        #region Gráfico X1 e X2
        public void GerarGrafico(EqSegundoGrau eq)
        {
            chartBhaskara.Series["X1"].Points.Clear();
            chartBhaskara.Series["X2"].Points.Clear();
            chartBhaskara.Series["Parábola"].Points.Clear();
            chartBhaskara.Titles.Clear();

            float valorA = float.Parse(eq.getA());
            float valorB = float.Parse(eq.getB());
            float valorC = float.Parse(eq.getC());
            float valorDelta = float.Parse(eq.calcDelta());

            for (float x = -20; x <= 20; x += 0.1f)
            {
                float y = (valorA * (float)Math.Pow(x, 2)) + (valorB * x) + valorC;
                chartBhaskara.Series["Parábola"].Points.AddXY(x, y);
            }            

            if (valorDelta >= 0)
            {
                float valorX1 = float.Parse(eq.calcX1(valorDelta.ToString()));
                float valorX2 = float.Parse(eq.calcX2(valorDelta.ToString()));

                chartBhaskara.Series["X1"].Points.AddXY(valorX1, 0);
                chartBhaskara.Series["X2"].Points.AddXY(valorX2, 0);

                chartBhaskara.ChartAreas[0].AxisX.LabelStyle.Format = "0.##";
                chartBhaskara.ChartAreas[0].AxisY.LabelStyle.Format = "0.##";

                chartBhaskara.Series["X1"].LegendText = $"X1 = {valorX1}";
                chartBhaskara.Series["X2"].LegendText = $"X2 = {valorX2}";
            }
        }
        #endregion

        #region Botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EqSegundoGrau eqSegundoGrau = new EqSegundoGrau();
            eqSegundoGrau.setA(txtA.Text);
            eqSegundoGrau.setB(txtB.Text);
            eqSegundoGrau.setC(txtC.Text);

            EqSegundoGrauBLL.validaDados(eqSegundoGrau);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem());
            }
            else
            {
                float Delta = float.Parse(eqSegundoGrau.calcDelta());

                if (Delta < 0)
                {
                    MessageBox.Show("Não é possível calcular as raízes!");
                    return;
                }
                else
                {
                    GerarGrafico(eqSegundoGrau);                    
                }
            }
        }
        #endregion

        #region Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            chartBhaskara.Series["X1"].Points.Clear();
            chartBhaskara.Series["X1"].LegendText = "X1";
            chartBhaskara.Series["X2"].Points.Clear();
            chartBhaskara.Series["X2"].LegendText = "X2";
            chartBhaskara.Series["Parábola"].Points.Clear();
        }
        #endregion

        #region Fechar Formulário
        private void EqSegundoGrauIHM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja encerrar o programa ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
