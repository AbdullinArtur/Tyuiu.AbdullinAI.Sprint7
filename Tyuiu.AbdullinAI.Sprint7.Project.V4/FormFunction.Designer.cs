namespace Tyuiu.AbdullinAI.Sprint7.Project.V4
{
    partial class FormFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPrice_AAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCloseTut_AAI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_AAI)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPrice_AAI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrice_AAI.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.IndianRed;
            this.chartPrice_AAI.Legends.Add(legend1);
            this.chartPrice_AAI.Location = new System.Drawing.Point(3, 12);
            this.chartPrice_AAI.Name = "chartPrice_AAI";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Цена";
            this.chartPrice_AAI.Series.Add(series1);
            this.chartPrice_AAI.Size = new System.Drawing.Size(785, 354);
            this.chartPrice_AAI.TabIndex = 0;
            this.chartPrice_AAI.Text = "chart1";
            // 
            // buttonCloseTut_AAI
            // 
            this.buttonCloseTut_AAI.BackColor = System.Drawing.Color.LightPink;
            this.buttonCloseTut_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseTut_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseTut_AAI.Location = new System.Drawing.Point(690, 386);
            this.buttonCloseTut_AAI.Name = "buttonCloseTut_AAI";
            this.buttonCloseTut_AAI.Size = new System.Drawing.Size(98, 35);
            this.buttonCloseTut_AAI.TabIndex = 4;
            this.buttonCloseTut_AAI.Text = "Закрыть";
            this.buttonCloseTut_AAI.UseVisualStyleBackColor = false;
            this.buttonCloseTut_AAI.Click += new System.EventHandler(this.buttonCloseTut_AAI_Click);
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.buttonCloseTut_AAI);
            this.Controls.Add(this.chartPrice_AAI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 464);
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFunction";
            this.Load += new System.EventHandler(this.FormFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_AAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice_AAI;
        private System.Windows.Forms.Button buttonCloseTut_AAI;
    }
}