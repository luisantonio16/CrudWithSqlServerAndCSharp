using System;
using System.Windows.Forms;
using Domain.Model;
using Domain.ObjectValues;
using Presentation.FormsSecundary;

namespace Presentation.FormsPrincipal
{
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private ModelPerson person = new ModelPerson();

        private ModelPerson modelPerson = new ModelPerson();

    

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            listPersonas();
            MoveColumns();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void listPersonas()
        {
            try
            {
                DataListado.DataSource = modelPerson.GetAll();
                DataListado.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MoveColumns()
        {
            try
            {
                DataListado.Columns["Edit"].DisplayIndex = 5;
                DataListado.Columns["Delete"].DisplayIndex = 5;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataListado.DataSource = modelPerson.Find(guna2TextBox1.Text.Trim());
                DataListado.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnNewPerson_Click(object sender, EventArgs e)
        {
            AddAndEditPerson addAndEditPerson = new AddAndEditPerson();
            addAndEditPerson.ShowDialog();
            listPersonas();
        }

        private void DataListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataListado.Rows[e.RowIndex].Cells["Edit"].Selected)
            {
                AddAndEditPerson addAndEditPerson = new AddAndEditPerson();
                addAndEditPerson.Save = true;
                addAndEditPerson.LblId.Text = DataListado.CurrentRow.Cells["Id"].Value.ToString();
                addAndEditPerson.TxtNombre.Text = DataListado.CurrentRow.Cells["Nombre1"].Value.ToString();
                addAndEditPerson.TxtFecha.Value = Convert.ToDateTime(DataListado.CurrentRow.Cells["Fecha1"].Value.ToString());

                addAndEditPerson.ShowDialog();
                listPersonas();

            }
            else if (DataListado.Rows[e.RowIndex].Cells["Delete"].Selected)
            {
                Form mensage = new FrmWarning();
                DialogResult result = mensage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    person.stateEntity = StateEntity.Delete;
                    person.Id = Convert.ToInt32(DataListado.CurrentRow.Cells["id"].Value.ToString());
                    string resultado = person.SaveChanged();
                    listPersonas();

                }
            }
        }
    }
}
