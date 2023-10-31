namespace DB_LAB_8
{
    partial class Studio_insert
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
            this.Studio_name_TB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Publisher_CB = new System.Windows.Forms.ComboBox();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.publisherTableAdapter();
            this.publisherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Insert_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Studio_name_TB
            // 
            this.Studio_name_TB.Location = new System.Drawing.Point(12, 86);
            this.Studio_name_TB.Name = "Studio_name_TB";
            this.Studio_name_TB.Size = new System.Drawing.Size(359, 26);
            this.Studio_name_TB.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(359, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Название студии";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(359, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Издатель";
            // 
            // Publisher_CB
            // 
            this.Publisher_CB.DataSource = this.publisherBindingSource1;
            this.Publisher_CB.DisplayMember = "publisher_name";
            this.Publisher_CB.FormattingEnabled = true;
            this.Publisher_CB.Location = new System.Drawing.Point(12, 165);
            this.Publisher_CB.Name = "Publisher_CB";
            this.Publisher_CB.Size = new System.Drawing.Size(359, 28);
            this.Publisher_CB.TabIndex = 4;
            this.Publisher_CB.ValueMember = "publisher_ID";
            this.Publisher_CB.SelectedIndexChanged += new System.EventHandler(this.Publisher_CB_SelectedIndexChanged);
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
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // publisherBindingSource1
            // 
            this.publisherBindingSource1.DataMember = "publisher";
            this.publisherBindingSource1.DataSource = this.game_development_studioDataSet;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(13, 209);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(167, 57);
            this.Insert_button.TabIndex = 5;
            this.Insert_button.Text = "Добавить студию";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Studio_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Publisher_CB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Studio_name_TB);
            this.Name = "Studio_insert";
            this.Text = "Studio_insert";
            this.Load += new System.EventHandler(this.Studio_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Studio_name_TB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox Publisher_CB;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private Game_development_studioDataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource1;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button button1;
    }
}