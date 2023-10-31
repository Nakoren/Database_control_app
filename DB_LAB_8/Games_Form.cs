    using DB_LAB_8.Game_development_studioDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_8
{
    public partial class Games_Form : Form
    {
        public Games_Form()
        {
            InitializeComponent();
        }

        private void Games_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Game_outer_view". При необходимости она может быть перемещена или удалена.
            this.game_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Game_outer_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Game". При необходимости она может быть перемещена или удалена.
            

        }

        private void Game_delete_button_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
            }
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main_Form.Activate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Games_change studio_change_AF = new Games_change(this);
            studio_change_AF.Show();
        }
        

        

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Games_insert studio_Insert_AF = new Games_insert(this);
            studio_Insert_AF.Show();
        }

        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Games_change games_Change = new Games_change(this);
            games_Change.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую строку " + s, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM game_statistic WHERE Game_ID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.Main_Form.connect);
                command.ExecuteNonQuery();
                sqlExpression = "DELETE FROM Dev_team WHERE Game_ID = " + s;
                command = new SqlCommand(sqlExpression, Program.Main_Form.connect);
                command.ExecuteNonQuery();
                sqlExpression = "DELETE FROM Game WHERE Game_ID = " + s;
                command = new SqlCommand(sqlExpression, Program.Main_Form.connect);
            }
            view_update();
        }
        public void view_update()
        {
            this.game_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Game_outer_view);
            game_outer_viewTableAdapter.Adapter.Update(game_development_studioDataSet);
        }
    }
}
