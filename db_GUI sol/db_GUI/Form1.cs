using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace db_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //do validation
            string cname = tbCName.Text;
            string ccode = tbCCode.Text;
            string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS;Database=demo_m_sp21;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            string query = string. Format("insert into courses values ('{0}','{1}')",cname,ccode);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to Insert Course");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            RefreshControls();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }
        List<Course> GetAllCourses()
        {
            string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS;Database=demo_m_sp21;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            List<Course> courses = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return courses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }
        void RefreshControls()
        {
            tbCName.Text = "";
            tbCCode.Text = "";
        }
    }
}
