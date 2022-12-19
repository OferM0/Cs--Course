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
            this.ok = new System.Windows.Forms.Button();
            this.listOfGuests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
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
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.OliveDrab;
            this.ok.Location = new System.Drawing.Point(383, 346);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 36);
            this.ok.TabIndex = 4;
            this.ok.Text = "אישור";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // listOfGuests
            // 
            this.listOfGuests.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listOfGuests.FormattingEnabled = true;
            this.listOfGuests.ItemHeight = 16;
            this.listOfGuests.Location = new System.Drawing.Point(310, 162);
            this.listOfGuests.Name = "listOfGuests";
            this.listOfGuests.Size = new System.Drawing.Size(226, 164);
            this.listOfGuests.TabIndex = 5;
            this.listOfGuests.SelectedIndexChanged += new System.EventHandler(this.listOfGuests_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfGuests);
            this.Controls.Add(this.ok);
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
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ListBox listOfGuests;
    }
}