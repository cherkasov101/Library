using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private bool enterForAdmin = false; //
        private Login login;

        public LoginForm()
        {
            InitializeComponent();

            //
            login = new Login();
            idTextBox.Text = "Номер билета";
            passwordTextBox.Text = "Пароль";
        }

        //
        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //
        private void collapseLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.ForeColor = Color.Black;
        }

        //
        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text = "";
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 
                10.2F, 
                System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, 
                ((byte)(0)));
            this.idTextBox.ForeColor = Color.Black;
        }

        //
        Point lastPoint;

        private void loginFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            this.exitLabel.ForeColor = Color.FromArgb((byte)115, (byte)241, (byte)220);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            this.exitLabel.ForeColor = Color.White;
        }

        private void collapseLabel_MouseEnter(object sender, EventArgs e)
        {
            this.collapseLabel.ForeColor =  Color.FromArgb((byte)115, (byte)241, (byte)220);
        }

        private void collapseLabel_MouseLeave(object sender, EventArgs e)
        {
            this.collapseLabel.ForeColor= Color.White;
        }

        private void adminEnterLabel_MouseEnter(object sender, EventArgs e)
        {
            this.adminEnterLabel.ForeColor = Color.FromArgb((byte)115, (byte)241, (byte)220);
        }

        private void adminEnterLabel_MouseLeave(object sender, EventArgs e)
        {
            this.adminEnterLabel.ForeColor= Color.White;
        }

        private void registrationLabel_MouseEnter(object sender, EventArgs e)
        {
            this.registrationLabel.ForeColor = Color.FromArgb((byte)115, (byte)241, (byte)220);
        }

        private void registrationLabel_MouseLeave(object sender, EventArgs e)
        {
            this.registrationLabel.ForeColor= Color.White;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string idText = this.idTextBox.Text;
            string password = this.passwordTextBox.Text;
            int id = -1;
            try
            {
                id = Convert.ToInt32(idText);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод");
            }
            login.AdminLogin(id, password);
            MessageBox.Show(Admin.activeAdmin.Name);
        }
    }
}
