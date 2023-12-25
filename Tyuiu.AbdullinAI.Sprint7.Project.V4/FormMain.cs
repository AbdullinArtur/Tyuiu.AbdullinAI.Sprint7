using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AbdullinAI.Sprint7.Project.V4.Lib;

namespace Tyuiu.AbdullinAI.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();            
        }

        public string openFilePath;

        DataService ds = new DataService();

        private void buttonHelp_AAI_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
            buttonTutorial_AAI.Enabled = true;
        }

        static int cols;
        static int rows;
        public string path;
        static int cost;

        public static string[,] Array(string path)
        {

            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        int lin = Convert.ToInt32(strok[j]);
                        cost = j;
                        break;
                    }
                    catch
                    {
                        continue;
                    }

                }
            }

            string[,] mtr = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            return mtr;
        }



        private void buttonSaveFile_AAI_Click(object sender, EventArgs e)
        {
            saveFileDialog_AAI.FileName = "*.csv";
            saveFileDialog_AAI.InitialDirectory = @"C:\Users\Desktop";
            saveFileDialog_AAI.ShowDialog();


            string pathnew = saveFileDialog_AAI.FileName;
            FileInfo file = new FileInfo(pathnew);
            bool fileexists = file.Exists;
            if (fileexists)
            {
                File.Delete(pathnew);
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewData_AAI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewData_AAI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(pathnew, str + Environment.NewLine);
                str = "";
            }

        }



        private void buttonOpenFile_AAI_Click(object sender, EventArgs e)
        {
            openFileDialog_AAI.ShowDialog();
            path = openFileDialog_AAI.FileName;

            string[,] res = Array(path);
            dataGridViewData_AAI.Columns.Clear();
            dataGridViewData_AAI.Rows.Clear();

            dataGridViewData_AAI.ColumnCount = cols;
            dataGridViewData_AAI.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    dataGridViewData_AAI.Rows[i].Cells[j].Value = res[i, j];
                    dataGridViewData_AAI.Columns[j].Width = 100;
                    dataGridViewData_AAI.Rows[i].Height = 25;
                }
            }

            buttonBookMax_AAI.Enabled = true;
            buttonCount_AAI.Enabled = true;
            buttonMax_AAI.Enabled = true;
            buttonMin_AAI.Enabled = true;
            buttonMiddle_AAI.Enabled = true;
            buttonSearch_AAI.Enabled = true;   
            buttonSaveFile_AAI.Enabled = true;
        }

        

        private void buttonAddBook_AAI_Click(object sender, EventArgs e)
        {
            textBoxSumm_AAI.Text = Convert.ToString(ds.BookSumm(path, cost));
        }

        private void buttonMax_AAI_Click(object sender, EventArgs e)
        {
            textBoxMax_AAI.Text = Convert.ToString(ds.BookMax(path, cost));
        }

        private void buttonMin_AAI_Click(object sender, EventArgs e)
        {
            textBoxMin_AAI.Text = Convert.ToString(ds.BookMin(path, cost));
        }

        private void buttonMiddle_AAI_Click(object sender, EventArgs e)
        {
            textBoxMiddle_AAI.Text = Convert.ToString(ds.BookSumm(path, cost) / (rows - 1));          
        }

        private void buttonCount_AAI_Click(object sender, EventArgs e)
        {         
            textBoxCount_AAI.Text = Convert.ToString(rows - 1);
            buttonFunction_AAI.Enabled = true;
        }

        private void buttonSearch_AAI_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxNumber_AAI.Text);
                dataGridViewData_AAI.Columns.Clear();
                dataGridViewData_AAI.Rows.Clear();
                string[,] res = Array(path);
                dataGridViewData_AAI.ColumnCount = cols;
                dataGridViewData_AAI.RowCount = ID + 1;
                if (ID < rows)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (i == ID)
                            {

                                {
                                    dataGridViewData_AAI.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewData_AAI.Columns[j].Width = 100;
                                    dataGridViewData_AAI.Rows[i].Height = 25;                                   
                                }
                            }
                            else if (i == 0)
                            {
                                dataGridViewData_AAI.Rows[i].Cells[j].Value = res[i, j];
                            }

                        }
                    }

                }
                else
                {
                    dataGridViewData_AAI.Columns.Clear();
                    dataGridViewData_AAI.Rows.Clear();
                    MessageBox.Show("В базе данных нет такого количества элементов! Загрузите файл заново!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                dataGridViewData_AAI.Columns.Clear();
                dataGridViewData_AAI.Rows.Clear();
                MessageBox.Show("Нельзя найти отрицательный или нулевой элемент! Загрузите файл заново!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonTutorial_AAI_Click(object sender, EventArgs e)
        {
            FormTutorial formTut = new FormTutorial();
            formTut.ShowDialog();
            buttonOpenFile_AAI.Enabled = true;
        }
       

        private void buttonFunction_AAI_Click(object sender, EventArgs e)
        {
            FormFunction formf = new FormFunction();
            formf.pathFunc = path;
            formf.Show();

        }      
    }




}
