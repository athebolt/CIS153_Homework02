//==============================================================
//Name: Alex Thebolt
//Date: 2-27-2024
//Desc: User Registration - Admin side user registration system.
//==============================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw02_AlexanderThebolt
{
    public partial class Form1 : Form
    {
        private User[] users = new User[3];

        public Form1()
        {
            InitializeComponent();

            //hide other screen of elements
            isRegisterScreen(false);

            lbl_error.Visible = false;

            InitList();
            
        }

        private void InitList()
        {
            //predefined users
            users[0] = new User("bbob", "billy", "bob", "bbob@example.com", "asdfasdf");
            users[1] = new User("athebolt", "alex", "thebolt", "athebolt@my.monroeccc.edu", "h9mO2j23!");
            users[2] = new User("zmoore", "zack", "moore", "zmoore@monroeccc.edu", "password");

            lb_users.BeginUpdate();

            for (int i = 0; i <= users.Count() - 1; i++)
            {
                lb_users.Items.Add("Username: " + users[i].getUsername());
                lb_users.Items.Add("Firstname: " + users[i].getFName());
                lb_users.Items.Add("Lastname: " + users[i].getLName());
                lb_users.Items.Add("Email: " + users[i].getEmail());
                lb_users.Items.Add("Password: " + users[i].getPassword());
                
                //spacing
                lb_users.Items.Add("");
            }

            lb_users.EndUpdate();
        }

        private void addUserToList()
        {
            User[] temp = users;

            users = new User[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                users[i] = temp[i];
            }

            users[users.Length - 1] = new User(tb_username.Text.ToString(), tb_fName.Text.ToString(), tb_lName.Text.ToString(), tb_email.Text.ToString(), tb_password.Text.ToString());

            lb_users.BeginUpdate();

            lb_users.Items.Add("Username: " + users[users.Length - 1].getUsername());
            lb_users.Items.Add("Firstname: " + users[users.Length - 1].getFName());
            lb_users.Items.Add("Lastname: " + users[users.Length - 1].getLName());
            lb_users.Items.Add("Email: " + users[users.Length - 1].getEmail());
            lb_users.Items.Add("Password: " + users[users.Length - 1].getPassword());

            lb_users.Items.Add("");

            lb_users.EndUpdate();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //toggles visibility
            isRegisterScreen(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            isRegisterScreen(false);

            clearTextboxes();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(isValidInfo())
            {
                //add new user in list
                addUserToList();

                isRegisterScreen(false);

                clearTextboxes();
            }
            else
            {
                lbl_error.Visible = true;
            }
        }

        private void clearTextboxes()
        {
            tb_username.Text = "";
            tb_fName.Text = "";
            tb_lName.Text = "";
            tb_email.Text = "";
            tb_password.Text = "";
            tb_passConf.Text = "";
        }

        private bool isValidInfo()
        {
            //make sure all fields are filled
            if(tb_username.Text.ToString() != "" && tb_email.Text.ToString() != "" && tb_fName.Text.ToString() != "" && tb_lName.Text.ToString() != "" && tb_password.Text.ToString() != "" && tb_passConf.Text.ToString() != "")
            {
                //make sure that the username is unique
                for(int i = 0; i < users.Count() - 1; i++)
                {
                    if(tb_username.Text.ToString() == users[i].getUsername())
                    {
                        //error: non unique username
                        lbl_error.Text = "ERROR: Non unique username.";

                        return false;
                    }
                }

                //valid password
                if(tb_password.Text.ToString().Count() >= 8)
                {
                    bool hasNum = false;

                    for (int i = 0; i < tb_password.Text.Count(); i++)
                    {
                        if(tb_password.Text.ToString().ElementAt(i) >= '0' && tb_password.Text.ToString().ElementAt(i) <= '9')
                        {
                            hasNum = true;
                        }
                    }

                    if (hasNum)
                    {
                        //password matches password confirm
                        if (tb_password.Text.ToString() == tb_passConf.Text.ToString())
                        {
                            //valid info

                            return true;
                        }

                        //password and password confirm do not match
                        lbl_error.Text = "ERROR: Password must match Password Confirm";

                        return false;
                    }
                }

                //invalid password, needs 8 characters and 1 number
                lbl_error.Text = "ERROR: Password needs to be at least 8 charaters long and contain 1 number.";

                return false;
            }
            else
            {
                //error: not all fields filled in
                lbl_error.Text = "ERROR: Please fill in all fields.";

                return false;
            }
        }

        private void isRegisterScreen(bool v)
        {
            if (v)
            {
                btn_register.Visible = false;
                lb_users.Visible = false;

                lbl_username.Visible = true;
                tb_username.Visible = true;
                lbl_fName.Visible = true;
                tb_fName.Visible = true;
                lbl_lName.Visible = true;
                tb_lName.Visible = true;
                lbl_email.Visible = true;
                tb_email.Visible = true;
                lbl_password.Visible = true;
                tb_password.Visible = true;
                lbl_passConf.Visible = true;
                tb_passConf.Visible = true;

                btn_back.Visible = true;
                btn_confirm.Visible = true;
            }
            else
            {
                btn_register.Visible = true;
                lb_users.Visible = true;

                lbl_username.Visible = false;
                tb_username.Visible = false;
                lbl_fName.Visible = false;
                tb_fName.Visible = false;
                lbl_lName.Visible = false;
                tb_lName.Visible = false;
                lbl_email.Visible = false;
                tb_email.Visible = false;
                lbl_password.Visible = false;
                tb_password.Visible = false;
                lbl_passConf.Visible = false;
                tb_passConf.Visible = false;
                lbl_error.Visible = false;

                btn_back.Visible = false;
                btn_confirm.Visible = false;
            }
        }
    }
}
