using System;
using System.Windows.Forms;

namespace Presentation.FormsSecundary
{
    public partial class FrmWarning : Form
    {
        public FrmWarning()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
