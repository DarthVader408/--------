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
    public partial class Ticher : Form
    {
        private static Ticher f;

        public static Ticher fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Ticher();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public Ticher()
        {
            InitializeComponent();
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forTimpDataSet);

        }

        private void Ticher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter1.Fill(this.forTimpDataSet2.Предмет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter1.Fill(this.forTimpDataSet2.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter1.Fill(this.forTimpDataSet2.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.СГП". При необходимости она может быть перемещена или удалена.
            //  this.сГПTableAdapter.Fill(this.forTimpDataSet.СГП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Предмет". При необходимости она может быть перемещена или удалена.
            //  this.предметTableAdapter.Fill(this.forTimpDataSet.Предмет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            //this.пользователиTableAdapter.Fill(this.forTimpDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Группы". При необходимости она может быть перемещена или удалена.
            // this.группыTableAdapter.Fill(this.forTimpDataSet.Группы);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
