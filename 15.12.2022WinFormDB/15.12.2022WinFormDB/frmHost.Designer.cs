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
            this.listCategory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSumDishes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSumDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Categories";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(575, 129);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(168, 22);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fill.Location = new System.Drawing.Point(611, 174);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(94, 38);
            this.fill.TabIndex = 2;
            this.fill.Text = "הכנס";
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // listCategory
            // 
            this.listCategory.BackColor = System.Drawing.Color.DarkSalmon;
            this.listCategory.FormattingEnabled = true;
            this.listCategory.ItemHeight = 16;
            this.listCategory.Location = new System.Drawing.Point(575, 238);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(168, 164);
            this.listCategory.TabIndex = 4;
            this.listCategory.SelectedIndexChanged += new System.EventHandler(this.listCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Orders";
            // 
            // dataSumDishes
            // 
            this.dataSumDishes.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataSumDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSumDishes.Location = new System.Drawing.Point(12, 129);
            this.dataSumDishes.Name = "dataSumDishes";
            this.dataSumDishes.RowHeadersWidth = 51;
            this.dataSumDishes.RowTemplate.Height = 24;
            this.dataSumDishes.Size = new System.Drawing.Size(240, 273);
            this.dataSumDishes.TabIndex = 7;
            // 
            // frmHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataSumDishes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "frmHost";
            this.Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataSumDishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataSumDishes;
    }
}