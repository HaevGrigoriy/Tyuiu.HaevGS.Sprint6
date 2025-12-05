namespace Tyuiu.HaevGS.Sprint6.Task6.V29
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_DMS = new Button();
            buttonSaveFile_DMS = new Button();
            groupBoxTask_DMS = new GroupBox();
            textBoxTask_DMS = new TextBox();
            splitter_DMS = new Splitter();
            groupBoxInput_DMS = new GroupBox();
            textBoxInput_DMS = new TextBox();
            groupBoxOutput_DMS = new GroupBox();
            textBoxResult_DMS = new TextBox();
            buttonHelp_DMS = new Button();
            openFileDialogTask_DMS = new OpenFileDialog();
            toolTipTask_DMS = new ToolTip(components);
            groupBoxTask_DMS.SuspendLayout();
            groupBoxInput_DMS.SuspendLayout();
            groupBoxOutput_DMS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_DMS
            // 
            buttonOpenFile_DMS.Image = (Image)resources.GetObject("buttonOpenFile_DMS.Image");
            buttonOpenFile_DMS.Location = new Point(12, 12);
            buttonOpenFile_DMS.Name = "buttonOpenFile_DMS";
            buttonOpenFile_DMS.Size = new Size(73, 64);
            buttonOpenFile_DMS.TabIndex = 0;
            toolTipTask_DMS.SetToolTip(buttonOpenFile_DMS, "Открыть файл.\r\nВыберете нужный файл для обработки.");
            buttonOpenFile_DMS.UseVisualStyleBackColor = true;
            buttonOpenFile_DMS.Click += buttonDone_DMS_Click;
            // 
            // buttonSaveFile_DMS
            // 
            buttonSaveFile_DMS.Image = (Image)resources.GetObject("buttonSaveFile_DMS.Image");
            buttonSaveFile_DMS.Location = new Point(91, 12);
            buttonSaveFile_DMS.Name = "buttonSaveFile_DMS";
            buttonSaveFile_DMS.Size = new Size(73, 64);
            buttonSaveFile_DMS.TabIndex = 1;
            toolTipTask_DMS.SetToolTip(buttonSaveFile_DMS, "Производит поиск в файле.");
            buttonSaveFile_DMS.UseVisualStyleBackColor = true;
            buttonSaveFile_DMS.Click += buttonOpenFile_DMS_Click;
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(textBoxTask_DMS);
            groupBoxTask_DMS.Location = new Point(12, 82);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(900, 68);
            groupBoxTask_DMS.TabIndex = 2;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие:";
            // 
            // textBoxTask_DMS
            // 
            textBoxTask_DMS.Location = new Point(3, 19);
            textBoxTask_DMS.Multiline = true;
            textBoxTask_DMS.Name = "textBoxTask_DMS";
            textBoxTask_DMS.ReadOnly = true;
            textBoxTask_DMS.Size = new Size(891, 37);
            textBoxTask_DMS.TabIndex = 0;
            textBoxTask_DMS.Text = resources.GetString("textBoxTask_DMS.Text");
            // 
            // splitter_DMS
            // 
            splitter_DMS.Location = new Point(0, 0);
            splitter_DMS.Name = "splitter_DMS";
            splitter_DMS.Size = new Size(470, 500);
            splitter_DMS.TabIndex = 3;
            splitter_DMS.TabStop = false;
            // 
            // groupBoxInput_DMS
            // 
            groupBoxInput_DMS.Controls.Add(textBoxInput_DMS);
            groupBoxInput_DMS.Location = new Point(12, 156);
            groupBoxInput_DMS.Name = "groupBoxInput_DMS";
            groupBoxInput_DMS.Size = new Size(458, 332);
            groupBoxInput_DMS.TabIndex = 0;
            groupBoxInput_DMS.TabStop = false;
            groupBoxInput_DMS.Text = "Ввод:";
            // 
            // textBoxInput_DMS
            // 
            textBoxInput_DMS.Location = new Point(6, 20);
            textBoxInput_DMS.Multiline = true;
            textBoxInput_DMS.Name = "textBoxInput_DMS";
            textBoxInput_DMS.ScrollBars = ScrollBars.Vertical;
            textBoxInput_DMS.Size = new Size(446, 306);
            textBoxInput_DMS.TabIndex = 5;
            // 
            // groupBoxOutput_DMS
            // 
            groupBoxOutput_DMS.Controls.Add(textBoxResult_DMS);
            groupBoxOutput_DMS.Location = new Point(476, 156);
            groupBoxOutput_DMS.Name = "groupBoxOutput_DMS";
            groupBoxOutput_DMS.Size = new Size(464, 332);
            groupBoxOutput_DMS.TabIndex = 0;
            groupBoxOutput_DMS.TabStop = false;
            groupBoxOutput_DMS.Text = "Вывод:";
            // 
            // textBoxResult_DMS
            // 
            textBoxResult_DMS.Location = new Point(3, 19);
            textBoxResult_DMS.Multiline = true;
            textBoxResult_DMS.Name = "textBoxResult_DMS";
            textBoxResult_DMS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DMS.Size = new Size(446, 307);
            textBoxResult_DMS.TabIndex = 0;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.Image = (Image)resources.GetObject("buttonHelp_DMS.Image");
            buttonHelp_DMS.Location = new Point(839, 12);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(73, 64);
            buttonHelp_DMS.TabIndex = 4;
            toolTipTask_DMS.SetToolTip(buttonHelp_DMS, "Сведения о программе.");
            buttonHelp_DMS.UseVisualStyleBackColor = true;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            // 
            // openFileDialogTask_DMS
            // 
            openFileDialogTask_DMS.FileName = "openFileDialog1";
            // 
            // toolTipTask_DMS
            // 
            toolTipTask_DMS.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_DMS.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 500);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(groupBoxOutput_DMS);
            Controls.Add(groupBoxInput_DMS);
            Controls.Add(groupBoxTask_DMS);
            Controls.Add(buttonSaveFile_DMS);
            Controls.Add(buttonOpenFile_DMS);
            Controls.Add(splitter_DMS);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            groupBoxInput_DMS.ResumeLayout(false);
            groupBoxInput_DMS.PerformLayout();
            groupBoxOutput_DMS.ResumeLayout(false);
            groupBoxOutput_DMS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_DMS;
        private Button buttonSaveFile_DMS;
        private GroupBox groupBoxTask_DMS;
        private Splitter splitter_DMS;
        private GroupBox groupBoxInput_DMS;
        private GroupBox groupBoxOutput_DMS;
        private Button buttonHelp_DMS;
        private TextBox textBoxInput_DMS;
        private TextBox textBoxResult_DMS;
        private TextBox textBoxTask_DMS;
        private OpenFileDialog openFileDialogTask_DMS;
        private ToolTip toolTipTask_DMS;
    }
}
    }
}
