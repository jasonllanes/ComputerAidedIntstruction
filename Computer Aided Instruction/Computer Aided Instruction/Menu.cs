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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public static string gotUser = "";
        public static string gotCourse =" ";
        private void Menu_Load(object sender, EventArgs e)
        {
            
            if(Input_Username.course_selected.ToString() == "ICT")
            {
                user.Text = Input_Username.username_input.ToString();
                Course.Text = "ICT";
                tabControl1.SelectedIndex = 1;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
            }
            else if  (Input_Username.course_selected.ToString() == "HO")
            {
                user.Text = Input_Username.username_input.ToString();
                Course.Text = "Hotel Operation";
                tabControl1.SelectedIndex = 2;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
            }
            else if (Input_Username.course_selected.ToString() == "ABM")
            {
                user.Text = Input_Username.username_input.ToString();
                Course.Text = "ABM";
                tabControl1.SelectedIndex = 3;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage4);
            }
            else if (Input_Username.course_selected.ToString() == "CA")
            {
                user.Text = Input_Username.username_input.ToString();
                Course.Text = "Culinary Arts";
                tabControl1.SelectedIndex = 4;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage1);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_user_Click(object sender, EventArgs e)
        {
            Input_Username show = new Input_Username();
            show.Show();
            this.Hide();
        }
    }
}
