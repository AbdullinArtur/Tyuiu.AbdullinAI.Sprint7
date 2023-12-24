namespace Tyuiu.AbdullinAI.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInformation_AAI = new System.Windows.Forms.GroupBox();
            this.labelInformation_AAI = new System.Windows.Forms.Label();
            this.groupBoxAboutProgramm_AAI = new System.Windows.Forms.GroupBox();
            this.labelAboutProgramm_AAI = new System.Windows.Forms.Label();
            this.buttonClose_AAI = new System.Windows.Forms.Button();
            this.pictureBoxAvtor_AAI = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInformation_AAI.SuspendLayout();
            this.groupBoxAboutProgramm_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvtor_AAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformation_AAI
            // 
            this.groupBoxInformation_AAI.Controls.Add(this.pictureBoxAvtor_AAI);
            this.groupBoxInformation_AAI.Controls.Add(this.labelInformation_AAI);
            this.groupBoxInformation_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInformation_AAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation_AAI.Name = "groupBoxInformation_AAI";
            this.groupBoxInformation_AAI.Size = new System.Drawing.Size(567, 225);
            this.groupBoxInformation_AAI.TabIndex = 0;
            this.groupBoxInformation_AAI.TabStop = false;
            this.groupBoxInformation_AAI.Text = "О разработчике";
            // 
            // labelInformation_AAI
            // 
            this.labelInformation_AAI.AutoSize = true;
            this.labelInformation_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation_AAI.Location = new System.Drawing.Point(160, 21);
            this.labelInformation_AAI.Name = "labelInformation_AAI";
            this.labelInformation_AAI.Size = new System.Drawing.Size(400, 112);
            this.labelInformation_AAI.TabIndex = 0;
            this.labelInformation_AAI.Text = resources.GetString("labelInformation_AAI.Text");
            // 
            // groupBoxAboutProgramm_AAI
            // 
            this.groupBoxAboutProgramm_AAI.Controls.Add(this.pictureBox1);
            this.groupBoxAboutProgramm_AAI.Controls.Add(this.labelAboutProgramm_AAI);
            this.groupBoxAboutProgramm_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAboutProgramm_AAI.Location = new System.Drawing.Point(12, 243);
            this.groupBoxAboutProgramm_AAI.Name = "groupBoxAboutProgramm_AAI";
            this.groupBoxAboutProgramm_AAI.Size = new System.Drawing.Size(567, 158);
            this.groupBoxAboutProgramm_AAI.TabIndex = 1;
            this.groupBoxAboutProgramm_AAI.TabStop = false;
            this.groupBoxAboutProgramm_AAI.Text = "О программе";
            // 
            // labelAboutProgramm_AAI
            // 
            this.labelAboutProgramm_AAI.AutoSize = true;
            this.labelAboutProgramm_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutProgramm_AAI.Location = new System.Drawing.Point(6, 18);
            this.labelAboutProgramm_AAI.Name = "labelAboutProgramm_AAI";
            this.labelAboutProgramm_AAI.Size = new System.Drawing.Size(504, 128);
            this.labelAboutProgramm_AAI.TabIndex = 0;
            this.labelAboutProgramm_AAI.Text = resources.GetString("labelAboutProgramm_AAI.Text");
            // 
            // buttonClose_AAI
            // 
            this.buttonClose_AAI.BackColor = System.Drawing.Color.LightPink;
            this.buttonClose_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_AAI.Location = new System.Drawing.Point(474, 407);
            this.buttonClose_AAI.Name = "buttonClose_AAI";
            this.buttonClose_AAI.Size = new System.Drawing.Size(98, 35);
            this.buttonClose_AAI.TabIndex = 2;
            this.buttonClose_AAI.Text = "Закрыть";
            this.buttonClose_AAI.UseVisualStyleBackColor = false;
            this.buttonClose_AAI.Click += new System.EventHandler(this.buttonClose_AAI_Click);
            // 
            // pictureBoxAvtor_AAI
            // 
            this.pictureBoxAvtor_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.photo;
            this.pictureBoxAvtor_AAI.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxAvtor_AAI.Name = "pictureBoxAvtor_AAI";
            this.pictureBoxAvtor_AAI.Size = new System.Drawing.Size(148, 198);
            this.pictureBoxAvtor_AAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvtor_AAI.TabIndex = 1;
            this.pictureBoxAvtor_AAI.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(126, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 449);
            this.Controls.Add(this.buttonClose_AAI);
            this.Controls.Add(this.groupBoxAboutProgramm_AAI);
            this.Controls.Add(this.groupBoxInformation_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            this.groupBoxInformation_AAI.ResumeLayout(false);
            this.groupBoxInformation_AAI.PerformLayout();
            this.groupBoxAboutProgramm_AAI.ResumeLayout(false);
            this.groupBoxAboutProgramm_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvtor_AAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation_AAI;
        private System.Windows.Forms.Label labelInformation_AAI;
        private System.Windows.Forms.PictureBox pictureBoxAvtor_AAI;
        private System.Windows.Forms.GroupBox groupBoxAboutProgramm_AAI;
        private System.Windows.Forms.Label labelAboutProgramm_AAI;
        private System.Windows.Forms.Button buttonClose_AAI;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}