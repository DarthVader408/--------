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
    public partial class PassWords : Form
    {
        private static PassWords f;

        public static PassWords fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new PassWords();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        public PassWords()
        {
            InitializeComponent();
        }

        private void паролиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.паролиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forTimpDataSet);

        }

        private void PassWords_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet2.Пароли". При необходимости она может быть перемещена или удалена.
            this.паролиTableAdapter1.Fill(this.forTimpDataSet2.Пароли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forTimpDataSet.Пароли". При необходимости она может быть перемещена или удалена.
            this.паролиTableAdapter.Fill(this.forTimpDataSet.Пароли);

        }
    }
}
