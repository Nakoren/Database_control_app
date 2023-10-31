namespace DB_LAB_8
{
    partial class Games_insert
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.studio_cb = new System.Windows.Forms.ComboBox();
            this.studioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genre_cb = new System.Windows.Forms.ComboBox();
            this.setting_cb = new System.Windows.Forms.ComboBox();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studioTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.studioTableAdapter();
            this.publisherTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.publisherTableAdapter();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dev_state_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.studioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.genreTableAdapter();
            this.settingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.settingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Название игры";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(12, 44);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(433, 26);
            this.name_tb.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(283, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Студия разработчик";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(283, 26);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Жанр";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 292);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(283, 26);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Сеттинг";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 358);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(283, 26);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Дата выхода";
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(12, 390);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(433, 26);
            this.date_tb.TabIndex = 15;
            // 
            // studio_cb
            // 
            this.studio_cb.DataSource = this.studioBindingSource2;
            this.studio_cb.DisplayMember = "studio_name";
            this.studio_cb.FormattingEnabled = true;
            this.studio_cb.Location = new System.Drawing.Point(12, 128);
            this.studio_cb.Name = "studio_cb";
            this.studio_cb.Size = new System.Drawing.Size(433, 28);
            this.studio_cb.TabIndex = 16;
            this.studio_cb.ValueMember = "Studio_ID";
            // 
            // studioBindingSource1
            // 
            this.studioBindingSource1.DataMember = "studio";
            this.studioBindingSource1.DataSource = this.game_development_studioDataSet;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // genre_cb
            // 
            this.genre_cb.DataSource = this.genreBindingSource;
            this.genre_cb.DisplayMember = "genre_name";
            this.genre_cb.FormattingEnabled = true;
            this.genre_cb.Location = new System.Drawing.Point(12, 258);
            this.genre_cb.Name = "genre_cb";
            this.genre_cb.Size = new System.Drawing.Size(433, 28);
            this.genre_cb.TabIndex = 18;
            this.genre_cb.ValueMember = "genre_ID";
            // 
            // setting_cb
            // 
            this.setting_cb.DataSource = this.settingBindingSource;
            this.setting_cb.DisplayMember = "Setting_name";
            this.setting_cb.FormattingEnabled = true;
            this.setting_cb.Location = new System.Drawing.Point(12, 324);
            this.setting_cb.Name = "setting_cb";
            this.setting_cb.Size = new System.Drawing.Size(433, 28);
            this.setting_cb.TabIndex = 19;
            this.setting_cb.ValueMember = "Setting_ID";
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "studio";
            this.studioBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // studioTableAdapter
            // 
            this.studioTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 162);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(283, 26);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Статус разработки (0,1,2,3,4)";
            // 
            // dev_state_tb
            // 
            this.dev_state_tb.Location = new System.Drawing.Point(12, 194);
            this.dev_state_tb.Name = "dev_state_tb";
            this.dev_state_tb.Size = new System.Drawing.Size(433, 26);
            this.dev_state_tb.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 65);
            this.button1.TabIndex = 22;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(12, 433);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(191, 65);
            this.insert_button.TabIndex = 23;
            this.insert_button.Text = "Добавить игру";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click_1);
            // 
            // studioBindingSource2
            // 
            this.studioBindingSource2.DataMember = "studio";
            this.studioBindingSource2.DataSource = this.game_development_studioDataSet;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
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
            // Games_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 523);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dev_state_tb);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.setting_cb);
            this.Controls.Add(this.genre_cb);
            this.Controls.Add(this.studio_cb);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.textBox1);
            this.Name = "Games_insert";
            this.Text = "Games_insert";
            this.Load += new System.EventHandler(this.Games_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.ComboBox studio_cb;
        private System.Windows.Forms.ComboBox genre_cb;
        private System.Windows.Forms.ComboBox setting_cb;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private Game_development_studioDataSetTableAdapters.studioTableAdapter studioTableAdapter;
        private System.Windows.Forms.BindingSource studioBindingSource1;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private Game_development_studioDataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox dev_state_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.BindingSource studioBindingSource2;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private Game_development_studioDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource settingBindingSource;
        private Game_development_studioDataSetTableAdapters.settingTableAdapter settingTableAdapter;
    }
}