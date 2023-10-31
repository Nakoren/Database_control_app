namespace DB_LAB_8
{
    partial class Statistic_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.gamestatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_statisticTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.game_statisticTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statisticIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticouterviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistic_outer_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.Statistic_outer_viewTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticouterviewBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamestatisticBindingSource
            // 
            this.gamestatisticBindingSource.DataMember = "game_statistic";
            this.gamestatisticBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_statisticTableAdapter
            // 
            this.game_statisticTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statisticIDDataGridViewTextBoxColumn,
            this.gamenameDataGridViewTextBoxColumn,
            this.devcostDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.pressrateDataGridViewTextBoxColumn,
            this.userrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statisticouterviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(960, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statisticIDDataGridViewTextBoxColumn
            // 
            this.statisticIDDataGridViewTextBoxColumn.DataPropertyName = "statistic_ID";
            this.statisticIDDataGridViewTextBoxColumn.HeaderText = "statistic_ID";
            this.statisticIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statisticIDDataGridViewTextBoxColumn.Name = "statisticIDDataGridViewTextBoxColumn";
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            // 
            // devcostDataGridViewTextBoxColumn
            // 
            this.devcostDataGridViewTextBoxColumn.DataPropertyName = "dev_cost";
            this.devcostDataGridViewTextBoxColumn.HeaderText = "dev_cost";
            this.devcostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.devcostDataGridViewTextBoxColumn.Name = "devcostDataGridViewTextBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // pressrateDataGridViewTextBoxColumn
            // 
            this.pressrateDataGridViewTextBoxColumn.DataPropertyName = "press_rate";
            this.pressrateDataGridViewTextBoxColumn.HeaderText = "press_rate";
            this.pressrateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pressrateDataGridViewTextBoxColumn.Name = "pressrateDataGridViewTextBoxColumn";
            // 
            // userrateDataGridViewTextBoxColumn
            // 
            this.userrateDataGridViewTextBoxColumn.DataPropertyName = "user_rate";
            this.userrateDataGridViewTextBoxColumn.HeaderText = "user_rate";
            this.userrateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userrateDataGridViewTextBoxColumn.Name = "userrateDataGridViewTextBoxColumn";
            // 
            // statisticouterviewBindingSource
            // 
            this.statisticouterviewBindingSource.DataMember = "Statistic_outer_view";
            this.statisticouterviewBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // statistic_outer_viewTableAdapter
            // 
            this.statistic_outer_viewTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // Statistic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Statistic_form";
            this.Text = "Statistic_form";
            this.Load += new System.EventHandler(this.Statistic_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticouterviewBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource gamestatisticBindingSource;
        private Game_development_studioDataSetTableAdapters.game_statisticTableAdapter game_statisticTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource statisticouterviewBindingSource;
        private Game_development_studioDataSetTableAdapters.Statistic_outer_viewTableAdapter statistic_outer_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
    }
}