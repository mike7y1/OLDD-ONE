using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokedServer.Forms
{
    public partial class FrmAddWord : KryptonForm
    {
        private FrmMain frmMain;
        public FrmAddWord(FrmMain mainForm)
        {
            InitializeComponent();
            frmMain = mainForm;
        }

        private void SetTitleBtn_Click(object sender, EventArgs e)
        {
            int newRowIndex = frmMain.NotiDataGridView.Rows.Add();
            var newRow = frmMain.NotiDataGridView.Rows[newRowIndex];
            newRow.Cells["keywordCol"].Value = WordTxt.Text;

            string dbPath = "Data Source=general.db;Version=3;";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();
                    string insertKeywordQuery = "INSERT INTO Keywords (keywordCol) VALUES (@keyword);";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertKeywordQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", WordTxt.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting keyword: {ex.Message}");
            }
            this.Close();
        }

    }
}
