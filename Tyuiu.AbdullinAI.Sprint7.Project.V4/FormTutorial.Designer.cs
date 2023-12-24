namespace Tyuiu.AbdullinAI.Sprint7.Project.V4
{
    partial class FormTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorial));
            this.groupBoxInformation_AAI = new System.Windows.Forms.GroupBox();
            this.labelInformation_AAI = new System.Windows.Forms.Label();
            this.buttonCloseTut_AAI = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInformation_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformation_AAI
            // 
            this.groupBoxInformation_AAI.Controls.Add(this.pictureBox2);
            this.groupBoxInformation_AAI.Controls.Add(this.pictureBox1);
            this.groupBoxInformation_AAI.Controls.Add(this.labelInformation_AAI);
            this.groupBoxInformation_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInformation_AAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation_AAI.Name = "groupBoxInformation_AAI";
            this.groupBoxInformation_AAI.Size = new System.Drawing.Size(765, 312);
            this.groupBoxInformation_AAI.TabIndex = 1;
            this.groupBoxInformation_AAI.TabStop = false;
            this.groupBoxInformation_AAI.Text = "Справка о работе с приложением";
            // 
            // labelInformation_AAI
            // 
            this.labelInformation_AAI.AutoSize = true;
            this.labelInformation_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation_AAI.Location = new System.Drawing.Point(6, 32);
            this.labelInformation_AAI.Name = "labelInformation_AAI";
            this.labelInformation_AAI.Size = new System.Drawing.Size(742, 272);
            this.labelInformation_AAI.TabIndex = 0;
            this.labelInformation_AAI.Text = resources.GetString("labelInformation_AAI.Text");
            // 
            // buttonCloseTut_AAI
            // 
            this.buttonCloseTut_AAI.BackColor = System.Drawing.Color.LightPink;
            this.buttonCloseTut_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseTut_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseTut_AAI.Location = new System.Drawing.Point(671, 330);
            this.buttonCloseTut_AAI.Name = "buttonCloseTut_AAI";
            this.buttonCloseTut_AAI.Size = new System.Drawing.Size(98, 35);
            this.buttonCloseTut_AAI.TabIndex = 3;
            this.buttonCloseTut_AAI.Text = "Закрыть";
            this.buttonCloseTut_AAI.UseVisualStyleBackColor = false;
            this.buttonCloseTut_AAI.Click += new System.EventHandler(this.buttonCloseTut_AAI_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(150, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(463, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 377);
            this.Controls.Add(this.buttonCloseTut_AAI);
            this.Controls.Add(this.groupBoxInformation_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тьюториал";
            this.groupBoxInformation_AAI.ResumeLayout(false);
            this.groupBoxInformation_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation_AAI;
        private System.Windows.Forms.Label labelInformation_AAI;
        private System.Windows.Forms.Button buttonCloseTut_AAI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}