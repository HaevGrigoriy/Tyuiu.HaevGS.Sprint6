using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.HaevGS.Sprint6.Task1.V13.Lib;


namespace Tyuiu.HaevGS.Sprint6.Task1.V13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartVar_DMS.Text);
                int stopStep = Convert.ToInt32(textBoxEndVar_DMS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DMS.Text = "";
                textBoxResult_DMS.AppendText("+---------------------+" + Environment.NewLine);
                textBoxResult_DMS.AppendText("|    X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_DMS.AppendText("+---------------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |{1, 8:f2}   |", startStep, valueArray[i]);
                    textBoxResult_DMS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DMS.AppendText("+---------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-1 Дьяков Максим Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}