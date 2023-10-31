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
    public partial class statistic_insert : Form
    {
        Statistic_form source;  
        public statistic_insert(Statistic_form source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void statistic_insert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.game_development_studioDataSet.Game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from game_statistic where Game_ID = @g_id", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@g_id", game_cb.SelectedValue.ToString());
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            command = new SqlCommand("insert into game_statistic(game_id,dev_cost,income,press_rate,user_rate) values (@g_id,@cost,@income,@pr_rate,@pl_rate)", Program.Main_Form.connect);
            param = new SqlParameter("@g_id", game_cb.SelectedValue.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@cost", Dev_cost_tb.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@income", earn_tb.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@pr_rate", jour_rate_tb.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@pl_rate", player_rate_tb.Text);
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            source.view_update();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
