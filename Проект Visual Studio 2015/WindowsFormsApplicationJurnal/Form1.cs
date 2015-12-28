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
using WindowsFormsApplicationJurnal.Properties;

namespace WindowsFormsApplicationJurnal
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void паролиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.паролиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forTimpDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet1.Пароли". При необходимости она может быть перемещена или удалена.
            this.паролиTableAdapter1.Fill(this.forTimpDataSet1.Пароли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            // this.пользователиTableAdapter.Fill(this.forTimpDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Пароли". При необходимости она может быть перемещена или удалена.
            //  this.паролиTableAdapter.Fill(this.forTimpDataSet.Пароли);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QOUTPOQ\SQLEXPRESS;Initial Catalog=ForTimp;Integrated Security=True");
            //  SqlConnection sda = new SqlConnection("Select Count(*) From Пароли Where Логин= '" + textBoxLogin.Text + "' and Пароль '" + textBoxPassword.Text + "'", connection);
            //   DataTable dt = new DataTable();
            //   sda.Fill(dt);
            if (textBoxLogin.Text == "EVA" && textBoxPassword.Text == "eva")
            {
                MessageBox.Show("Преподаватель");

                Ticher.fw.ShowForm();
            }
            else
            {
                MessageBox.Show("Студент");

                Stud.fw.ShowForm();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassWords.fw.ShowForm();
        }
    }
}
