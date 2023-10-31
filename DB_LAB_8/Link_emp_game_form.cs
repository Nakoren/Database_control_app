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
    public partial class Link_emp_game_form : Form
    {
        public Link_emp_game_form()
        {
            InitializeComponent();
        }

        private void Link_emp_game_form_Load(object sender, EventArgs e)
        {
            this.gameTableAdapter.Fill(this.game_development_studioDataSet.Game);
            this.employeeTableAdapter.Fill(this.game_development_studioDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Link_EG_outer_view". При необходимости она может быть перемещена или удалена.
            this.link_EG_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Link_EG_outer_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Dev_team (Game_ID,Employee_ID) values (@game,@emp)", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@game", game_tb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@emp", employee_tb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            view_update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Удалить текущую строку " + s, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Dev_team WHERE Dev_Game_ID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.Main_Form.connect);
                int number = command.ExecuteNonQuery();
            }
            view_update();
            
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main_Form.Activate();
        }
        public void view_update()
        {
            this.link_EG_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Link_EG_outer_view);
            link_EG_outer_viewTableAdapter.Adapter.Update(game_development_studioDataSet);
        }
    }
}
