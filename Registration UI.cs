using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A8__Registration_UI
{
    public partial class Registration_UI: Form
    {
        public Registration_UI()
        {
            InitializeComponent();
            Reg_Users_ListBox.DataSource = Data_Manger.Users;
        }

        private void UN_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Data_Manger.Users.Contains(UN_TextBox.Text))
            {
                UserNamrd_Errors_Label.Text = "Invalid Username";
                UserNamrd_Errors_Label.Visible = true;
            }
            else UserNamrd_Errors_Label.Visible = false;
        }

        private void Pass_TextBox_Click(object sender, EventArgs e)
        {
                if (Show_Pass_CheckBox.Checked)
                {
                    Pass_TextBox.UseSystemPasswordChar = false;
                }
                else Pass_TextBox.UseSystemPasswordChar = true;
        }

        private void Pass_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Pass_TextBox.Text.Length < 8)
            {
                Pass_Errors_Label.Text = "Password must have at least 8 charachters.";
                Pass_Errors_Label.Visible = true;
            }
            else if (!Pass_TextBox.Text.Any(char.IsUpper) && !Pass_TextBox.Text.Any(char.IsDigit))
            {
                Pass_Errors_Label.Text = "Password must have at least one Upper charachter.\n" +
                                         "Password must have at least one Number.";
                Pass_Errors_Label.Visible = true;
            }
            else if (!Pass_TextBox.Text.Any(char.IsUpper))
            {
                Pass_Errors_Label.Text = "Password must have at least one Upper charachter.";
                Pass_Errors_Label.Visible = true;
            }
            else if (!Pass_TextBox.Text.Any(char.IsDigit))
            {
                Pass_Errors_Label.Text = "Password must have at least one Number.";
                Pass_Errors_Label.Visible = true;
            }
            else
            {
                Pass_Errors_Label.Visible = false;
            }
        }

        private void Show_Pass_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Pass_CheckBox.Checked)
            {
                Pass_TextBox.UseSystemPasswordChar = false;
            }
            else Pass_TextBox.UseSystemPasswordChar = true;
        }
        
        private void Reg_Button_Click(object sender, EventArgs e)
        {
            if (Data_Manger.Users.Contains(UN_TextBox.Text) || UN_TextBox.Text == "")
            {
                MessageBox.Show("Invalid Username");
            }
            else if( Utilities.ValidatePassword(Pass_TextBox.Text))
            {
                Utilities.Entity user = new Utilities.Entity() {UserName = UN_TextBox.Text , Password = Pass_TextBox.Text };
                Data_Manger.Entities.Add(user);
                Data_Manger.Users.Add(user.UserName);
                Data_Manger.SaveData();

                UN_TextBox.Text = "";
                Pass_TextBox.Text = "";
                Pass_Errors_Label.Visible = false;

                Reg_Users_ListBox.DataSource = null;
                Reg_Users_ListBox.DataSource = Data_Manger.Users;
                MessageBox.Show("User Added Successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void Delete_User_Click(object sender, EventArgs e)
        {
            int index = Reg_Users_ListBox.SelectedIndex;

            Data_Manger.Entities.RemoveAt(index);
            Data_Manger.Users.RemoveAt(index);
            Data_Manger.SaveData();

            Reg_Users_ListBox.DataSource = null;
            Reg_Users_ListBox.DataSource = Data_Manger.Users;
            MessageBox.Show("User Removed Successfully!");
        }
    }
}
