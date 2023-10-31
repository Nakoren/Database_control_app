using DB_LAB_8.Game_development_studioDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_8
{
    public partial class Publisher_Form : Form
    {
        public Publisher_Form()
        {
            InitializeComponent();
        }

        private void Publisher_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.publisher". При необходимости она может быть перемещена или удалена.
                this.publisherTableAdapter.Fill(this.game_development_studioDataSet.publisher);
           
        }

        private void Games_delete_button_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
            }
        }

        private void Games_save_button_Click(object sender, EventArgs e)
        {
            publisherTableAdapter.Update(game_development_studioDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main_Form.Activate();
        }
    }
}
