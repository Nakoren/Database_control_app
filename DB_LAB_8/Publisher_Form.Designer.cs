namespace DB_LAB_8
{
    partial class Publisher_Form
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
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.publisherTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.publisherTableAdapter();
            this.Publisher_delete_button = new System.Windows.Forms.Button();
            this.Publisher_save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherIDDataGridViewTextBoxColumn,
            this.publishernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.publisherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            this.publisherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishernameDataGridViewTextBoxColumn
            // 
            this.publishernameDataGridViewTextBoxColumn.DataPropertyName = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.HeaderText = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publishernameDataGridViewTextBoxColumn.Name = "publishernameDataGridViewTextBoxColumn";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // Publisher_delete_button
            // 
            this.Publisher_delete_button.Location = new System.Drawing.Point(12, 403);
            this.Publisher_delete_button.Name = "Publisher_delete_button";
            this.Publisher_delete_button.Size = new System.Drawing.Size(362, 56);
            this.Publisher_delete_button.TabIndex = 4;
            this.Publisher_delete_button.Text = "Удалить строку";
            this.Publisher_delete_button.UseVisualStyleBackColor = true;
            this.Publisher_delete_button.Click += new System.EventHandler(this.Games_delete_button_Click);
            // 
            // Publisher_save_button
            // 
            this.Publisher_save_button.Location = new System.Drawing.Point(950, 403);
            this.Publisher_save_button.Name = "Publisher_save_button";
            this.Publisher_save_button.Size = new System.Drawing.Size(362, 56);
            this.Publisher_save_button.TabIndex = 5;
            this.Publisher_save_button.Text = "Сохранить изменения";
            this.Publisher_save_button.UseVisualStyleBackColor = true;
            this.Publisher_save_button.Click += new System.EventHandler(this.Games_save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вернуться в основное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Publisher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Publisher_save_button);
            this.Controls.Add(this.Publisher_delete_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Publisher_Form";
            this.Text = "Publisher_Form";
            this.Load += new System.EventHandler(this.Publisher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private Game_development_studioDataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Publisher_delete_button;
        private System.Windows.Forms.Button Publisher_save_button;
        private System.Windows.Forms.Button button1;
    }
}