using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherAttendance.helper;
using TeacherAttendance.model;

namespace TeacherAttendance
{
    public partial class frmTeacherAttendance : Form
    {
        private AttendanceManagement attendance;
        private BindingSource bindingSource = new BindingSource();
       

        int indrow;
        public frmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void FrmTeacherAttendance_Load(object sender, EventArgs e)
        {
            attendance = new AttendanceManagement();
            ShowCourses();
            ShowTeachers();
            ShowRooms();

            //bindingSource.Add();
            DGVAttendance.DataSource = new List<Attendance>() { new Attendance() };
            DGVAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        
        private void ShowCourses()
        {
            cmbCourses.DataSource = null;
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseId";
            cmbCourses.DataSource = attendance.getAllCourses();
            cmbCourses.SelectedIndex = -1;
        }

        private void ShowTeachers()
        {
            cmbTeacherName.DataSource = null;
            cmbTeacherName.DisplayMember = "TeacherName";
            cmbTeacherName.ValueMember = "TeacherId";
            cmbTeacherName.DataSource = attendance.getAllTeachers();
            cmbTeacherName.SelectedIndex = -1;

        }

        private void ShowRooms()
        {
            cmbRoom.DataSource = null;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomId";
            cmbRoom.DataSource = attendance.getAllRooms();
            cmbRoom.SelectedIndex = -1;

        }
        private void CmbCourses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            string value = "";
            

            int id = ((Course)((ComboBox)sender).SelectedItem).CourseId;

            if(id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New course", "New course name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewCourse(value.Trim());
                    ShowCourses();
                }


            }
        }

        private void CmbTeacherName_SelectionChangeCommitted(object sender, EventArgs e)
        {


            string value = "";


            int id = ((Teacher)((ComboBox)sender).SelectedItem).TeacherId;

            if (id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New teacher", "New teacher name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewTeacher(value.Trim());
                    ShowTeachers();
                }


            }


        }

        private void CmbRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Room)((ComboBox)sender).SelectedItem).RoomId;

            if (id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New Room/Lab", "New Room/Lab name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewRoom(value.Trim());
                    ShowRooms();
                }


            }

        }

        private void BtnSave_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            DGVAttendance.DataSource = null;
            attendance.addAttendance(DTPickerdate.Value.ToString(), 
                                    (Teacher) cmbTeacherName.SelectedItem,
                                    (Course) cmbCourses.SelectedItem, 
                                    (Room) cmbRoom.SelectedItem, 
                                    DTPickerStartTime.Value.ToString(), 
                                    DTPickerLeaveTime.Value.ToString(), txtComment.Text);

            bindingSource.DataSource = attendance.getAllAttendance();
            DGVAttendance.DataSource = bindingSource;

            
        }

        private void DGVAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            indrow = e.RowIndex;
            /* if (e.ColumnIndex == 1)
             {
                 Attendance currentAtt = attendance.getAttendanceByIndex(e.RowIndex);

                 //MessageBox.Show(((Teacher) currentAtt.teacher).TeacherId + "");

             } else if (e.ColumnIndex == 2)
             {

             }
             else if (e.ColumnIndex == 3)
             {

             }*/
            if (e.RowIndex >= 0)
            {
                int ind = e.RowIndex;
                DataGridViewRow row = this.DGVAttendance.Rows[ind];
                DTPickerdate.Text = row.Cells[0].Value.ToString();
                cmbTeacherName.Text = row.Cells[1].Value.ToString();
                cmbCourses.Text = row.Cells[2].Value.ToString();
                cmbRoom.Text = row.Cells[3].Value.ToString();
                DTPickerStartTime.Text = row.Cells[4].Value.ToString();
                DTPickerLeaveTime.Text = row.Cells[5].Value.ToString();
                txtComment.Text = row.Cells[6].Value.ToString();
            }
        }

        private void DGVAttendance_DoubleClick(object sender, EventArgs e)
        {
            
            Attendance currentAtt = attendance.getAttendanceByIndex(
                DGVAttendance.CurrentRow.Index
            );

            DateTime dt = DateTime.Parse(currentAtt.attandancedate);
            DTPickerdate.Value = dt;

            //MessageBox.Show(currentAtt.teacher.TeacherName);
            cmbTeacherName.Text = currentAtt.teacher.TeacherName;

            cmbCourses.Text = currentAtt.course.CourseName;

            cmbRoom.Text = currentAtt.room.RoomName;


            txtComment.Text = currentAtt.comment;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DGVAttendance.DataSource = null;
            attendance.update(indrow, DTPickerdate.Value.ToString(),
                (Teacher)cmbTeacherName.SelectedItem,
                                     (Course)cmbCourses.SelectedItem,
                                     (Room)cmbRoom.SelectedItem,
                                     DTPickerStartTime.Value.ToString(),
                                     DTPickerLeaveTime.Value.ToString(), txtComment.Text
                );
            bindingSource.DataSource = attendance.getAllAttendance();
            DGVAttendance.DataSource = bindingSource;

        }

        private void DGVAttendance_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
