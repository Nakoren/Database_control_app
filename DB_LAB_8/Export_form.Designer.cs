namespace DB_LAB_8
{
    partial class Export_form
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
            this.Employee_CB = new System.Windows.Forms.CheckBox();
            this.Excel_RB = new System.Windows.Forms.RadioButton();
            this.HTML_RB = new System.Windows.Forms.RadioButton();
            this.game_development_studioDataSet = new DB_LAB_8.Game_development_studioDataSet();
            this.economic_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.economic_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.economic_viewTableAdapter();
            this.tableAdapterManager = new DB_LAB_8.Game_development_studioDataSetTableAdapters.TableAdapterManager();
            this.statistic_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistic_viewTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.statistic_viewTableAdapter();
            this.employee_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_dataTableAdapter = new DB_LAB_8.Game_development_studioDataSetTableAdapters.employee_dataTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Economic_CB = new System.Windows.Forms.CheckBox();
            this.Statistic_CB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.economic_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_CB
            // 
            this.Employee_CB.AutoSize = true;
            this.Employee_CB.Location = new System.Drawing.Point(42, 41);
            this.Employee_CB.Name = "Employee_CB";
            this.Employee_CB.Size = new System.Drawing.Size(206, 24);
            this.Employee_CB.TabIndex = 0;
            this.Employee_CB.Text = "Данные о сотрудниках";
            this.Employee_CB.UseVisualStyleBackColor = true;
            // 
            // Excel_RB
            // 
            this.Excel_RB.AutoSize = true;
            this.Excel_RB.Location = new System.Drawing.Point(26, 25);
            this.Excel_RB.Name = "Excel_RB";
            this.Excel_RB.Size = new System.Drawing.Size(72, 24);
            this.Excel_RB.TabIndex = 1;
            this.Excel_RB.TabStop = true;
            this.Excel_RB.Text = "Excel";
            this.Excel_RB.UseVisualStyleBackColor = true;
            // 
            // HTML_RB
            // 
            this.HTML_RB.AutoSize = true;
            this.HTML_RB.Location = new System.Drawing.Point(26, 55);
            this.HTML_RB.Name = "HTML_RB";
            this.HTML_RB.Size = new System.Drawing.Size(77, 24);
            this.HTML_RB.TabIndex = 2;
            this.HTML_RB.TabStop = true;
            this.HTML_RB.Text = "HTML";
            this.HTML_RB.UseVisualStyleBackColor = true;
            // 
            // game_development_studioDataSet
            // 
            this.game_development_studioDataSet.DataSetName = "Game_development_studioDataSet";
            this.game_development_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // economic_viewBindingSource
            // 
            this.economic_viewBindingSource.DataMember = "economic_view";
            this.economic_viewBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // economic_viewTableAdapter
            // 
            this.economic_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Dev_teamTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.game_statisticTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.settingTableAdapter = null;
            this.tableAdapterManager.studioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_LAB_8.Game_development_studioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statistic_viewBindingSource
            // 
            this.statistic_viewBindingSource.DataMember = "statistic_view";
            this.statistic_viewBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // statistic_viewTableAdapter
            // 
            this.statistic_viewTableAdapter.ClearBeforeFill = true;
            // 
            // employee_dataBindingSource
            // 
            this.employee_dataBindingSource.DataMember = "employee_data";
            this.employee_dataBindingSource.DataSource = this.game_development_studioDataSet;
            // 
            // employee_dataTableAdapter
            // 
            this.employee_dataTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Экспорт данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Economic_CB
            // 
            this.Economic_CB.AutoSize = true;
            this.Economic_CB.Location = new System.Drawing.Point(42, 129);
            this.Economic_CB.Name = "Economic_CB";
            this.Economic_CB.Size = new System.Drawing.Size(273, 24);
            this.Economic_CB.TabIndex = 4;
            this.Economic_CB.Text = "Экономические данные студий";
            this.Economic_CB.UseVisualStyleBackColor = true;
            // 
            // Statistic_CB
            // 
            this.Statistic_CB.AutoSize = true;
            this.Statistic_CB.Location = new System.Drawing.Point(42, 84);
            this.Statistic_CB.Name = "Statistic_CB";
            this.Statistic_CB.Size = new System.Drawing.Size(182, 24);
            this.Statistic_CB.TabIndex = 5;
            this.Statistic_CB.Text = "Статистика студий";
            this.Statistic_CB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HTML_RB);
            this.groupBox1.Controls.Add(this.Excel_RB);
            this.groupBox1.Location = new System.Drawing.Point(42, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип вывода";
            // 
            // Export_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Statistic_CB);
            this.Controls.Add(this.Economic_CB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employee_CB);
            this.Name = "Export_form";
            this.Text = "Export_form";
            this.Load += new System.EventHandler(this.Export_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_development_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.economic_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Employee_CB;
        private System.Windows.Forms.RadioButton Excel_RB;
        private System.Windows.Forms.RadioButton HTML_RB;
        private Game_development_studioDataSet game_development_studioDataSet;
        private System.Windows.Forms.BindingSource economic_viewBindingSource;
        private Game_development_studioDataSetTableAdapters.economic_viewTableAdapter economic_viewTableAdapter;
        private Game_development_studioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource statistic_viewBindingSource;
        private Game_development_studioDataSetTableAdapters.statistic_viewTableAdapter statistic_viewTableAdapter;
        private System.Windows.Forms.BindingSource employee_dataBindingSource;
        private Game_development_studioDataSetTableAdapters.employee_dataTableAdapter employee_dataTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox Economic_CB;
        private System.Windows.Forms.CheckBox Statistic_CB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}