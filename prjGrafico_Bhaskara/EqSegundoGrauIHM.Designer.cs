namespace prjGrafico_Bhaskara
{
    partial class EqSegundoGrauIHM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EqSegundoGrauIHM));
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.chartBhaskara = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBhaskara)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(40, 21);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(471, 18);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(181, 21);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(319, 20);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 2;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "X² +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "X +";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.Location = new System.Drawing.Point(430, 25);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(27, 16);
            this.lblDelta.TabIndex = 13;
            this.lblDelta.Text = "= 0";
            // 
            // chartBhaskara
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBhaskara.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBhaskara.Legends.Add(legend1);
            this.chartBhaskara.Location = new System.Drawing.Point(40, 88);
            this.chartBhaskara.Name = "chartBhaskara";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Parábola";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "X1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "X2";
            this.chartBhaskara.Series.Add(series1);
            this.chartBhaskara.Series.Add(series2);
            this.chartBhaskara.Series.Add(series3);
            this.chartBhaskara.Size = new System.Drawing.Size(506, 253);
            this.chartBhaskara.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(471, 47);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // EqSegundoGrauIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 370);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.chartBhaskara);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EqSegundoGrauIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equação do 2º Grau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EqSegundoGrauIHM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartBhaskara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBhaskara;
        private System.Windows.Forms.Button btnLimpar;
    }
}

