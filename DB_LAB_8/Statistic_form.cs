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
    public partial class Statistic_form : Form
    {
        public Statistic_form()
        {
            InitializeComponent();
        }

        private void Statistic_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Statistic_outer_view". При необходимости она может быть перемещена или удалена.
            this.statistic_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Statistic_outer_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.game_statistic". При необходимости она может быть перемещена или удалена.
            this.game_statisticTableAdapter.Fill(this.game_development_studioDataSet.game_statistic);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistic_insert statistic_Insert_AF= new statistic_insert(this);
            statistic_Insert_AF.Show();
        }

       

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую строку " + s, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from game_statistic where statistic_ID = "+s, Program.Main_Form.connect);
                command.ExecuteNonQuery();
            }
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void view_update()
        {
            this.statistic_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Statistic_outer_view);
            statistic_outer_viewTableAdapter.Adapter.Update(game_development_studioDataSet);
        }
    }
}
