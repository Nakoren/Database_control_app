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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_LAB_8
{
    public partial class Studio_insert : Form
    {
        Studio_Form source;
        public Studio_insert()
        {
            InitializeComponent();
        }
        public Studio_insert(Studio_Form source_F)
        {
            source = source_F;
            InitializeComponent();
        }

        private void Publisher_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Studio_insert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.game_development_studioDataSet.publisher);

        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into studio(studio_name, publisher_id) values(@name,@pi)", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@name",Studio_name_TB.Text.ToString());
            cmd.Parameters.Add(param);
            param = new SqlParameter("@pi", Publisher_CB.SelectedValue.ToString());
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
