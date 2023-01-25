namespace _21._12._2022WinFormDB
{
    partial class Form1
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.pGender = new System.Windows.Forms.Panel();
            this.pStatus = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdBtnSingle = new System.Windows.Forms.RadioButton();
            this.rdBtnMarried = new System.Windows.Forms.RadioButton();
            this.rdBtnDivorced = new System.Windows.Forms.RadioButton();
            this.rdBtnWidower = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchByCode = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.lblIdMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.pGender.SuspendLayout();
            this.pStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Sienna;
            this.lblCode.Location = new System.Drawing.Point(17, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 20);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "code";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Sienna;
            this.lblId.Location = new System.Drawing.Point(146, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Sienna;
            this.lblFirstName.Location = new System.Drawing.Point(255, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "first name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Sienna;
            this.lblLastName.Location = new System.Drawing.Point(388, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "last name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.Sienna;
            this.lblBirthDate.Location = new System.Drawing.Point(555, 35);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(89, 20);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "birth date";
            // 
            // pGender
            // 
            this.pGender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pGender.Controls.Add(this.rdBtnFemale);
            this.pGender.Controls.Add(this.rdBtnMale);
            this.pGender.Location = new System.Drawing.Point(625, 135);
            this.pGender.Name = "pGender";
            this.pGender.Size = new System.Drawing.Size(154, 130);
            this.pGender.TabIndex = 5;
            // 
            // pStatus
            // 
            this.pStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pStatus.Controls.Add(this.rdBtnWidower);
            this.pStatus.Controls.Add(this.rdBtnDivorced);
            this.pStatus.Controls.Add(this.rdBtnMarried);
            this.pStatus.Controls.Add(this.rdBtnSingle);
            this.pStatus.Location = new System.Drawing.Point(431, 135);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(139, 199);
            this.pStatus.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(1, 75);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(71, 22);
            this.txtCode.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 22);
            this.txtId.TabIndex = 8;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(259, 75);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(79, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(391, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(78, 22);
            this.txtLastName.TabIndex = 10;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(524, 75);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(139, 22);
            this.txtBirthDate.TabIndex = 11;
            this.txtBirthDate.Value = new System.DateTime(2004, 12, 21, 0, 0, 0, 0);
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Location = new System.Drawing.Point(15, 25);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(58, 20);
            this.rdBtnMale.TabIndex = 0;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Location = new System.Drawing.Point(16, 66);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(69, 20);
            this.rdBtnFemale.TabIndex = 1;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnSingle
            // 
            this.rdBtnSingle.AutoSize = true;
            this.rdBtnSingle.Location = new System.Drawing.Point(20, 25);
            this.rdBtnSingle.Name = "rdBtnSingle";
            this.rdBtnSingle.Size = new System.Drawing.Size(64, 20);
            this.rdBtnSingle.TabIndex = 0;
            this.rdBtnSingle.TabStop = true;
            this.rdBtnSingle.Text = "single";
            this.rdBtnSingle.UseVisualStyleBackColor = true;
            // 
            // rdBtnMarried
            // 
            this.rdBtnMarried.AutoSize = true;
            this.rdBtnMarried.Location = new System.Drawing.Point(20, 66);
            this.rdBtnMarried.Name = "rdBtnMarried";
            this.rdBtnMarried.Size = new System.Drawing.Size(74, 20);
            this.rdBtnMarried.TabIndex = 1;
            this.rdBtnMarried.TabStop = true;
            this.rdBtnMarried.Text = "married";
            this.rdBtnMarried.UseVisualStyleBackColor = true;
            // 
            // rdBtnDivorced
            // 
            this.rdBtnDivorced.AutoSize = true;
            this.rdBtnDivorced.Location = new System.Drawing.Point(20, 110);
            this.rdBtnDivorced.Name = "rdBtnDivorced";
            this.rdBtnDivorced.Size = new System.Drawing.Size(81, 20);
            this.rdBtnDivorced.TabIndex = 2;
            this.rdBtnDivorced.TabStop = true;
            this.rdBtnDivorced.Text = "divorced";
            this.rdBtnDivorced.UseVisualStyleBackColor = true;
            // 
            // rdBtnWidower
            // 
            this.rdBtnWidower.AutoSize = true;
            this.rdBtnWidower.Location = new System.Drawing.Point(20, 150);
            this.rdBtnWidower.Name = "rdBtnWidower";
            this.rdBtnWidower.Size = new System.Drawing.Size(77, 20);
            this.rdBtnWidower.TabIndex = 3;
            this.rdBtnWidower.TabStop = true;
            this.rdBtnWidower.Text = "widower";
            this.rdBtnWidower.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNext.Location = new System.Drawing.Point(510, 355);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 40);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPrev.Location = new System.Drawing.Point(258, 355);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 40);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(620, 473);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(78, 22);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(480, 473);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(79, 22);
            this.txtHomePhone.TabIndex = 20;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(330, 473);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(76, 22);
            this.txtStreet.TabIndex = 19;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(195, 473);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(71, 22);
            this.txtNumber.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(601, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(476, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "home phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(341, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(196, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "number";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(75, 473);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(71, 22);
            this.txtCity.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(91, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "city";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNew.Location = new System.Drawing.Point(592, 523);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "new";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(435, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(274, 523);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDelete.Location = new System.Drawing.Point(114, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchByCode
            // 
            this.btnSearchByCode.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSearchByCode.Location = new System.Drawing.Point(592, 590);
            this.btnSearchByCode.Name = "btnSearchByCode";
            this.btnSearchByCode.Size = new System.Drawing.Size(152, 38);
            this.btnSearchByCode.TabIndex = 29;
            this.btnSearchByCode.Text = "search by code";
            this.btnSearchByCode.UseVisualStyleBackColor = false;
            this.btnSearchByCode.Click += new System.EventHandler(this.btnSearchByCode_Click);
            // 
            // btnSearchById
            // 
            this.btnSearchById.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSearchById.Location = new System.Drawing.Point(363, 590);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(152, 38);
            this.btnSearchById.TabIndex = 30;
            this.btnSearchById.Text = "search by id";
            this.btnSearchById.UseVisualStyleBackColor = false;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // lblIdMsg
            // 
            this.lblIdMsg.AutoSize = true;
            this.lblIdMsg.Location = new System.Drawing.Point(128, 110);
            this.lblIdMsg.Name = "lblIdMsg";
            this.lblIdMsg.Size = new System.Drawing.Size(0, 16);
            this.lblIdMsg.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(715, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(701, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(78, 22);
            this.txtAge.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdMsg);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnSearchByCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pGender.ResumeLayout(false);
            this.pGender.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Panel pGender;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker txtBirthDate;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton rdBtnMale;
        private System.Windows.Forms.RadioButton rdBtnWidower;
        private System.Windows.Forms.RadioButton rdBtnDivorced;
        private System.Windows.Forms.RadioButton rdBtnMarried;
        private System.Windows.Forms.RadioButton rdBtnSingle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchByCode;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Label lblIdMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
    }
}

