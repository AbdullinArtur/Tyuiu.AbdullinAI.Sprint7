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
            this.components = new System.ComponentModel.Container();
            this.panelTop_AAI = new System.Windows.Forms.Panel();
            this.buttonBookMax_AAI = new System.Windows.Forms.Button();
            this.openFileDialog_AAI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_AAI = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewData_AAI = new System.Windows.Forms.DataGridView();
            this.textBoxSumm_AAI = new System.Windows.Forms.TextBox();
            this.groupBoxStats_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxCount_AAI = new System.Windows.Forms.TextBox();
            this.textBoxMiddle_AAI = new System.Windows.Forms.TextBox();
            this.textBoxMin_AAI = new System.Windows.Forms.TextBox();
            this.textBoxMax_AAI = new System.Windows.Forms.TextBox();
            this.buttonCount_AAI = new System.Windows.Forms.Button();
            this.buttonMiddle_AAI = new System.Windows.Forms.Button();
            this.buttonMin_AAI = new System.Windows.Forms.Button();
            this.buttonMax_AAI = new System.Windows.Forms.Button();
            this.toolTip_AAI = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber_AAI = new System.Windows.Forms.TextBox();
            this.buttonSearch_AAI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFunction_AAI = new System.Windows.Forms.Button();
            this.buttonTutorial_AAI = new System.Windows.Forms.Button();
            this.buttonSaveFile_AAI = new System.Windows.Forms.Button();
            this.buttonHelp_AAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_AAI = new System.Windows.Forms.Button();
            this.panelTop_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_AAI)).BeginInit();
            this.groupBoxStats_AAI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAI
            // 
            this.panelTop_AAI.Controls.Add(this.buttonTutorial_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonSaveFile_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonHelp_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonOpenFile_AAI);
            this.panelTop_AAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAI.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAI.Name = "panelTop_AAI";
            this.panelTop_AAI.Size = new System.Drawing.Size(1109, 92);
            this.panelTop_AAI.TabIndex = 0;
            // 
            // buttonBookMax_AAI
            // 
            this.buttonBookMax_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonBookMax_AAI.Enabled = false;
            this.buttonBookMax_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookMax_AAI.Location = new System.Drawing.Point(6, 49);
            this.buttonBookMax_AAI.Name = "buttonBookMax_AAI";
            this.buttonBookMax_AAI.Size = new System.Drawing.Size(98, 37);
            this.buttonBookMax_AAI.TabIndex = 1;
            this.buttonBookMax_AAI.Text = "Сумма книг\r\n\r\n";
            this.toolTip_AAI.SetToolTip(this.buttonBookMax_AAI, "Считает общую стоимость \r\nвсех книг в базе данных");
            this.buttonBookMax_AAI.UseVisualStyleBackColor = false;
            this.buttonBookMax_AAI.Click += new System.EventHandler(this.buttonAddBook_AAI_Click);
            // 
            // openFileDialog_AAI
            // 
            this.openFileDialog_AAI.FileName = "openFileDialog1";
            // 
            // dataGridViewData_AAI
            // 
            this.dataGridViewData_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_AAI.ColumnHeadersVisible = false;
            this.dataGridViewData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_AAI.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData_AAI.Name = "dataGridViewData_AAI";
            this.dataGridViewData_AAI.RowHeadersVisible = false;
            this.dataGridViewData_AAI.Size = new System.Drawing.Size(1109, 391);
            this.dataGridViewData_AAI.TabIndex = 1;
            // 
            // textBoxSumm_AAI
            // 
            this.textBoxSumm_AAI.Location = new System.Drawing.Point(7, 92);
            this.textBoxSumm_AAI.Name = "textBoxSumm_AAI";
            this.textBoxSumm_AAI.ReadOnly = true;
            this.textBoxSumm_AAI.Size = new System.Drawing.Size(97, 20);
            this.textBoxSumm_AAI.TabIndex = 2;
            // 
            // groupBoxStats_AAI
            // 
            this.groupBoxStats_AAI.Controls.Add(this.buttonFunction_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.textBoxCount_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.textBoxMiddle_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.textBoxMin_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.textBoxMax_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.buttonCount_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.buttonMiddle_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.buttonMin_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.buttonMax_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.textBoxSumm_AAI);
            this.groupBoxStats_AAI.Controls.Add(this.buttonBookMax_AAI);
            this.groupBoxStats_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_AAI.Location = new System.Drawing.Point(12, 15);
            this.groupBoxStats_AAI.Name = "groupBoxStats_AAI";
            this.groupBoxStats_AAI.Size = new System.Drawing.Size(640, 149);
            this.groupBoxStats_AAI.TabIndex = 4;
            this.groupBoxStats_AAI.TabStop = false;
            this.groupBoxStats_AAI.Text = "Статистика";
            // 
            // textBoxCount_AAI
            // 
            this.textBoxCount_AAI.Location = new System.Drawing.Point(421, 92);
            this.textBoxCount_AAI.Name = "textBoxCount_AAI";
            this.textBoxCount_AAI.ReadOnly = true;
            this.textBoxCount_AAI.Size = new System.Drawing.Size(98, 20);
            this.textBoxCount_AAI.TabIndex = 10;
            // 
            // textBoxMiddle_AAI
            // 
            this.textBoxMiddle_AAI.Location = new System.Drawing.Point(318, 92);
            this.textBoxMiddle_AAI.Name = "textBoxMiddle_AAI";
            this.textBoxMiddle_AAI.ReadOnly = true;
            this.textBoxMiddle_AAI.Size = new System.Drawing.Size(97, 20);
            this.textBoxMiddle_AAI.TabIndex = 9;
            // 
            // textBoxMin_AAI
            // 
            this.textBoxMin_AAI.Location = new System.Drawing.Point(214, 92);
            this.textBoxMin_AAI.Name = "textBoxMin_AAI";
            this.textBoxMin_AAI.ReadOnly = true;
            this.textBoxMin_AAI.Size = new System.Drawing.Size(98, 20);
            this.textBoxMin_AAI.TabIndex = 8;
            // 
            // textBoxMax_AAI
            // 
            this.textBoxMax_AAI.Location = new System.Drawing.Point(110, 92);
            this.textBoxMax_AAI.Name = "textBoxMax_AAI";
            this.textBoxMax_AAI.ReadOnly = true;
            this.textBoxMax_AAI.Size = new System.Drawing.Size(98, 20);
            this.textBoxMax_AAI.TabIndex = 7;
            // 
            // buttonCount_AAI
            // 
            this.buttonCount_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonCount_AAI.Enabled = false;
            this.buttonCount_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount_AAI.Location = new System.Drawing.Point(421, 49);
            this.buttonCount_AAI.Name = "buttonCount_AAI";
            this.buttonCount_AAI.Size = new System.Drawing.Size(98, 37);
            this.buttonCount_AAI.TabIndex = 6;
            this.buttonCount_AAI.Text = "Кол-во читателей";
            this.toolTip_AAI.SetToolTip(this.buttonCount_AAI, "Выводит количество людей, \r\nкоторые взяли книгу");
            this.buttonCount_AAI.UseVisualStyleBackColor = false;
            this.buttonCount_AAI.Click += new System.EventHandler(this.buttonCount_AAI_Click);
            // 
            // buttonMiddle_AAI
            // 
            this.buttonMiddle_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMiddle_AAI.Enabled = false;
            this.buttonMiddle_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiddle_AAI.Location = new System.Drawing.Point(318, 49);
            this.buttonMiddle_AAI.Name = "buttonMiddle_AAI";
            this.buttonMiddle_AAI.Size = new System.Drawing.Size(98, 37);
            this.buttonMiddle_AAI.TabIndex = 5;
            this.buttonMiddle_AAI.Text = "Срденяя стоимость";
            this.toolTip_AAI.SetToolTip(this.buttonMiddle_AAI, "Выводит среднюю стоимость книги\r\n");
            this.buttonMiddle_AAI.UseVisualStyleBackColor = false;
            this.buttonMiddle_AAI.Click += new System.EventHandler(this.buttonMiddle_AAI_Click);
            // 
            // buttonMin_AAI
            // 
            this.buttonMin_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMin_AAI.Enabled = false;
            this.buttonMin_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin_AAI.Location = new System.Drawing.Point(214, 49);
            this.buttonMin_AAI.Name = "buttonMin_AAI";
            this.buttonMin_AAI.Size = new System.Drawing.Size(98, 37);
            this.buttonMin_AAI.TabIndex = 4;
            this.buttonMin_AAI.Text = "Мин. стоимость";
            this.toolTip_AAI.SetToolTip(this.buttonMin_AAI, "Выводит стоимость самой дешевой книги");
            this.buttonMin_AAI.UseVisualStyleBackColor = false;
            this.buttonMin_AAI.Click += new System.EventHandler(this.buttonMin_AAI_Click);
            // 
            // buttonMax_AAI
            // 
            this.buttonMax_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMax_AAI.Enabled = false;
            this.buttonMax_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax_AAI.Location = new System.Drawing.Point(110, 49);
            this.buttonMax_AAI.Name = "buttonMax_AAI";
            this.buttonMax_AAI.Size = new System.Drawing.Size(98, 37);
            this.buttonMax_AAI.TabIndex = 3;
            this.buttonMax_AAI.Text = "Макс. стоимость";
            this.toolTip_AAI.SetToolTip(this.buttonMax_AAI, "Выводит стоимость самой дорогой книги");
            this.buttonMax_AAI.UseVisualStyleBackColor = false;
            this.buttonMax_AAI.Click += new System.EventHandler(this.buttonMax_AAI_Click);
            // 
            // toolTip_AAI
            // 
            this.toolTip_AAI.IsBalloon = true;
            this.toolTip_AAI.Tag = "";
            this.toolTip_AAI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_AAI.ToolTipTitle = "Подсказка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNumber_AAI);
            this.groupBox1.Controls.Add(this.buttonSearch_AAI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(658, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по базе данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер читательского билета:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // textBoxNumber_AAI
            // 
            this.textBoxNumber_AAI.Location = new System.Drawing.Point(9, 51);
            this.textBoxNumber_AAI.Name = "textBoxNumber_AAI";
            this.textBoxNumber_AAI.Size = new System.Drawing.Size(72, 20);
            this.textBoxNumber_AAI.TabIndex = 1;
            // 
            // buttonSearch_AAI
            // 
            this.buttonSearch_AAI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSearch_AAI.Enabled = false;
            this.buttonSearch_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_AAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_AAI.Location = new System.Drawing.Point(259, 30);
            this.buttonSearch_AAI.Name = "buttonSearch_AAI";
            this.buttonSearch_AAI.Size = new System.Drawing.Size(94, 36);
            this.buttonSearch_AAI.TabIndex = 0;
            this.buttonSearch_AAI.Text = "Найти";
            this.buttonSearch_AAI.UseVisualStyleBackColor = false;
            this.buttonSearch_AAI.Click += new System.EventHandler(this.buttonSearch_AAI_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxStats_AAI);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 188);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewData_AAI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 391);
            this.panel2.TabIndex = 7;
            // 
            // buttonFunction_AAI
            // 
            this.buttonFunction_AAI.BackColor = System.Drawing.Color.Khaki;
            this.buttonFunction_AAI.Enabled = false;
            this.buttonFunction_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFunction_AAI.Location = new System.Drawing.Point(525, 47);
            this.buttonFunction_AAI.Name = "buttonFunction_AAI";
            this.buttonFunction_AAI.Size = new System.Drawing.Size(109, 65);
            this.buttonFunction_AAI.TabIndex = 11;
            this.buttonFunction_AAI.Text = "Показать графики";
            this.buttonFunction_AAI.UseVisualStyleBackColor = false;
            this.buttonFunction_AAI.Click += new System.EventHandler(this.buttonFunction_AAI_Click);
            // 
            // buttonTutorial_AAI
            // 
            this.buttonTutorial_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTutorial_AAI.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonTutorial_AAI.Enabled = false;
            this.buttonTutorial_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTutorial_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.help;
            this.buttonTutorial_AAI.Location = new System.Drawing.Point(941, 13);
            this.buttonTutorial_AAI.Name = "buttonTutorial_AAI";
            this.buttonTutorial_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonTutorial_AAI.TabIndex = 4;
            this.toolTip_AAI.SetToolTip(this.buttonTutorial_AAI, "Краткое руководство о пользовании программой\r\n");
            this.buttonTutorial_AAI.UseVisualStyleBackColor = false;
            this.buttonTutorial_AAI.Click += new System.EventHandler(this.buttonTutorial_AAI_Click);
            // 
            // buttonSaveFile_AAI
            // 
            this.buttonSaveFile_AAI.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSaveFile_AAI.Enabled = false;
            this.buttonSaveFile_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.page_save;
            this.buttonSaveFile_AAI.Location = new System.Drawing.Point(93, 13);
            this.buttonSaveFile_AAI.Name = "buttonSaveFile_AAI";
            this.buttonSaveFile_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonSaveFile_AAI.TabIndex = 3;
            this.toolTip_AAI.SetToolTip(this.buttonSaveFile_AAI, "Сохранить файл по указаному пути");
            this.buttonSaveFile_AAI.UseVisualStyleBackColor = false;
            this.buttonSaveFile_AAI.Click += new System.EventHandler(this.buttonSaveFile_AAI_Click);
            // 
            // buttonHelp_AAI
            // 
            this.buttonHelp_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAI.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.information;
            this.buttonHelp_AAI.Location = new System.Drawing.Point(1022, 13);
            this.buttonHelp_AAI.Name = "buttonHelp_AAI";
            this.buttonHelp_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp_AAI.TabIndex = 2;
            this.toolTip_AAI.SetToolTip(this.buttonHelp_AAI, "Информации о программе\r\nи разработчике");
            this.buttonHelp_AAI.UseVisualStyleBackColor = false;
            this.buttonHelp_AAI.Click += new System.EventHandler(this.buttonHelp_AAI_Click);
            // 
            // buttonOpenFile_AAI
            // 
            this.buttonOpenFile_AAI.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOpenFile_AAI.Enabled = false;
            this.buttonOpenFile_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint7.Project.V4.Properties.Resources.folder_page;
            this.buttonOpenFile_AAI.Location = new System.Drawing.Point(12, 13);
            this.buttonOpenFile_AAI.Name = "buttonOpenFile_AAI";
            this.buttonOpenFile_AAI.Size = new System.Drawing.Size(75, 65);
            this.buttonOpenFile_AAI.TabIndex = 0;
            this.toolTip_AAI.SetToolTip(this.buttonOpenFile_AAI, "Выберите фалй, с которым вы хотите выполнить редактирование\r\nили поиск информации" +
        "\r\n");
            this.buttonOpenFile_AAI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_AAI.Click += new System.EventHandler(this.buttonOpenFile_AAI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop_AAI);
            this.MinimumSize = new System.Drawing.Size(1125, 710);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проект | Спринт 7 | Вариант 4| Абдуллин А.И| АСОиУб-23-1|";
            this.panelTop_AAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_AAI)).EndInit();
            this.groupBoxStats_AAI.ResumeLayout(false);
            this.groupBoxStats_AAI.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAI;
        private System.Windows.Forms.Button buttonHelp_AAI;
        private System.Windows.Forms.Button buttonBookMax_AAI;
        private System.Windows.Forms.Button buttonOpenFile_AAI;
        private System.Windows.Forms.Button buttonSaveFile_AAI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_AAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_AAI;
        private System.Windows.Forms.DataGridView dataGridViewData_AAI;
        private System.Windows.Forms.TextBox textBoxSumm_AAI;
        private System.Windows.Forms.GroupBox groupBoxStats_AAI;
        private System.Windows.Forms.ToolTip toolTip_AAI;
        private System.Windows.Forms.Button buttonCount_AAI;
        private System.Windows.Forms.Button buttonMiddle_AAI;
        private System.Windows.Forms.Button buttonMin_AAI;
        private System.Windows.Forms.Button buttonMax_AAI;
        private System.Windows.Forms.TextBox textBoxCount_AAI;
        private System.Windows.Forms.TextBox textBoxMiddle_AAI;
        private System.Windows.Forms.TextBox textBoxMin_AAI;
        private System.Windows.Forms.TextBox textBoxMax_AAI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber_AAI;
        private System.Windows.Forms.Button buttonSearch_AAI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTutorial_AAI;
        private System.Windows.Forms.Button buttonFunction_AAI;
    }
}

