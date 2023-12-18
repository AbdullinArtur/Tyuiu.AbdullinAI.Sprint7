namespace Tyuiu.AbdullinAI.Sprint7.Project.V4
{
    partial class FormMain
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
            this.panelTop_AAI = new System.Windows.Forms.Panel();
            this.buttonSaveFile_AAI = new System.Windows.Forms.Button();
            this.buttonHelp_AAI = new System.Windows.Forms.Button();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_AAI = new System.Windows.Forms.Button();
            this.openFileDialog_AAI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_AAI = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAI
            // 
            this.panelTop_AAI.Controls.Add(this.buttonSaveFile_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonHelp_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonDone_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonOpenFile_AAI);
            this.panelTop_AAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAI.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAI.Name = "panelTop_AAI";
            this.panelTop_AAI.Size = new System.Drawing.Size(860, 87);
            this.panelTop_AAI.TabIndex = 0;
            // 
            // buttonSaveFile_AAI
            // 
            this.buttonSaveFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.page_save;
            this.buttonSaveFile_AAI.Location = new System.Drawing.Point(396, 13);
            this.buttonSaveFile_AAI.Name = "buttonSaveFile_AAI";
            this.buttonSaveFile_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonSaveFile_AAI.TabIndex = 3;
            this.buttonSaveFile_AAI.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_AAI
            // 
            this.buttonHelp_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.help;
            this.buttonHelp_AAI.Location = new System.Drawing.Point(773, 13);
            this.buttonHelp_AAI.Name = "buttonHelp_AAI";
            this.buttonHelp_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp_AAI.TabIndex = 2;
            this.buttonHelp_AAI.UseVisualStyleBackColor = true;
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.page_go;
            this.buttonDone_AAI.Location = new System.Drawing.Point(315, 13);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonDone_AAI.TabIndex = 1;
            this.buttonDone_AAI.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_AAI
            // 
            this.buttonOpenFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.folder_page;
            this.buttonOpenFile_AAI.Location = new System.Drawing.Point(12, 13);
            this.buttonOpenFile_AAI.Name = "buttonOpenFile_AAI";
            this.buttonOpenFile_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonOpenFile_AAI.TabIndex = 0;
            this.buttonOpenFile_AAI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AAI.Click += new System.EventHandler(this.buttonOpenFile_AAI_Click);
            // 
            // openFileDialog_AAI
            // 
            this.openFileDialog_AAI.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 671);
            this.Controls.Add(this.panelTop_AAI);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop_AAI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAI;
        private System.Windows.Forms.Button buttonHelp_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonOpenFile_AAI;
        private System.Windows.Forms.Button buttonSaveFile_AAI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_AAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_AAI;
    }
}

