using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Aided_Instruction
{
    public partial class Input_Username : Form
    {
        public Input_Username()
        {
            InitializeComponent();
        }
        public static string username_input = "";
        public static string course_selected = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (course.SelectedItem.ToString() == "Information Communication and Technology")
            {
                username_input = username.Text;
                course_selected = "ICT";
            }
            else if (course.SelectedItem.ToString() == "Hotel Operation")
            {
                username_input = username.Text;
                course_selected = "H.O";
            }
            else if (course.SelectedItem.ToString() == "Accounting, Busniess and Management")
            {
                username_input = username.Text;
                course_selected = "ABM";
            }
            else if (course.SelectedItem.ToString() == "Culinary Arts")
            {
                username_input = username.Text;
                course_selected = "CA";
            }

            Menu show = new Menu();
            show.Show();
            this.Hide();
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Input_Username_Load(object sender, EventArgs e)
        {
            course.Items.Add("Information Communication and Technology");
            course.Items.Add("Hotel Operation");
            course.Items.Add("Accounting, Business and Management");
            course.Items.Add("Culinary Arts");
        }
    }
}
