namespace DB_LAB_8
{
    partial class Base_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеттингиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочныеДанныеToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // справочныеДанныеToolStripMenuItem
            // 
            this.справочныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жанрыToolStripMenuItem,
            this.сеттингиToolStripMenuItem,
            this.игрыToolStripMenuItem,
            this.статистикаИгрыToolStripMenuItem,
            this.студииToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.издателиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.связьToolStripMenuItem});
            this.справочныеДанныеToolStripMenuItem.Name = "справочныеДанныеToolStripMenuItem";
            this.справочныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.справочныеДанныеToolStripMenuItem.Text = "Таблицы";
            this.справочныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.справочныеДанныеToolStripMenuItem_Click);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // сеттингиToolStripMenuItem
            // 
            this.сеттингиToolStripMenuItem.Name = "сеттингиToolStripMenuItem";
            this.сеттингиToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.сеттингиToolStripMenuItem.Text = "Сеттинги";
            this.сеттингиToolStripMenuItem.Click += new System.EventHandler(this.сеттингиToolStripMenuItem_Click);
            // 
            // игрыToolStripMenuItem
            // 
            this.игрыToolStripMenuItem.Name = "игрыToolStripMenuItem";
            this.игрыToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.игрыToolStripMenuItem.Text = "Игры";
            this.игрыToolStripMenuItem.Click += new System.EventHandler(this.игрыToolStripMenuItem_Click);
            // 
            // статистикаИгрыToolStripMenuItem
            // 
            this.статистикаИгрыToolStripMenuItem.Name = "статистикаИгрыToolStripMenuItem";
            this.статистикаИгрыToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.статистикаИгрыToolStripMenuItem.Text = "Статистика игры";
            this.статистикаИгрыToolStripMenuItem.Click += new System.EventHandler(this.статистикаИгрыToolStripMenuItem_Click);
            // 
            // студииToolStripMenuItem
            // 
            this.студииToolStripMenuItem.Name = "студииToolStripMenuItem";
            this.студииToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.студииToolStripMenuItem.Text = "Студии";
            this.студииToolStripMenuItem.Click += new System.EventHandler(this.студииToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // издателиToolStripMenuItem
            // 
            this.издателиToolStripMenuItem.Name = "издателиToolStripMenuItem";
            this.издателиToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.издателиToolStripMenuItem.Text = "Издатели";
            this.издателиToolStripMenuItem.Click += new System.EventHandler(this.издателиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // связьToolStripMenuItem
            // 
            this.связьToolStripMenuItem.Name = "связьToolStripMenuItem";
            this.связьToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.связьToolStripMenuItem.Text = "Связь разработчик-проект";
            this.связьToolStripMenuItem.Click += new System.EventHandler(this.связьToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.запросыToolStripMenuItem.Text = "Запросы";
            this.запросыToolStripMenuItem.Click += new System.EventHandler(this.запросыToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1300, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Base_Form";
            this.Text = "Game studio database manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеттингиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem издателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаИгрыToolStripMenuItem;
    }
}

