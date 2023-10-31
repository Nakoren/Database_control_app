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
    public partial class studio_change : Form
    {
        Studio_Form source;
        public studio_change(Studio_Form source_F)
        {
            InitializeComponent();
            source = source_F;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studio_change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.game_development_studioDataSet.publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.studio". При необходимости она может быть перемещена или удалена.
            this.studioTableAdapter.Fill(this.game_development_studioDataSet.studio);
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update studio set publisher_ID = @publ, studio_name = @name where studio_ID = @req", Program.Main_Form.connect);
            SqlParameter param = new SqlParameter("@publ",Publisher_CB.SelectedValue.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@name", Studio_name_TB.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@req", comboBox1.SelectedValue.ToString());
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            source.view_update();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
