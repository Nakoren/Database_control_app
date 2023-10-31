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
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Employee_outer_view". При необходимости она может быть перемещена или удалена.
            this.employee_outer_viewTableAdapter.Fill(this.game_development_studioDataSet.Employee_outer_view);

        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_insert employee_insert_AF = new employee_insert(this);
            employee_insert_AF.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_change employee_change_AF = new employee_change(this);
            employee_change_AF.Show();
        }
        

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("delete from Dev_team where Employee_ID = " + s, Program.Main_Form.connect);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from employee where Employee_ID = " + s,Program.Main_Form.connect);
        }
        public void view_update()
        {

        }
    }
}
