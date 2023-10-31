namespace DB_LAB_8
{
    partial class Games_Form
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
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.gameTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.GameTableAdapter();
            this.gameouterviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_outer_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.Game_outer_viewTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameouterviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genrenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studionameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоРазработчиковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameouterviewBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameouterviewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // gameouterviewBindingSource
            // 
            this.gameouterviewBindingSource.DataMember = "Game_outer_view";
            this.gameouterviewBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_outer_viewTableAdapter
            // 
            this.game_outer_viewTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.добавитьToolStripMenuItem.Text = "Операции";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click_1);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.gamenameDataGridViewTextBoxColumn,
            this.releasedateDataGridViewTextBoxColumn,
            this.devstateDataGridViewTextBoxColumn,
            this.settingnameDataGridViewTextBoxColumn,
            this.genrenameDataGridViewTextBoxColumn,
            this.studionameDataGridViewTextBoxColumn,
            this.количествоРазработчиковDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameouterviewBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 460);
            this.dataGridView1.TabIndex = 2;
            // 
            // gameouterviewBindingSource1
            // 
            this.gameouterviewBindingSource1.DataMember = "Game_outer_view";
            this.gameouterviewBindingSource1.DataSource = this.game_development_studioDataSet;
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "Game_ID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "Game_ID";
            this.gameIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            this.gameIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            this.gamenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // releasedateDataGridViewTextBoxColumn
            // 
            this.releasedateDataGridViewTextBoxColumn.DataPropertyName = "Release_date";
            this.releasedateDataGridViewTextBoxColumn.HeaderText = "Release_date";
            this.releasedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releasedateDataGridViewTextBoxColumn.Name = "releasedateDataGridViewTextBoxColumn";
            this.releasedateDataGridViewTextBoxColumn.Width = 150;
            // 
            // devstateDataGridViewTextBoxColumn
            // 
            this.devstateDataGridViewTextBoxColumn.DataPropertyName = "Dev_state";
            this.devstateDataGridViewTextBoxColumn.HeaderText = "Dev_state";
            this.devstateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.devstateDataGridViewTextBoxColumn.Name = "devstateDataGridViewTextBoxColumn";
            this.devstateDataGridViewTextBoxColumn.Width = 150;
            // 
            // settingnameDataGridViewTextBoxColumn
            // 
            this.settingnameDataGridViewTextBoxColumn.DataPropertyName = "Setting_name";
            this.settingnameDataGridViewTextBoxColumn.HeaderText = "Setting_name";
            this.settingnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.settingnameDataGridViewTextBoxColumn.Name = "settingnameDataGridViewTextBoxColumn";
            this.settingnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genrenameDataGridViewTextBoxColumn
            // 
            this.genrenameDataGridViewTextBoxColumn.DataPropertyName = "genre_name";
            this.genrenameDataGridViewTextBoxColumn.HeaderText = "genre_name";
            this.genrenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genrenameDataGridViewTextBoxColumn.Name = "genrenameDataGridViewTextBoxColumn";
            this.genrenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studionameDataGridViewTextBoxColumn
            // 
            this.studionameDataGridViewTextBoxColumn.DataPropertyName = "studio_name";
            this.studionameDataGridViewTextBoxColumn.HeaderText = "studio_name";
            this.studionameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studionameDataGridViewTextBoxColumn.Name = "studionameDataGridViewTextBoxColumn";
            this.studionameDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоРазработчиковDataGridViewTextBoxColumn
            // 
            this.количествоРазработчиковDataGridViewTextBoxColumn.DataPropertyName = "Количество разработчиков";
            this.количествоРазработчиковDataGridViewTextBoxColumn.HeaderText = "Количество разработчиков";
            this.количествоРазработчиковDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоРазработчиковDataGridViewTextBoxColumn.Name = "количествоРазработчиковDataGridViewTextBoxColumn";
            this.количествоРазработчиковDataGridViewTextBoxColumn.Width = 150;
            // 
            // Games_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Games_Form";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.Games_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameouterviewBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameouterviewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Game_development_studioDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.BindingSource gameouterviewBindingSource;
        private Game_development_studioDataSetTableAdapters.Game_outer_viewTableAdapter game_outer_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genrenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studionameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоРазработчиковDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gameouterviewBindingSource1;
    }
}