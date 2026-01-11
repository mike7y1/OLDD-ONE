using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvokedServer.Forms
{
    public partial class FrmAutoTasks : KryptonForm
    {
        private FrmMain frmMain;

        public FrmAutoTasks(FrmMain mainForm)
        {
            InitializeComponent();
            frmMain = mainForm;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string triggerValue = GetTriggerValue();
            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue;
            newRow.Cells["TaskCol"].Value = "Remote Execute";
            newRow.Cells["Param1Col"].Value = "Disk";
            newRow.Cells["Param2Col"].Value = diskTxt.Text;
            Application.DoEvents();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                diskTxt.Text = openFileDialog.FileName;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string triggerValue = GetTriggerValue();
            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue; 
            newRow.Cells["TaskCol"].Value = "Remote Execute";
            newRow.Cells["Param1Col"].Value = "URL";
            newRow.Cells["Param2Col"].Value = urlTxt.Text;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string host;
            if (guna2RadioButton9.Checked)
            {
                host = "cmd";
            }
            else
            {
                host = "powershell";
            }

            string triggerValue = GetTriggerValue();
            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue; 
            newRow.Cells["TaskCol"].Value = "Remote Command";
            newRow.Cells["Param1Col"].Value = host;
            newRow.Cells["Param2Col"].Value = cmdTxt.Text;
        }

        private void btnMutex_Click(object sender, EventArgs e)
        {
            string icon;
            if (NoneRadio.Checked)
            {
                icon = "None";
            }
            else if (HandRadio.Checked)
            {
                icon = "Hand";
            }
            else if (ExclemationRadio.Checked)
            {
                icon = "Exclamation";
            }
            else if (InformationRadio.Checked)
            {
                icon = "Information";
            }
            else if (ErrorRadio.Checked)
            {
                icon = "Error";
            }
            else if (QuestionRadio.Checked)
            {
                icon = "Question";
            }
            else if (WarningRadio.Checked)
            {
                icon = "Warning";
            }
            else if (AsteriksRadio.Checked)
            {
                icon = "Asterisk";
            }
            else
            {
                icon = "None";
            }

            string triggerValue = GetTriggerValue();

            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue;
            newRow.Cells["TaskCol"].Value = "Message Box";
            newRow.Cells["Param1Col"].Value = CaptionTxt.Text;
            newRow.Cells["Param2Col"].Value = MessageTxt.Text;
            newRow.Cells["Param3Col"].Value = icon;
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResetTxt.Text = openFileDialog.FileName;
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            string triggerValue = GetTriggerValue();

            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue; 
            newRow.Cells["TaskCol"].Value = "Reset Survival";
            newRow.Cells["Param1Col"].Value = ResetTxt.Text;
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            string triggerValue = GetTriggerValue();

            int newRowIndex = frmMain.TasksDataGridView.Rows.Add();
            var newRow = frmMain.TasksDataGridView.Rows[newRowIndex];
            newRow.Cells["TriggerCol"].Value = triggerValue;
            newRow.Cells["TaskCol"].Value = "Exclude System Drives";
        }

        private string GetTriggerValue()
        {
            if (rbInitial.Checked)
            {
                return "Initial Connection";
            }
            else if (rbAllcons.Checked)
            {
                return "All Connections";
            }
            else if (rbReset.Checked)
            {
                return "PC Reset";
            }
            else if (rbWord.Checked)
            {
                return "Keyword";
            }
            else
            {
                return "";
            }
        }
    }
}
