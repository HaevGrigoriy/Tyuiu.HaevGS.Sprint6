using Tyuiu.HaevGS.Sprint6.Task4.V15.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task4.V15
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
                int startStep = Convert.ToInt32(textBoxStartStep_DMS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DMS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_DMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DMS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_DMS.Text = "";

                chartFunction_DMS.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_DMS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_DMS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТБ-25-1 Хаев Григорий Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_DMS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_DMS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!/n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}