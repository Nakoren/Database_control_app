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
    public partial class Genres_Form : Form
    {
        public Genres_Form()
        {
            InitializeComponent();
        }

        private void Genres_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.genre". При необходимости она может быть перемещена или удалена.
                this.genreTableAdapter.Fill(this.game_development_studioDataSet.genre);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Genre_delete_button_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);   
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            genreTableAdapter.Update(game_development_studioDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main_Form.Activate();
        }

        private void Genres_Form_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet1.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter1.Fill(this.game_development_studioDataSet1.genre);

        }
    }
}
