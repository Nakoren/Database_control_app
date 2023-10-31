namespace DB_LAB_8
{
    partial class Post_Form
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
            this.postIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.postTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.postTableAdapter();
            this.Post_save_button = new System.Windows.Forms.Button();
            this.Post_delete_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
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
            this.postIDDataGridViewTextBoxColumn,
            this.postnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // postIDDataGridViewTextBoxColumn
            // 
            this.postIDDataGridViewTextBoxColumn.DataPropertyName = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.HeaderText = "Post_ID";
            this.postIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postIDDataGridViewTextBoxColumn.Name = "postIDDataGridViewTextBoxColumn";
            this.postIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postnameDataGridViewTextBoxColumn
            // 
            this.postnameDataGridViewTextBoxColumn.DataPropertyName = "post_name";
            this.postnameDataGridViewTextBoxColumn.HeaderText = "post_name";
            this.postnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postnameDataGridViewTextBoxColumn.Name = "postnameDataGridViewTextBoxColumn";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.game_development_studioDataSet;
            this.postBindingSource.CurrentChanged += new System.EventHandler(this.postBindingSource_CurrentChanged);
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // Post_save_button
            // 
            this.Post_save_button.Location = new System.Drawing.Point(932, 381);
            this.Post_save_button.Name = "Post_save_button";
            this.Post_save_button.Size = new System.Drawing.Size(362, 56);
            this.Post_save_button.TabIndex = 2;
            this.Post_save_button.Text = "Сохранить изменения";
            this.Post_save_button.UseVisualStyleBackColor = true;
            this.Post_save_button.Click += new System.EventHandler(this.Games_save_button_Click);
            // 
            // Post_delete_button
            // 
            this.Post_delete_button.Location = new System.Drawing.Point(12, 381);
            this.Post_delete_button.Name = "Post_delete_button";
            this.Post_delete_button.Size = new System.Drawing.Size(362, 56);
            this.Post_delete_button.TabIndex = 3;
            this.Post_delete_button.Text = "Удалить строку";
            this.Post_delete_button.UseVisualStyleBackColor = true;
            this.Post_delete_button.Click += new System.EventHandler(this.Games_delete_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вернуться в основное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Post_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Post_delete_button);
            this.Controls.Add(this.Post_save_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Post_Form";
            this.Text = "Post_Form";
            this.Load += new System.EventHandler(this.Post_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private Game_development_studioDataSetTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Post_save_button;
        private System.Windows.Forms.Button Post_delete_button;
        private System.Windows.Forms.Button button1;
    }
}