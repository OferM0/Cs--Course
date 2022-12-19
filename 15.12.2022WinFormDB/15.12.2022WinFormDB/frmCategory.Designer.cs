namespace _15._12._2022WinFormDB
{
    partial class frmCategory
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDish = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataAll = new System.Windows.Forms.DataGridView();
            this.dataGuest = new System.Windows.Forms.DataGridView();
            this.lblGuest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(344, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category: ";
            // 
            // txtDish
            // 
            this.txtDish.Location = new System.Drawing.Point(335, 210);
            this.txtDish.Name = "txtDish";
            this.txtDish.Size = new System.Drawing.Size(131, 22);
            this.txtDish.TabIndex = 1;
            this.txtDish.Visible = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(495, 206);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 30);
            this.add.TabIndex = 2;
            this.add.Text = "הוספת מאכל";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirm.Location = new System.Drawing.Point(195, 206);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 30);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "אישור";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNext.Location = new System.Drawing.Point(456, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">>>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrev.Location = new System.Drawing.Point(212, 408);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 30);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<<<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dataAll
            // 
            this.dataAll.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAll.Location = new System.Drawing.Point(195, 40);
            this.dataAll.Name = "dataAll";
            this.dataAll.RowHeadersWidth = 51;
            this.dataAll.RowTemplate.Height = 24;
            this.dataAll.Size = new System.Drawing.Size(400, 150);
            this.dataAll.TabIndex = 8;
            this.dataAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAll_CellDoubleClick);
            // 
            // dataGuest
            // 
            this.dataGuest.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuest.Location = new System.Drawing.Point(195, 252);
            this.dataGuest.Name = "dataGuest";
            this.dataGuest.RowHeadersWidth = 51;
            this.dataGuest.RowTemplate.Height = 24;
            this.dataGuest.Size = new System.Drawing.Size(400, 150);
            this.dataGuest.TabIndex = 9;
            this.dataGuest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGuest_CellDoubleClick);
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(12, 11);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(144, 25);
            this.lblGuest.TabIndex = 10;
            this.lblGuest.Text = "Guest Name: ";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.dataGuest);
            this.Controls.Add(this.dataAll);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtDish);
            this.Controls.Add(this.lblCategory);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDish;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataAll;
        private System.Windows.Forms.DataGridView dataGuest;
        private System.Windows.Forms.Label lblGuest;
    }
}