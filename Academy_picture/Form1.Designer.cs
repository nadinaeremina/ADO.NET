
namespace Academy_picture
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
            this.button_show_all = new System.Windows.Forms.Button();
            this.button_show_one = new System.Windows.Forms.Button();
            this.button_load_picture = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_show_all
            // 
            this.button_show_all.Location = new System.Drawing.Point(12, 49);
            this.button_show_all.Name = "button_show_all";
            this.button_show_all.Size = new System.Drawing.Size(75, 23);
            this.button_show_all.TabIndex = 0;
            this.button_show_all.Text = "Show all";
            this.button_show_all.UseVisualStyleBackColor = true;
            this.button_show_all.Click += new System.EventHandler(this.button_show_all_Click);
            // 
            // button_show_one
            // 
            this.button_show_one.Location = new System.Drawing.Point(93, 49);
            this.button_show_one.Name = "button_show_one";
            this.button_show_one.Size = new System.Drawing.Size(75, 23);
            this.button_show_one.TabIndex = 1;
            this.button_show_one.Text = "Show one";
            this.button_show_one.UseVisualStyleBackColor = true;
            this.button_show_one.Click += new System.EventHandler(this.button_show_one_Click);
            // 
            // button_load_picture
            // 
            this.button_load_picture.Location = new System.Drawing.Point(303, 51);
            this.button_load_picture.Name = "button_load_picture";
            this.button_load_picture.Size = new System.Drawing.Size(75, 23);
            this.button_load_picture.TabIndex = 2;
            this.button_load_picture.Text = "Load Picture";
            this.button_load_picture.UseVisualStyleBackColor = true;
            this.button_load_picture.Click += new System.EventHandler(this.button_load_picture_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 271);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(411, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 271);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_load_picture);
            this.Controls.Add(this.button_show_one);
            this.Controls.Add(this.button_show_all);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_show_all;
        private System.Windows.Forms.Button button_show_one;
        private System.Windows.Forms.Button button_load_picture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

