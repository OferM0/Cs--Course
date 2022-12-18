namespace _15._12._2022WinFormDB
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listGuests = new System.Windows.Forms.ListView();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ברוכים הבאים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "הכנס שם אורח";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(356, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 22);
            this.txtName.TabIndex = 2;
            // 
            // listGuests
            // 
            this.listGuests.HideSelection = false;
            this.listGuests.Location = new System.Drawing.Point(361, 160);
            this.listGuests.Name = "listGuests";
            this.listGuests.Size = new System.Drawing.Size(121, 132);
            this.listGuests.TabIndex = 3;
            this.listGuests.UseCompatibleStateImageBehavior = false;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(385, 327);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 36);
            this.ok.TabIndex = 4;
            this.ok.Text = "אישור";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.listGuests);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listGuests;
        private System.Windows.Forms.Button ok;
    }
}