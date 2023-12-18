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
            openFileDialog_AAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_AAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            //считываем все из файлa
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //Определяем кол-во строк и столбцов
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            //Выдкляем массив данныч
            string[,] arraysValues = new string[rows, cols];

            //Заполняем массив
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arraysValues[i, j] = line_r[j];
                }
            }
            return arraysValues;
        }

        private void buttonOpenFile_AAI_Click(object sender, EventArgs e)
        {

        }
    }
}
