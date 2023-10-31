namespace DB_LAB_8
{
    partial class Link_emp_game_form
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
            this.linkEGouterviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.link_EG_outer_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.Link_EG_outer_viewTableAdapter();
            this.game_tb = new System.Windows.Forms.ComboBox();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_tb = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.GameTableAdapter();
            this.employeeTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.employeeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamedevelopmentstudioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dev_teamTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.Dev_teamTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkEGouterviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.linkEGouterviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devteamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamedevelopmentstudioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEGouterviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkEGouterviewBindingSource
            // 
            this.linkEGouterviewBindingSource.DataMember = "Link_EG_outer_view";
            this.linkEGouterviewBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // link_EG_outer_viewTableAdapter
            // 
            this.link_EG_outer_viewTableAdapter.ClearBeforeFill = true;
            // 
            // game_tb
            // 
            this.game_tb.DataSource = this.gameBindingSource1;
            this.game_tb.DisplayMember = "Game_name";
            this.game_tb.FormattingEnabled = true;
            this.game_tb.Location = new System.Drawing.Point(12, 75);
            this.game_tb.Name = "game_tb";
            this.game_tb.Size = new System.Drawing.Size(228, 28);
            this.game_tb.TabIndex = 1;
            this.game_tb.ValueMember = "Game_ID";
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // employee_tb
            // 
            this.employee_tb.DataSource = this.employeeBindingSource;
            this.employee_tb.DisplayMember = "Full_name";
            this.employee_tb.FormattingEnabled = true;
            this.employee_tb.Location = new System.Drawing.Point(12, 151);
            this.employee_tb.Name = "employee_tb";
            this.employee_tb.Size = new System.Drawing.Size(228, 28);
            this.employee_tb.TabIndex = 2;
            this.employee_tb.ValueMember = "Employee_ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Игра";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить связь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить связь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // devteamBindingSource
            // 
            this.devteamBindingSource.DataMember = "Dev_team";
            this.devteamBindingSource.DataSource = this.gamedevelopmentstudioDataSetBindingSource;
            // 
            // gamedevelopmentstudioDataSetBindingSource
            // 
            this.gamedevelopmentstudioDataSetBindingSource.DataSource = this.game_development_studioDataSet;
            this.gamedevelopmentstudioDataSetBindingSource.Position = 0;
            // 
            // dev_teamTableAdapter
            // 
            this.dev_teamTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamenameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.linkEGouterviewBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(267, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(811, 395);
            this.dataGridView1.TabIndex = 8;
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "Game_name";
            this.gamenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dev_Game_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dev_Game_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // linkEGouterviewBindingSource1
            // 
            this.linkEGouterviewBindingSource1.DataMember = "Link_EG_outer_view";
            this.linkEGouterviewBindingSource1.DataSource = this.game_development_studioDataSet;
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "Game";
            this.gameBindingSource1.DataSource = this.game_development_studioDataSet;
            // 
            // Link_emp_game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.employee_tb);
            this.Controls.Add(this.game_tb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Link_emp_game_form";
            this.Text = "Link_emp_game_form";
            this.Load += new System.EventHandler(this.Link_emp_game_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linkEGouterviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devteamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamedevelopmentstudioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEGouterviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource linkEGouterviewBindingSource;
        private Game_development_studioDataSetTableAdapters.Link_EG_outer_viewTableAdapter link_EG_outer_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devGameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox game_tb;
        private System.Windows.Forms.ComboBox employee_tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Game_development_studioDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Game_development_studioDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.BindingSource gamedevelopmentstudioDataSetBindingSource;
        private System.Windows.Forms.BindingSource devteamBindingSource;
        private Game_development_studioDataSetTableAdapters.Dev_teamTableAdapter dev_teamTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource linkEGouterviewBindingSource1;
        private System.Windows.Forms.BindingSource gameBindingSource1;
    }
}