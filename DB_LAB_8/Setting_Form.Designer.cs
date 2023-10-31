namespace DB_LAB_8
{
    partial class Setting_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.settingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.settingTableAdapter();
            this.settingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting_save_button = new System.Windows.Forms.Button();
            this.Setting_delete_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settingIDDataGridViewTextBoxColumn,
            this.settingnameDataGridViewTextBoxColumn,
            this.settingdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.settingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1295, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // settingBindingSource
            // 
            this.settingBindingSource.DataMember = "setting";
            this.settingBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // settingTableAdapter
            // 
            this.settingTableAdapter.ClearBeforeFill = true;
            // 
            // settingIDDataGridViewTextBoxColumn
            // 
            this.settingIDDataGridViewTextBoxColumn.DataPropertyName = "Setting_ID";
            this.settingIDDataGridViewTextBoxColumn.HeaderText = "Setting_ID";
            this.settingIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.settingIDDataGridViewTextBoxColumn.Name = "settingIDDataGridViewTextBoxColumn";
            this.settingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // settingnameDataGridViewTextBoxColumn
            // 
            this.settingnameDataGridViewTextBoxColumn.DataPropertyName = "Setting_name";
            this.settingnameDataGridViewTextBoxColumn.HeaderText = "Setting_name";
            this.settingnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.settingnameDataGridViewTextBoxColumn.Name = "settingnameDataGridViewTextBoxColumn";
            // 
            // settingdescriptionDataGridViewTextBoxColumn
            // 
            this.settingdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Setting_description";
            this.settingdescriptionDataGridViewTextBoxColumn.HeaderText = "Setting_description";
            this.settingdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.settingdescriptionDataGridViewTextBoxColumn.Name = "settingdescriptionDataGridViewTextBoxColumn";
            // 
            // Setting_save_button
            // 
            this.Setting_save_button.Location = new System.Drawing.Point(945, 371);
            this.Setting_save_button.Name = "Setting_save_button";
            this.Setting_save_button.Size = new System.Drawing.Size(362, 56);
            this.Setting_save_button.TabIndex = 5;
            this.Setting_save_button.Text = "Сохранить изменения";
            this.Setting_save_button.UseVisualStyleBackColor = true;
            this.Setting_save_button.Click += new System.EventHandler(this.Setting_save_button_Click);
            // 
            // Setting_delete_button
            // 
            this.Setting_delete_button.Location = new System.Drawing.Point(12, 371);
            this.Setting_delete_button.Name = "Setting_delete_button";
            this.Setting_delete_button.Size = new System.Drawing.Size(362, 56);
            this.Setting_delete_button.TabIndex = 6;
            this.Setting_delete_button.Text = "Удалить строку";
            this.Setting_delete_button.UseVisualStyleBackColor = true;
            this.Setting_delete_button.Click += new System.EventHandler(this.Setting_delete_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вернуться в основное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Setting_delete_button);
            this.Controls.Add(this.Setting_save_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Setting_Form";
            this.Text = "Setting_Form";
            this.Load += new System.EventHandler(this.Setting_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource settingBindingSource;
        private Game_development_studioDataSetTableAdapters.settingTableAdapter settingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Setting_save_button;
        private System.Windows.Forms.Button Setting_delete_button;
        private System.Windows.Forms.Button button1;
    }
}