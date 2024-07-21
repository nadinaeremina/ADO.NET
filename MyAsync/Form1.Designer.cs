namespace MyAsync
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_fill = new System.Windows.Forms.Button();
            this.tbReq = new System.Windows.Forms.TextBox();
            this.bt_WH = new System.Windows.Forms.Button();
            this.bt_async = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 327);
            this.dataGridView1.TabIndex = 7;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(140, 61);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 6;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_fill
            // 
            this.bt_fill.Location = new System.Drawing.Point(39, 61);
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.Size = new System.Drawing.Size(75, 23);
            this.bt_fill.TabIndex = 5;
            this.bt_fill.Text = "Fill";
            this.bt_fill.UseVisualStyleBackColor = true;
            this.bt_fill.Click += new System.EventHandler(this.bt_fill_Click);
            // 
            // tbReq
            // 
            this.tbReq.Location = new System.Drawing.Point(39, 17);
            this.tbReq.Name = "tbReq";
            this.tbReq.Size = new System.Drawing.Size(702, 20);
            this.tbReq.TabIndex = 4;
            // 
            // bt_WH
            // 
            this.bt_WH.Location = new System.Drawing.Point(402, 61);
            this.bt_WH.Name = "bt_WH";
            this.bt_WH.Size = new System.Drawing.Size(116, 23);
            this.bt_WH.TabIndex = 9;
            this.bt_WH.Text = "AsyncWaitHandle";
            this.bt_WH.UseVisualStyleBackColor = true;
            this.bt_WH.Click += new System.EventHandler(this.bt_WH_Click);
            // 
            // bt_async
            // 
            this.bt_async.Location = new System.Drawing.Point(301, 61);
            this.bt_async.Name = "bt_async";
            this.bt_async.Size = new System.Drawing.Size(75, 23);
            this.bt_async.TabIndex = 8;
            this.bt_async.Text = "Async";
            this.bt_async.UseVisualStyleBackColor = true;
            this.bt_async.Click += new System.EventHandler(this.bt_async_Click);
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(565, 61);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 10;
            this.bt_show.Text = "Show";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_WH);
            this.Controls.Add(this.bt_async);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_fill);
            this.Controls.Add(this.tbReq);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_fill;
        private System.Windows.Forms.TextBox tbReq;
        private System.Windows.Forms.Button bt_WH;
        private System.Windows.Forms.Button bt_async;
        private System.Windows.Forms.Button bt_show;
    }
}