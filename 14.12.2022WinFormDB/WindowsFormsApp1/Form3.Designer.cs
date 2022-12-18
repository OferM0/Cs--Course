namespace WindowsFormsApp1
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
            this.tz = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.addToSystem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cellphone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tz
            // 
            this.tz.Location = new System.Drawing.Point(233, 224);
            this.tz.Name = "tz";
            this.tz.Size = new System.Drawing.Size(268, 22);
            this.tz.TabIndex = 15;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(233, 170);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(268, 22);
            this.lastName.TabIndex = 14;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(233, 109);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(268, 22);
            this.firstName.TabIndex = 13;
            // 
            // addToSystem
            // 
            this.addToSystem.Location = new System.Drawing.Point(327, 391);
            this.addToSystem.Name = "addToSystem";
            this.addToSystem.Size = new System.Drawing.Size(87, 40);
            this.addToSystem.TabIndex = 12;
            this.addToSystem.Text = "הכנס למערכת";
            this.addToSystem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "תעודת זהות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "שם משפחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "שם פרטי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "עובד חדש";
            // 
            // cellphone
            // 
            this.cellphone.Location = new System.Drawing.Point(233, 277);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(268, 22);
            this.cellphone.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "מספר טלפון";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cellphone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tz);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addToSystem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tz;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button addToSystem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cellphone;
        private System.Windows.Forms.Label label7;
    }
}