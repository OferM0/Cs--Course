namespace _05._12._2022workingWithDB
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.Info;
            this.show.Location = new System.Drawing.Point(354, 238);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 4;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.Info;
            this.refresh.Location = new System.Drawing.Point(181, 238);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(321, 315);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(41, 16);
            this.price.TabIndex = 6;
            this.price.Text = "Price:";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(409, 315);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(44, 16);
            this.stock.TabIndex = 7;
            this.stock.Text = "Stock:";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.Info;
            this.check.Location = new System.Drawing.Point(536, 238);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 8;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(552, 315);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(44, 16);
            this.count.TabIndex = 9;
            this.count.Text = "Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Check how many products above the price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.check);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.refresh);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}