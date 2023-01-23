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
        private bool enterForAdmin = false; // нужно для разделения авторизации сотрудников и читателей
        private Service service;

        public LoginForm()
        {
            InitializeComponent();

            // создание объекта класс Service для аботы приложения, добавление надписей в поля ввода
            service = new Service();
            idTextBox.Text = "Номер билета";
            passwordTextBox.Text = "Пароль";
        }

        // кнопка выхода
        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        // кнопка сворачивания
        private void collapseLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // отчищение поля ввода пароля
        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.ForeColor = Color.Black;
        }

        // отчищение поля ввода читательского билета или id
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

        // создание возможности перемещения окна по экрану
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

        // функции до следующего комментария нужны для визуальных эффектов на форме при наведение курсора
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

        // кнопка входа
        private void enterButton_Click(object sender, EventArgs e)
        {
            string idText = this.idTextBox.Text;
            string password = this.passwordTextBox.Text;
            int id = -1;
            try
            {
                id = Convert.ToInt32(idText);
                service.UserLogin(id, password);
                MessageBox.Show(User.activeUser.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
