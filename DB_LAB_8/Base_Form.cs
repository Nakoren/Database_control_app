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
    public partial class Base_Form : Form
    {
        public Base_Form()
        {
            InitializeComponent();
            string connection_string = "Data Source=DESKTOP-HKQJ7CQ;Initial Catalog=Game_development_studio;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connection_string);
            connect.Open();
        }
        public System.Data.SqlClient.SqlConnection connect;
        private void Base_Form_Load(object sender, EventArgs E)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void справочныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genres_Form Genre_AF = new Genres_Form();
            Genre_AF.Show();
        }

        private void игрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Games_Form Game_AF = new Games_Form();
            Game_AF.Show();
        }

        private void сеттингиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting_Form setting_AF = new Setting_Form();
            setting_AF.Show();
        }

        private void студииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studio_Form studio_AF = new Studio_Form();
            studio_AF.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post_Form post_AF = new Post_Form();
            post_AF.Show();
        }

        private void издателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher_Form publisher_AF = new Publisher_Form();
            publisher_AF.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info_form info_AF = new Info_form();
            info_AF.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void связьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Link_emp_game_form game_emp_AF = new Link_emp_game_form();
            game_emp_AF.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Form employee_AF = new Employee_Form();
            employee_AF.Show();
        }

        private void статистикаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistic_form statistic_AF = new Statistic_form();
            statistic_AF.Show();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_form export_AF = new Export_form(); 
            export_AF.Show();
        }
    }
}
