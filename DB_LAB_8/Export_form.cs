using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DB_LAB_8
{
    public partial class Export_form : Form
    {
        Game_development_studioDataSet.economic_viewDataTable source_economic = new Game_development_studioDataSet.economic_viewDataTable();
        Game_development_studioDataSet.employee_dataDataTable source_employee = new Game_development_studioDataSet.employee_dataDataTable();
        Game_development_studioDataSet.statistic_viewDataTable source_statistic = new Game_development_studioDataSet.statistic_viewDataTable();
        public Export_form()
        {
            InitializeComponent();
        }
        void ExportToExcel(DataTable table)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriterStream1 = new StreamWriter(Stream1, System.Text.Encoding.Unicode);

                    foreach (System.Data.DataColumn Column in table.Columns)
                        StreamWriterStream1.Write(Column.Caption + "\t");

                    StreamWriterStream1.WriteLine();
                    foreach (System.Data.DataRow Row in table.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWriterStream1.Write(Entity.ToString() + "\t");
                        }
                        StreamWriterStream1.WriteLine();
                    }
                    StreamWriterStream1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                Process.Start(Stream1.Name);
            }
        }
        void ExportToHTML(DataTable table, string ThisTitle)
        {
            int i, j;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriter1 = new StreamWriter(Stream1);

                    StreamWriter1.WriteLine("<html>");
                    StreamWriter1.WriteLine("<head>");
                    StreamWriter1.WriteLine("<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">");
                    StreamWriter1.WriteLine("<title>" + ThisTitle + "</title>");
                    StreamWriter1.WriteLine("</head>");
                    StreamWriter1.WriteLine("<body bgcolor=\"800000\">");
                    StreamWriter1.WriteLine("<table align=\"center\" cols =0 cellspacing =0>");
                    StreamWriter1.WriteLine("<tr>");
                    StreamWriter1.WriteLine("</td>");
                    StreamWriter1.WriteLine("</tr>");
                    StreamWriter1.WriteLine("<tr>");
                    for (j = 0; j < table.Columns.Count; j++)
                    {
                        StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\"><b>");
                        StreamWriter1.WriteLine("" + table.Columns[j].ColumnName);
                        StreamWriter1.WriteLine("</b></font></td>");
                    }
                    StreamWriter1.WriteLine("</tr>");
                    for (i = 0; i < table.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            StreamWriter1.WriteLine("<tr bgcolor=\"3399\">");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#000000\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                        else
                        {
                            StreamWriter1.WriteLine("<tr>");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                    }
                    StreamWriter1.WriteLine("</table></center></body></html>");
                    MessageBox.Show("Экспорт успешно завершен!", "Экспорт...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamWriter1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                Process.Start(Stream1.Name);
            }
        }




        private void Export_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.employee_data". При необходимости она может быть перемещена или удалена.
            this.employee_dataTableAdapter.Fill(this.game_development_studioDataSet.employee_data);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.statistic_view". При необходимости она может быть перемещена или удалена.
            this.statistic_viewTableAdapter.Fill(this.game_development_studioDataSet.statistic_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "game_development_studioDataSet.economic_view". При необходимости она может быть перемещена или удалена.
            this.economic_viewTableAdapter.Fill(this.game_development_studioDataSet.economic_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Excel_RB.Checked) && !(HTML_RB.Checked))
            {
                MessageBox.Show("Выберите тип выводимых данных","Ошибка!",MessageBoxButtons.OK);
                return;
            }
            if (Excel_RB.Checked)
            {
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
                saveFileDialog1.Title = "Экспорт: Excel";

                if (Statistic_CB.Checked)
                {
                    statistic_viewTableAdapter.Fill(source_statistic);
                    ExportToExcel(source_statistic);
                }
                if (Economic_CB.Checked)
                {
                    economic_viewTableAdapter.Fill(source_economic);
                    ExportToExcel(source_economic);
                }
                if (Employee_CB.Checked)
                {
                    employee_dataTableAdapter.Fill(source_employee);
                    ExportToExcel(source_employee);
                }
            }
            if (HTML_RB.Checked)
            {
                saveFileDialog1.DefaultExt = "html";
                saveFileDialog1.Filter = "EHTML files(*.html)|*.html";
                saveFileDialog1.Title = "Экспорт: HTML";


                if (Statistic_CB.Checked)
                {
                    statistic_viewTableAdapter.Fill(source_statistic);
                    ExportToHTML(source_statistic,Statistic_CB.Text);
                }
                if (Economic_CB.Checked)
                {
                    economic_viewTableAdapter.Fill(source_economic);
                    ExportToHTML(source_economic,Economic_CB.Text);
                }
                if (Employee_CB.Checked)
                {
                    employee_dataTableAdapter.Fill(source_employee);
                    ExportToHTML(source_employee,Employee_CB.Text);
                }
            }
        }
    }


    



}
