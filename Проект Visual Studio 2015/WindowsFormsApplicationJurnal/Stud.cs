using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationJurnal
{
    public partial class Stud : Form
    {
        private static Stud f;

        public static Stud fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Stud();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public Stud()
        {
            InitializeComponent();
        }

        private void Stud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter.Fill(this.forTimpDataSet2.Предмет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.forTimpDataSet2.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter1.Fill(this.forTimpDataSet2.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter1.Fill(this.forTimpDataSet2.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet1.Группы". При необходимости она может быть перемещена или удалена.
           // this.группыTableAdapter.Fill(this.forTimpDataSet2.Группы);

        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forTimpDataSet1);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // dataGridViewSelect.DataSource = FillDataGridView("SELECT Группа, Фамилия, Имя, Отчество, Оценка FROM Группы, Пользователи WHERE id_группы=id_пользователя");
        }

        private object FillDataGridView(string v)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, ФБ, Данное приложение было разработано в ознакомительных целях, разработчики: Попадинец Руслан и Никитин Иван, группа 723, 2015", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
