using Tyuiu.HaevGS.Sprint6.Task5.V12.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task5.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V12.txt";

        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_DMS.ColumnCount = 2;
            dataGridViewNums_DMS.Columns[0].Width = 20;
            dataGridViewNums_DMS.Columns[1].Width = 50;

            this.chartDiag_DMS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_DMS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_DMS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_DMS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_DMS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_DMS_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-1 Дьяков Максик Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}