namespace _30._11._2022WinFormsApp_TheInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.AddToFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.LoadFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(128, 258);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 3;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(128, 333);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(125, 27);
            this.day.TabIndex = 4;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(128, 411);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(125, 27);
            this.age.TabIndex = 5;
            // 
            // AddToFile
            // 
            this.AddToFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddToFile.Location = new System.Drawing.Point(49, 105);
            this.AddToFile.Name = "AddToFile";
            this.AddToFile.Size = new System.Drawing.Size(184, 48);
            this.AddToFile.TabIndex = 6;
            this.AddToFile.Text = "Add To File";
            this.AddToFile.UseVisualStyleBackColor = false;
            this.AddToFile.Click += new System.EventHandler(this.AddToFile_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(128, 32);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(125, 27);
            this.fileName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "FileName";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LoadFromFile
            // 
            this.LoadFromFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadFromFile.Location = new System.Drawing.Point(49, 180);
            this.LoadFromFile.Name = "LoadFromFile";
            this.LoadFromFile.Size = new System.Drawing.Size(184, 48);
            this.LoadFromFile.TabIndex = 16;
            this.LoadFromFile.Text = "Load From File";
            this.LoadFromFile.UseVisualStyleBackColor = false;
            this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadFromFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.AddToFile);
            this.Controls.Add(this.age);
            this.Controls.Add(this.day);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox day;
        private TextBox age;
        private Button AddToFile;
        private TextBox fileName;
        private Label label4;
        private FileSystemWatcher fileSystemWatcher1;
        private Button LoadFromFile;
    }
}