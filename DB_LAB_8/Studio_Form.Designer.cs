namespace DB_LAB_8
{
    partial class Studio_Form
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
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.studioTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.studioTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studionameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioouterviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet1 = new DB_LAB_8.Game_development_studioDataSet();
            this.studio_outer_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.Studio_outer_viewTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioouterviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "studio";
            this.studioBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studioTableAdapter
            // 
            this.studioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studioIDDataGridViewTextBoxColumn,
            this.studionameDataGridViewTextBoxColumn,
            this.publishernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studioouterviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 415);
            this.dataGridView1.TabIndex = 10;
            // 
            // studioIDDataGridViewTextBoxColumn
            // 
            this.studioIDDataGridViewTextBoxColumn.DataPropertyName = "Studio_ID";
            this.studioIDDataGridViewTextBoxColumn.HeaderText = "Studio_ID";
            this.studioIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studioIDDataGridViewTextBoxColumn.Name = "studioIDDataGridViewTextBoxColumn";
            this.studioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studionameDataGridViewTextBoxColumn
            // 
            this.studionameDataGridViewTextBoxColumn.DataPropertyName = "studio_name";
            this.studionameDataGridViewTextBoxColumn.HeaderText = "studio_name";
            this.studionameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studionameDataGridViewTextBoxColumn.Name = "studionameDataGridViewTextBoxColumn";
            this.studionameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishernameDataGridViewTextBoxColumn
            // 
            this.publishernameDataGridViewTextBoxColumn.DataPropertyName = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.HeaderText = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publishernameDataGridViewTextBoxColumn.Name = "publishernameDataGridViewTextBoxColumn";
            this.publishernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studioouterviewBindingSource
            // 
            this.studioouterviewBindingSource.DataMember = "Studio_outer_view";
            this.studioouterviewBindingSource.DataSource = this.game_development_studioDataSet1;
            // 
            // game_development_studioDataSet1
            // 
            this.game_development_studioDataSet1.DataSetName = "Game_development_studioDataSet1";
            this.game_development_studioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studio_outer_viewTableAdapter
            // 
            this.studio_outer_viewTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1326, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click_1);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // Studio_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Studio_Form";
            this.Text = "Studio_Form";
            this.Load += new System.EventHandler(this.Studio_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioouterviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private Game_development_studioDataSetTableAdapters.studioTableAdapter studioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_development_studioDataSet game_development_studioDataSet1;
        private System.Windows.Forms.BindingSource studioouterviewBindingSource;
        private Game_development_studioDataSetTableAdapters.Studio_outer_viewTableAdapter studio_outer_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studionameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
    }
}