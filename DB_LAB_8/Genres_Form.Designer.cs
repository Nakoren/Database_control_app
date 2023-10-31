namespace DB_LAB_8
{
    partial class Genres_Form
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet1 = new DB_LAB_8.Game_development_studioDataSet();
            this.gamedevelopmentstudioDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter1 = new DB_LAB_8.Game_development_studioDataSetTableAdapters.genreTableAdapter();
            this.Publisher_delete_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamedevelopmentstudioDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(953, 347);
            this.dataGridView2.TabIndex = 0;
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "genre_ID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "genre_ID";
            this.genreIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            this.genreIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "genre_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "genre_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "genre_description";
            this.dataGridViewTextBoxColumn2.HeaderText = "genre_description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "genre";
            this.bindingSource1.DataSource = this.game_development_studioDataSet1;
            // 
            // game_development_studioDataSet1
            // 
            this.game_development_studioDataSet1.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamedevelopmentstudioDataSet1BindingSource
            // 
            this.gamedevelopmentstudioDataSet1BindingSource.DataSource = this.game_development_studioDataSet1;
            this.gamedevelopmentstudioDataSet1BindingSource.Position = 0;
            // 
            // genreTableAdapter1
            // 
            this.genreTableAdapter1.ClearBeforeFill = true;
            // 
            // Publisher_delete_button
            // 
            this.Publisher_delete_button.Location = new System.Drawing.Point(12, 376);
            this.Publisher_delete_button.Name = "Publisher_delete_button";
            this.Publisher_delete_button.Size = new System.Drawing.Size(294, 56);
            this.Publisher_delete_button.TabIndex = 5;
            this.Publisher_delete_button.Text = "Удалить строку";
            this.Publisher_delete_button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Вернуться в основное меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(673, 376);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(293, 56);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Сохранить изменения";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Genres_Form
            // 
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Publisher_delete_button);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Genres_Form";
            this.Load += new System.EventHandler(this.Genres_Form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamedevelopmentstudioDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Genre_delete_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private Game_development_studioDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn genrenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genredescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Genre_save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gamedevelopmentstudioDataSet1BindingSource;
        private Game_development_studioDataSet game_development_studioDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Game_development_studioDataSetTableAdapters.genreTableAdapter genreTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Publisher_delete_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_button;
    }
}