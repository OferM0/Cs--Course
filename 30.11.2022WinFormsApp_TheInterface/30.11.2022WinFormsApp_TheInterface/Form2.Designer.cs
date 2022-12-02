namespace _30._11._2022WinFormsApp_TheInterface
{
    partial class Form2
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
            this.print = new System.Windows.Forms.Button();
            this.kinly = new System.Windows.Forms.Button();
            this.cola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.print.Location = new System.Drawing.Point(326, 246);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(129, 45);
            this.print.TabIndex = 22;
            this.print.Text = "Print List";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // kinly
            // 
            this.kinly.BackColor = System.Drawing.SystemColors.Info;
            this.kinly.Location = new System.Drawing.Point(410, 159);
            this.kinly.Name = "kinly";
            this.kinly.Size = new System.Drawing.Size(94, 29);
            this.kinly.TabIndex = 21;
            this.kinly.Text = "Add Kinly";
            this.kinly.UseVisualStyleBackColor = false;
            this.kinly.Click += new System.EventHandler(this.kinly_Click);
            // 
            // cola
            // 
            this.cola.BackColor = System.Drawing.SystemColors.Info;
            this.cola.Location = new System.Drawing.Point(297, 159);
            this.cola.Name = "cola";
            this.cola.Size = new System.Drawing.Size(94, 29);
            this.cola.TabIndex = 20;
            this.cola.Text = "Add Cola";
            this.cola.UseVisualStyleBackColor = false;
            this.cola.Click += new System.EventHandler(this.cola_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.kinly);
            this.Controls.Add(this.cola);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button print;
        private Button kinly;
        private Button cola;
    }
}