using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morozava_210is_model4.Forms
{
    public partial class ProvisorForm : Form
    {
        public ProvisorForm()
        {
            InitializeComponent();
        }

        private void sotrydnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrydnikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1AptekaDataSet);

        }

        private void ProvisorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1AptekaDataSet.sotrydniki". При необходимости она может быть перемещена или удалена.
            this.sotrydnikiTableAdapter.Fill(this._1AptekaDataSet.sotrydniki);

        }

        private void buttonProvisor_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            Close();
        }
    }
}
