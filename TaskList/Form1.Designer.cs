namespace TaskList
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.newTask = new System.Windows.Forms.PictureBox();
            this.saveTask = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.newTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(247, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 535);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // newTask
            // 
            this.newTask.Image = ((System.Drawing.Image)(resources.GetObject("newTask.Image")));
            this.newTask.Location = new System.Drawing.Point(42, 12);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(34, 33);
            this.newTask.TabIndex = 1;
            this.newTask.TabStop = false;
            this.newTask.Click += new System.EventHandler(this.newTask_Click);
            // 
            // saveTask
            // 
            this.saveTask.Image = ((System.Drawing.Image)(resources.GetObject("saveTask.Image")));
            this.saveTask.InitialImage = ((System.Drawing.Image)(resources.GetObject("saveTask.InitialImage")));
            this.saveTask.Location = new System.Drawing.Point(104, 12);
            this.saveTask.Name = "saveTask";
            this.saveTask.Size = new System.Drawing.Size(34, 33);
            this.saveTask.TabIndex = 2;
            this.saveTask.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(17, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(211, 496);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 559);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveTask);
            this.Controls.Add(this.newTask);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox newTask;
        private System.Windows.Forms.PictureBox saveTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

