using Tyuiu.HaevGS.Sprint6.Task6.V29.Lib;

namespace Tyuiu.HaevGS.Sprint6.Task6.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_DMS_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            if (openFileDialogTask_DMS.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_DMS.FileName;

                // Считываем содержимое файла и отображаем в textBoxInput_DMS
                textBoxInput_DMS.Text = File.ReadAllText(openFilePath);

                // Очищаем textBoxResult_DMS
                textBoxResult_DMS.Clear();
            }
}
