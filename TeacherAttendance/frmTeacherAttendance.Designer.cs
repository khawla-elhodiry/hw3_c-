namespace TeacherAttendance
{
    partial class frmTeacherAttendance
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPickerdate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.DTPickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.DTPickerLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.DGVAttendance = new System.Windows.Forms.DataGridView();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(897, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room/Lab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(909, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leave Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comment";
            // 
            // DTPickerdate
            // 
            this.DTPickerdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPickerdate.Location = new System.Drawing.Point(151, 42);
            this.DTPickerdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPickerdate.Name = "DTPickerdate";
            this.DTPickerdate.Size = new System.Drawing.Size(272, 36);
            this.DTPickerdate.TabIndex = 7;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(601, 41);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(287, 37);
            this.cmbCourses.TabIndex = 9;
            this.cmbCourses.SelectionChangeCommitted += new System.EventHandler(this.CmbCourses_SelectionChangeCommitted);
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(151, 86);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(272, 37);
            this.cmbRoom.TabIndex = 10;
            this.cmbRoom.SelectionChangeCommitted += new System.EventHandler(this.CmbRoom_SelectionChangeCommitted);
            // 
            // DTPickerStartTime
            // 
            this.DTPickerStartTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerStartTime.Location = new System.Drawing.Point(603, 85);
            this.DTPickerStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPickerStartTime.Name = "DTPickerStartTime";
            this.DTPickerStartTime.Size = new System.Drawing.Size(284, 36);
            this.DTPickerStartTime.TabIndex = 11;
            // 
            // DTPickerLeaveTime
            // 
            this.DTPickerLeaveTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerLeaveTime.Location = new System.Drawing.Point(1079, 84);
            this.DTPickerLeaveTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPickerLeaveTime.Name = "DTPickerLeaveTime";
            this.DTPickerLeaveTime.Size = new System.Drawing.Size(288, 36);
            this.DTPickerLeaveTime.TabIndex = 12;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(151, 135);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(1216, 36);
            this.txtComment.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(473, 184);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSave_MouseClick);
            // 
            // DGVAttendance
            // 
            this.DGVAttendance.AllowUserToAddRows = false;
            this.DGVAttendance.AllowUserToDeleteRows = false;
            this.DGVAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAttendance.Location = new System.Drawing.Point(21, 235);
            this.DGVAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVAttendance.Name = "DGVAttendance";
            this.DGVAttendance.ReadOnly = true;
            this.DGVAttendance.RowHeadersWidth = 51;
            this.DGVAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAttendance.Size = new System.Drawing.Size(1347, 348);
            this.DGVAttendance.TabIndex = 16;
            this.DGVAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAttendance_CellClick);
            this.DGVAttendance.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGVAttendance_DataError);
            this.DGVAttendance.DoubleClick += new System.EventHandler(this.DGVAttendance_DoubleClick);
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Location = new System.Drawing.Point(1079, 39);
            this.cmbTeacherName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(288, 37);
            this.cmbTeacherName.TabIndex = 17;
            this.cmbTeacherName.SelectionChangeCommitted += new System.EventHandler(this.CmbTeacherName_SelectionChangeCommitted);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(762, 184);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 43);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 598);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbTeacherName);
            this.Controls.Add(this.DGVAttendance);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.DTPickerLeaveTime);
            this.Controls.Add(this.DTPickerStartTime);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.DTPickerdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTeacherAttendance";
            this.Text = "Teacher Attendance Tracker";
            this.Load += new System.EventHandler(this.FrmTeacherAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPickerdate;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker DTPickerStartTime;
        private System.Windows.Forms.DateTimePicker DTPickerLeaveTime;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView DGVAttendance;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.Button btnUpdate;
    }
}

