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
    public partial class Games_insert : Form
    {
        Games_Form source;
        public Games_insert(Games_Form source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void Games_insert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.setting". При необходимости она может быть перемещена или удалена.
            this.settingTableAdapter.Fill(this.game_development_studioDataSet.setting);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.game_development_studioDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.game_development_studioDataSet.publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
            this.studioTableAdapter.Fill(this.game_development_studioDataSet.studio);
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_button_Click_1(object sender, EventArgs e)
        {
            int dev_st = Convert.ToInt32(dev_state_tb.Text);
            SqlCommand cmd = new SqlCommand("insert into Game (Game_name, Release_date, Dev_state, genre_ID,Setting_ID,Studio_ID) values (@g_name,@r_date,@d_state,@gen_ID,@set_ID,@stud_ID)", Program.Main_Form.connect);
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
            
            int number = cmd.ExecuteNonQuery();
            source.view_update();
            this.Close();
        }
    }
}
