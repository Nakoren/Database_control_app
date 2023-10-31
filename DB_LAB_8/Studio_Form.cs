using DB_LAB_8.Game_development_studioDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_8
{
    public partial class Studio_Form : Form
    {
        public Studio_Form()
        {
            InitializeComponent();
        }

        private void Studio_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet1.Studio_outer_view". При необходимости она может быть перемещена или удалена.
            this.studio_outer_viewTableAdapter.Fill(this.game_development_studioDataSet1.Studio_outer_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
            
        }

       

        private void Studio_save_button_Click(object sender, EventArgs e)
        {
            studioTableAdapter.Update(game_development_studioDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main_Form.Activate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studio_insert studio_Insert_AF = new Studio_insert(this);
            studio_Insert_AF.Show();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studio_change studio_change_AF = new studio_change(this);
            studio_change_AF.Show();
        }
        public void view_update()
        {
            this.studio_outer_viewTableAdapter.Fill(this.game_development_studioDataSet1.Studio_outer_view);
            studio_outer_viewTableAdapter.Adapter.Update(game_development_studioDataSet);
        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую строку " + s, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM studio WHERE Studio_ID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.Main_Form.connect);
                int number = command.ExecuteNonQuery();
            }
            view_update();
        }
    }
}
