namespace DB_LAB_8
{
    partial class employee_insert
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.TextBox();
            this.studio_cb = new System.Windows.Forms.ComboBox();
            this.post_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studioTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.studioTableAdapter();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.postTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Имя разработчика";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(12, 44);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(331, 26);
            this.name_tb.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(331, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "должность";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(331, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Студия";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(331, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Срок работы";
            // 
            // time_tb
            // 
            this.time_tb.Location = new System.Drawing.Point(12, 127);
            this.time_tb.Name = "time_tb";
            this.time_tb.Size = new System.Drawing.Size(331, 26);
            this.time_tb.TabIndex = 5;
            // 
            // studio_cb
            // 
            this.studio_cb.DataSource = this.studioBindingSource;
            this.studio_cb.DisplayMember = "studio_name";
            this.studio_cb.FormattingEnabled = true;
            this.studio_cb.Location = new System.Drawing.Point(12, 191);
            this.studio_cb.Name = "studio_cb";
            this.studio_cb.Size = new System.Drawing.Size(331, 28);
            this.studio_cb.TabIndex = 6;
            this.studio_cb.ValueMember = "Studio_ID";
            // 
            // post_cb
            // 
            this.post_cb.DataSource = this.postBindingSource;
            this.post_cb.DisplayMember = "post_name";
            this.post_cb.FormattingEnabled = true;
            this.post_cb.Location = new System.Drawing.Point(12, 257);
            this.post_cb.Name = "post_cb";
            this.post_cb.Size = new System.Drawing.Size(331, 28);
            this.post_cb.TabIndex = 7;
            this.post_cb.ValueMember = "Post_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // employee_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.post_cb);
            this.Controls.Add(this.studio_cb);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.textBox1);
            this.Name = "employee_insert";
            this.Text = "employee_insert";
            this.Load += new System.EventHandler(this.employee_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox time_tb;
        private System.Windows.Forms.ComboBox studio_cb;
        private System.Windows.Forms.ComboBox post_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private Game_development_studioDataSetTableAdapters.studioTableAdapter studioTableAdapter;
        private System.Windows.Forms.BindingSource postBindingSource;
        private Game_development_studioDataSetTableAdapters.postTableAdapter postTableAdapter;
    }
}