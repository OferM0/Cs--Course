namespace _15._12._2022WinFormDB
{
    partial class frmHost
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.fill = new System.Windows.Forms.Button();
            this.listCategory = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח- הכנס קטגוריות";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(307, 92);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(168, 22);
            this.txtCategory.TabIndex = 1;
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(343, 137);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(94, 38);
            this.fill.TabIndex = 2;
            this.fill.Text = "הכנס";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // listCategory
            // 
            this.listCategory.HideSelection = false;
            this.listCategory.Location = new System.Drawing.Point(319, 199);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(147, 152);
            this.listCategory.TabIndex = 3;
            this.listCategory.UseCompatibleStateImageBehavior = false;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.ListView listCategory;
    }
}