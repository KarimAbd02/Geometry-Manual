namespace Справочник
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.войтиКакАдминистраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.абдурахманов_БДDataSet = new Справочник.Абдурахманов_БДDataSet();
            this.главаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.главаTableAdapter = new Справочник.Абдурахманов_БДDataSetTableAdapters.ГлаваTableAdapter();
            this.темыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.темыTableAdapter = new Справочник.Абдурахманов_БДDataSetTableAdapters.ТемыTableAdapter();
            this.темыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.заданиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заданиеTableAdapter = new Справочник.Абдурахманов_БДDataSetTableAdapters.ЗаданиеTableAdapter();
            this.темыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.темыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.темыBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абдурахманов_БДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.главаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заданиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.войтиКакАдминистраторToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // войтиКакАдминистраторToolStripMenuItem
            // 
            this.войтиКакАдминистраторToolStripMenuItem.Name = "войтиКакАдминистраторToolStripMenuItem";
            this.войтиКакАдминистраторToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.войтиКакАдминистраторToolStripMenuItem.Text = "Войти как администратор";
            this.войтиКакАдминистраторToolStripMenuItem.Click += new System.EventHandler(this.войтиКакАдминистраторToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 27);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Глава:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тема:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 302);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Задания:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 29);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // абдурахманов_БДDataSet
            // 
            this.абдурахманов_БДDataSet.DataSetName = "Абдурахманов_БДDataSet";
            this.абдурахманов_БДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // главаBindingSource
            // 
            this.главаBindingSource.DataMember = "Глава";
            this.главаBindingSource.DataSource = this.абдурахманов_БДDataSet;
            // 
            // главаTableAdapter
            // 
            this.главаTableAdapter.ClearBeforeFill = true;
            // 
            // темыBindingSource
            // 
            this.темыBindingSource.DataMember = "Темы";
            this.темыBindingSource.DataSource = this.абдурахманов_БДDataSet;
            // 
            // темыTableAdapter
            // 
            this.темыTableAdapter.ClearBeforeFill = true;
            // 
            // темыBindingSource1
            // 
            this.темыBindingSource1.DataMember = "Темы";
            this.темыBindingSource1.DataSource = this.абдурахманов_БДDataSet;
            // 
            // заданиеBindingSource
            // 
            this.заданиеBindingSource.DataMember = "Задание";
            this.заданиеBindingSource.DataSource = this.абдурахманов_БДDataSet;
            // 
            // заданиеTableAdapter
            // 
            this.заданиеTableAdapter.ClearBeforeFill = true;
            // 
            // темыBindingSource2
            // 
            this.темыBindingSource2.DataMember = "Темы";
            this.темыBindingSource2.DataSource = this.абдурахманов_БДDataSet;
            // 
            // темыBindingSource3
            // 
            this.темыBindingSource3.DataMember = "Темы";
            this.темыBindingSource3.DataSource = this.абдурахманов_БДDataSet;
            // 
            // темыBindingSource4
            // 
            this.темыBindingSource4.DataMember = "Темы";
            this.темыBindingSource4.DataSource = this.абдурахманов_БДDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник по Геометрии";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абдурахманов_БДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.главаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заданиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem войтиКакАдминистраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private Абдурахманов_БДDataSet абдурахманов_БДDataSet;
        private System.Windows.Forms.BindingSource главаBindingSource;
        private Абдурахманов_БДDataSetTableAdapters.ГлаваTableAdapter главаTableAdapter;
        private System.Windows.Forms.BindingSource темыBindingSource;
        private Абдурахманов_БДDataSetTableAdapters.ТемыTableAdapter темыTableAdapter;
        private System.Windows.Forms.BindingSource темыBindingSource1;
        private System.Windows.Forms.BindingSource заданиеBindingSource;
        private Абдурахманов_БДDataSetTableAdapters.ЗаданиеTableAdapter заданиеTableAdapter;
        private System.Windows.Forms.BindingSource темыBindingSource2;
        private System.Windows.Forms.BindingSource темыBindingSource3;
        private System.Windows.Forms.BindingSource темыBindingSource4;
    }
}

