namespace system_report
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
            this.btOpenForlder = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btDeleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenForlder
            // 
            this.btOpenForlder.Location = new System.Drawing.Point(12, 37);
            this.btOpenForlder.Name = "btOpenForlder";
            this.btOpenForlder.Size = new System.Drawing.Size(65, 39);
            this.btOpenForlder.TabIndex = 0;
            this.btOpenForlder.Text = "Выбрать папку";
            this.btOpenForlder.UseVisualStyleBackColor = true;
            this.btOpenForlder.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(154, 129);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(74, 28);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(299, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(309, 409);
            this.checkedListBox1.TabIndex = 2;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(83, 37);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(65, 39);
            this.btOpenFile.TabIndex = 3;
            this.btOpenFile.Text = "Добавить файл";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btDeleteFile
            // 
            this.btDeleteFile.Location = new System.Drawing.Point(154, 37);
            this.btDeleteFile.Name = "btDeleteFile";
            this.btDeleteFile.Size = new System.Drawing.Size(65, 39);
            this.btDeleteFile.TabIndex = 4;
            this.btDeleteFile.Text = "Удалить файл";
            this.btDeleteFile.UseVisualStyleBackColor = true;
            this.btDeleteFile.Click += new System.EventHandler(this.btDeleteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 453);
            this.Controls.Add(this.btDeleteFile);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpenForlder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenForlder;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btDeleteFile;
    }
}

