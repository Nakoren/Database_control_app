namespace DB_LAB_8
{
    partial class statistic_insert
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.jour_rate_tb = new System.Windows.Forms.TextBox();
            this.game_cb = new System.Windows.Forms.ComboBox();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Dev_cost_tb = new System.Windows.Forms.TextBox();
            this.earn_tb = new System.Windows.Forms.TextBox();
            this.player_rate_tb = new System.Windows.Forms.TextBox();
            this.gameTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.GameTableAdapter();
            this.Insert_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Внимание:\r\nдобавление данных поверх уже существующих приведёт к их замене";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(311, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Игра";
            // 
            // jour_rate_tb
            // 
            this.jour_rate_tb.Location = new System.Drawing.Point(11, 356);
            this.jour_rate_tb.Name = "jour_rate_tb";
            this.jour_rate_tb.Size = new System.Drawing.Size(310, 26);
            this.jour_rate_tb.TabIndex = 2;
            // 
            // game_cb
            // 
            this.game_cb.DataSource = this.gameBindingSource;
            this.game_cb.DisplayMember = "Game_name";
            this.game_cb.FormattingEnabled = true;
            this.game_cb.Location = new System.Drawing.Point(14, 126);
            this.game_cb.Name = "game_cb";
            this.game_cb.Size = new System.Drawing.Size(310, 28);
            this.game_cb.TabIndex = 3;
            this.game_cb.ValueMember = "Game_ID";
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 260);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(311, 26);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Суммарная прибыль";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 388);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(311, 26);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Оценки игроков";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 324);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(311, 26);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Оценки журналистов";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(13, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(311, 26);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Стоимость разработки";
            // 
            // Dev_cost_tb
            // 
            this.Dev_cost_tb.Location = new System.Drawing.Point(12, 228);
            this.Dev_cost_tb.Name = "Dev_cost_tb";
            this.Dev_cost_tb.Size = new System.Drawing.Size(310, 26);
            this.Dev_cost_tb.TabIndex = 8;
            // 
            // earn_tb
            // 
            this.earn_tb.Location = new System.Drawing.Point(12, 292);
            this.earn_tb.Name = "earn_tb";
            this.earn_tb.Size = new System.Drawing.Size(310, 26);
            this.earn_tb.TabIndex = 9;
            // 
            // player_rate_tb
            // 
            this.player_rate_tb.Location = new System.Drawing.Point(13, 420);
            this.player_rate_tb.Name = "player_rate_tb";
            this.player_rate_tb.Size = new System.Drawing.Size(310, 26);
            this.player_rate_tb.TabIndex = 10;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(13, 452);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(130, 52);
            this.Insert_button.TabIndex = 11;
            this.Insert_button.Text = "Внести запись";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statistic_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.player_rate_tb);
            this.Controls.Add(this.earn_tb);
            this.Controls.Add(this.Dev_cost_tb);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.game_cb);
            this.Controls.Add(this.jour_rate_tb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "statistic_insert";
            this.Text = "statistic_insert";
            this.Load += new System.EventHandler(this.statistic_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox jour_rate_tb;
        private System.Windows.Forms.ComboBox game_cb;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Dev_cost_tb;
        private System.Windows.Forms.TextBox earn_tb;
        private System.Windows.Forms.TextBox player_rate_tb;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Game_development_studioDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button button2;
    }
}