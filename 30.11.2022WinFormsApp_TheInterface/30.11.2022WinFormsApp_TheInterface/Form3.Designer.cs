namespace _30._11._2022WinFormsApp_TheInterface
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
            this.add = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapes = new System.Windows.Forms.GroupBox();
            this.moon = new System.Windows.Forms.CheckBox();
            this.triangle = new System.Windows.Forms.CheckBox();
            this.elipse = new System.Windows.Forms.CheckBox();
            this.circle = new System.Windows.Forms.CheckBox();
            this.rectangle = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.shapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Info;
            this.add.Location = new System.Drawing.Point(84, 276);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 50);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.Info;
            this.show.Location = new System.Drawing.Point(565, 63);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(150, 50);
            this.show.TabIndex = 1;
            this.show.Text = "Show Result";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "The sum of vertices of ths shapes is: 0";
            // 
            // shapes
            // 
            this.shapes.Controls.Add(this.moon);
            this.shapes.Controls.Add(this.triangle);
            this.shapes.Controls.Add(this.elipse);
            this.shapes.Controls.Add(this.circle);
            this.shapes.Controls.Add(this.rectangle);
            this.shapes.Location = new System.Drawing.Point(153, 60);
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(250, 185);
            this.shapes.TabIndex = 3;
            this.shapes.TabStop = false;
            this.shapes.Text = "Shapes";
            // 
            // moon
            // 
            this.moon.AutoSize = true;
            this.moon.Location = new System.Drawing.Point(11, 149);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(70, 24);
            this.moon.TabIndex = 4;
            this.moon.Text = "moon";
            this.moon.UseVisualStyleBackColor = true;
            // 
            // triangle
            // 
            this.triangle.AutoSize = true;
            this.triangle.Location = new System.Drawing.Point(11, 119);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(82, 24);
            this.triangle.TabIndex = 3;
            this.triangle.Text = "triangle";
            this.triangle.UseVisualStyleBackColor = true;
            // 
            // elipse
            // 
            this.elipse.AutoSize = true;
            this.elipse.Location = new System.Drawing.Point(11, 89);
            this.elipse.Name = "elipse";
            this.elipse.Size = new System.Drawing.Size(70, 24);
            this.elipse.TabIndex = 2;
            this.elipse.Text = "elipse";
            this.elipse.UseVisualStyleBackColor = true;
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(11, 59);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(66, 24);
            this.circle.TabIndex = 1;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            this.rectangle.AutoSize = true;
            this.rectangle.Location = new System.Drawing.Point(11, 29);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(93, 24);
            this.rectangle.TabIndex = 0;
            this.rectangle.Text = "rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.Info;
            this.reset.Location = new System.Drawing.Point(278, 276);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 50);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.shapes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.add);
            this.Name = "Form3";
            this.Text = "Form3";
            this.shapes.ResumeLayout(false);
            this.shapes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add;
        private Button show;
        private Label label1;
        private GroupBox shapes;
        private CheckBox moon;
        private CheckBox triangle;
        private CheckBox elipse;
        private CheckBox circle;
        private CheckBox rectangle;
        private Button reset;
    }
}