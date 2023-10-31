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
    public partial class employee_change : Form
    {
        Employee_Form source;
        public employee_change(Employee_Form source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void employee_change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.game_development_studioDataSet.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
            this.studioTableAdapter.Fill(this.game_development_studioDataSet.studio);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.game_development_studioDataSet.employee);

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update employee set Full_name = @name, Work_time = @time, post_ID = @post,Studio_ID = @studio where Employee_ID = @emp", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@name", name_tb.Text);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@time", time_tb.Text);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@post", post_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@studio", studio_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@emp", req_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            source.view_update();
            this.Close();
        }
    }
}
