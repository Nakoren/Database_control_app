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
        public partial class employee_insert : Form
        {
            Employee_Form source;
            public employee_insert(Employee_Form source)
            {
                InitializeComponent();
                this.source = source;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                SqlCommand cmd = new SqlCommand("insert into employee (Full_name,work_time,Post_ID,studio_ID) values (@name,@time,@post,@studio)", Program.Main_Form.connect);
                SqlParameter param = new SqlParameter("@name", name_tb.Text);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@time", time_tb.Text);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@post", post_cb.SelectedValue.ToString());
                cmd.Parameters.Add(param);
                param = new SqlParameter("@studio", studio_cb.SelectedValue.ToString());
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                this.Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void employee_insert_Load(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.post". При необходимости она может быть перемещена или удалена.
                this.postTableAdapter.Fill(this.game_development_studioDataSet.post);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
                this.studioTableAdapter.Fill(this.game_development_studioDataSet.studio);

            }
        }
    }
