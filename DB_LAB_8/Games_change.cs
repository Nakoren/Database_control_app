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
   
    public partial class Games_change : Form
    {
        Games_Form source;
        public Games_change(Games_Form source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void Games_change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.setting". При необходимости она может быть перемещена или удалена.
            this.settingTableAdapter.Fill(this.game_development_studioDataSet.setting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.game_development_studioDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
            this.studioTableAdapter.Fill(this.game_development_studioDataSet.studio);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.game_development_studioDataSet.Game);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Game set Game_name = @g_name, Release_date = @r_date, Dev_state = @d_state, genre_ID = @gen_ID,Setting_ID = @set_ID,Studio_ID = @stud_ID where Game_ID = @gam_ID", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@g_name", name_tb.Text);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@r_date", date_tb.Text);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@d_state", dev_state_tb.Text);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@gen_ID", genre_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@set_ID", setting_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@stud_ID", studio_cb.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@gam_ID", game_CB.SelectedValue.ToString());
            cmd.Parameters.Add(param);
            int number = cmd.ExecuteNonQuery();
            source.view_update();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
