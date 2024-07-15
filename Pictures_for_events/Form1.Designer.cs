
namespace Pictures_for_events
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_load = new System.Windows.Forms.Button();
            this.button_show_one = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_show_all = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(23, 27);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(105, 33);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_show_one
            // 
            this.button_show_one.Location = new System.Drawing.Point(168, 27);
            this.button_show_one.Name = "button_show_one";
            this.button_show_one.Size = new System.Drawing.Size(105, 33);
            this.button_show_one.TabIndex = 2;
            this.button_show_one.Text = "Показать одного";
            this.button_show_one.UseVisualStyleBackColor = true;
            this.button_show_one.Click += new System.EventHandler(this.button_show_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 354);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_show_all
            // 
            this.button_show_all.Location = new System.Drawing.Point(305, 27);
            this.button_show_all.Name = "button_show_all";
            this.button_show_all.Size = new System.Drawing.Size(105, 33);
            this.button_show_all.TabIndex = 5;
            this.button_show_all.Text = "Показать всех";
            this.button_show_all.UseVisualStyleBackColor = true;
            this.button_show_all.Click += new System.EventHandler(this.button_show_all_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Заполнить \'event_content\'";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_show_all);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_show_one);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_show_one;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_show_all;
        private System.Windows.Forms.Button button1;
    }
}

