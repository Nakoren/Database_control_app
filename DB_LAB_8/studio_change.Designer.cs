namespace DB_LAB_8
{
    partial class studio_change
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
            this.button1 = new System.Windows.Forms.Button();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Publisher_CB = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Studio_name_TB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.studioTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.studioTableAdapter();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.publisherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(12, 277);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(167, 57);
            this.Insert_button.TabIndex = 11;
            this.Insert_button.Text = "Изменить запись";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Publisher_CB
            // 
            this.Publisher_CB.DataSource = this.publisherBindingSource;
            this.Publisher_CB.DisplayMember = "publisher_name";
            this.Publisher_CB.FormattingEnabled = true;
            this.Publisher_CB.Location = new System.Drawing.Point(11, 233);
            this.Publisher_CB.Name = "Publisher_CB";
            this.Publisher_CB.Size = new System.Drawing.Size(359, 28);
            this.Publisher_CB.TabIndex = 10;
            this.Publisher_CB.ValueMember = "publisher_ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(359, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Издатель";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(359, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Название студии";
            // 
            // Studio_name_TB
            // 
            this.Studio_name_TB.Location = new System.Drawing.Point(11, 154);
            this.Studio_name_TB.Name = "Studio_name_TB";
            this.Studio_name_TB.Size = new System.Drawing.Size(359, 26);
            this.Studio_name_TB.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(358, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Выберите изменяемую запись";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studioBindingSource;
            this.comboBox1.DisplayMember = "studio_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Studio_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "studio";
            this.studioBindingSource.DataSource = this.game_development_studioDataSet;
            this.studioBindingSource.CurrentChanged += new System.EventHandler(this.studioBindingSource_CurrentChanged);
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
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // studio_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 380);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Publisher_CB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Studio_name_TB);
            this.Name = "studio_change";
            this.Text = "studio_change";
            this.Load += new System.EventHandler(this.studio_change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.ComboBox Publisher_CB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Studio_name_TB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private Game_development_studioDataSet game_development_studioDataSet;
        private Game_development_studioDataSetTableAdapters.studioTableAdapter studioTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private Game_development_studioDataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
    }
}