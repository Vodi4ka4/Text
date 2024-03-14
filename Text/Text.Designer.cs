namespace Text
{
    partial class Text
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
            this.button_Font = new System.Windows.Forms.Button();
            this.button_emphasized = new System.Windows.Forms.Button();
            this.button_italics = new System.Windows.Forms.Button();
            this.button_fat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_new = new System.Windows.Forms.TextBox();
            this.textBox_old = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_save_file = new System.Windows.Forms.Button();
            this.button_open_file = new System.Windows.Forms.Button();
            this.Text_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_Font
            // 
            this.button_Font.Location = new System.Drawing.Point(915, 12);
            this.button_Font.Name = "button_Font";
            this.button_Font.Size = new System.Drawing.Size(50, 41);
            this.button_Font.TabIndex = 31;
            this.button_Font.Text = "Шрифт";
            this.button_Font.UseVisualStyleBackColor = true;
            this.button_Font.Click += new System.EventHandler(this.button_Font_Click);
            // 
            // button_emphasized
            // 
            this.button_emphasized.Location = new System.Drawing.Point(818, 12);
            this.button_emphasized.Name = "button_emphasized";
            this.button_emphasized.Size = new System.Drawing.Size(91, 41);
            this.button_emphasized.TabIndex = 30;
            this.button_emphasized.Text = "Подчёркнутый";
            this.button_emphasized.UseVisualStyleBackColor = true;
            this.button_emphasized.Click += new System.EventHandler(this.button_emphasized_Click);
            // 
            // button_italics
            // 
            this.button_italics.Location = new System.Drawing.Point(761, 12);
            this.button_italics.Name = "button_italics";
            this.button_italics.Size = new System.Drawing.Size(51, 41);
            this.button_italics.TabIndex = 29;
            this.button_italics.Text = "Курсив";
            this.button_italics.UseVisualStyleBackColor = true;
            this.button_italics.Click += new System.EventHandler(this.button_italics_Click);
            // 
            // button_fat
            // 
            this.button_fat.Location = new System.Drawing.Point(696, 12);
            this.button_fat.Name = "button_fat";
            this.button_fat.Size = new System.Drawing.Size(59, 41);
            this.button_fat.TabIndex = 28;
            this.button_fat.Text = "Жирный";
            this.button_fat.UseVisualStyleBackColor = true;
            this.button_fat.Click += new System.EventHandler(this.button_fat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "На";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "С";
            // 
            // textBox_new
            // 
            this.textBox_new.Location = new System.Drawing.Point(590, 12);
            this.textBox_new.Name = "textBox_new";
            this.textBox_new.Size = new System.Drawing.Size(100, 20);
            this.textBox_new.TabIndex = 25;
            // 
            // textBox_old
            // 
            this.textBox_old.Location = new System.Drawing.Point(457, 12);
            this.textBox_old.Name = "textBox_old";
            this.textBox_old.Size = new System.Drawing.Size(100, 20);
            this.textBox_old.TabIndex = 24;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(442, 32);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(248, 21);
            this.button_update.TabIndex = 23;
            this.button_update.Text = "Замена";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(336, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 22;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(336, 32);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 21);
            this.button_search.TabIndex = 21;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(255, 12);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 41);
            this.button_insert.TabIndex = 20;
            this.button_insert.Text = "Вставить";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(174, 12);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(75, 41);
            this.button_copy.TabIndex = 19;
            this.button_copy.Text = "Копировать";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_save_file
            // 
            this.button_save_file.Location = new System.Drawing.Point(93, 12);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new System.Drawing.Size(75, 41);
            this.button_save_file.TabIndex = 18;
            this.button_save_file.Text = "Сохранить";
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            // 
            // button_open_file
            // 
            this.button_open_file.Location = new System.Drawing.Point(12, 12);
            this.button_open_file.Name = "button_open_file";
            this.button_open_file.Size = new System.Drawing.Size(75, 41);
            this.button_open_file.TabIndex = 17;
            this.button_open_file.Text = "Открыть файл";
            this.button_open_file.UseVisualStyleBackColor = true;
            this.button_open_file.Click += new System.EventHandler(this.button_open_file_Click);
            // 
            // Text_text
            // 
            this.Text_text.Location = new System.Drawing.Point(12, 59);
            this.Text_text.Name = "Text_text";
            this.Text_text.Size = new System.Drawing.Size(953, 379);
            this.Text_text.TabIndex = 32;
            this.Text_text.Text = "";
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.Text_text);
            this.Controls.Add(this.button_Font);
            this.Controls.Add(this.button_emphasized);
            this.Controls.Add(this.button_italics);
            this.Controls.Add(this.button_fat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_new);
            this.Controls.Add(this.textBox_old);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_save_file);
            this.Controls.Add(this.button_open_file);
            this.Name = "Text";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.Text_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Font;
        private System.Windows.Forms.Button button_emphasized;
        private System.Windows.Forms.Button button_italics;
        private System.Windows.Forms.Button button_fat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_new;
        private System.Windows.Forms.TextBox textBox_old;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_save_file;
        private System.Windows.Forms.Button button_open_file;
        private System.Windows.Forms.RichTextBox Text_text;
    }
}

