namespace DB_LAB_8
{
    partial class Games_change
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
            this.update_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dev_state_tb = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.setting_cb = new System.Windows.Forms.ComboBox();
            this.genre_cb = new System.Windows.Forms.ComboBox();
            this.studio_cb = new System.Windows.Forms.ComboBox();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.game_CB = new System.Windows.Forms.ComboBox();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.GameTableAdapter();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studioTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.studioTableAdapter();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.genreTableAdapter();
            this.settingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.settingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(12, 493);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(191, 65);
            this.update_button.TabIndex = 37;
            this.update_button.Text = "Изменить запись";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 65);
            this.button1.TabIndex = 36;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dev_state_tb
            // 
            this.dev_state_tb.Location = new System.Drawing.Point(12, 254);
            this.dev_state_tb.Name = "dev_state_tb";
            this.dev_state_tb.Size = new System.Drawing.Size(433, 26);
            this.dev_state_tb.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 222);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(283, 26);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "Статус разработки (0,1,2,3,4)";
            // 
            // setting_cb
            // 
            this.setting_cb.DataSource = this.settingBindingSource;
            this.setting_cb.DisplayMember = "Setting_name";
            this.setting_cb.FormattingEnabled = true;
            this.setting_cb.Location = new System.Drawing.Point(12, 384);
            this.setting_cb.Name = "setting_cb";
            this.setting_cb.Size = new System.Drawing.Size(433, 28);
            this.setting_cb.TabIndex = 33;
            this.setting_cb.ValueMember = "Setting_ID";
            // 
            // genre_cb
            // 
            this.genre_cb.DataSource = this.genreBindingSource;
            this.genre_cb.DisplayMember = "genre_name";
            this.genre_cb.FormattingEnabled = true;
            this.genre_cb.Location = new System.Drawing.Point(12, 318);
            this.genre_cb.Name = "genre_cb";
            this.genre_cb.Size = new System.Drawing.Size(433, 28);
            this.genre_cb.TabIndex = 32;
            this.genre_cb.ValueMember = "genre_ID";
            // 
            // studio_cb
            // 
            this.studio_cb.DataSource = this.studioBindingSource;
            this.studio_cb.DisplayMember = "studio_name";
            this.studio_cb.FormattingEnabled = true;
            this.studio_cb.Location = new System.Drawing.Point(12, 188);
            this.studio_cb.Name = "studio_cb";
            this.studio_cb.Size = new System.Drawing.Size(433, 28);
            this.studio_cb.TabIndex = 31;
            this.studio_cb.ValueMember = "Studio_ID";
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(12, 450);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(433, 26);
            this.date_tb.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 418);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(283, 26);
            this.textBox8.TabIndex = 29;
            this.textBox8.Text = "Дата выхода";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 352);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(283, 26);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "Сеттинг";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(283, 26);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Жанр";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(283, 26);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Студия разработчик";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(12, 123);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(433, 26);
            this.name_tb.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Название игры";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(433, 26);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = "Изменяемая запись";
            // 
            // game_CB
            // 
            this.game_CB.DataSource = this.gameBindingSource;
            this.game_CB.DisplayMember = "Game_name";
            this.game_CB.FormattingEnabled = true;
            this.game_CB.Location = new System.Drawing.Point(13, 45);
            this.game_CB.Name = "game_CB";
            this.game_CB.Size = new System.Drawing.Size(432, 28);
            this.game_CB.TabIndex = 39;
            this.game_CB.ValueMember = "Game_ID";
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
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
            // Games_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 579);
            this.Controls.Add(this.game_CB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.update_button);
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
            this.Name = "Games_change";
            this.Text = "Games_change";
            this.Load += new System.EventHandler(this.Games_change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dev_state_tb;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox setting_cb;
        private System.Windows.Forms.ComboBox genre_cb;
        private System.Windows.Forms.ComboBox studio_cb;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox game_CB;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Game_development_studioDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private Game_development_studioDataSetTableAdapters.studioTableAdapter studioTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private Game_development_studioDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource settingBindingSource;
        private Game_development_studioDataSetTableAdapters.settingTableAdapter settingTableAdapter;
    }
}