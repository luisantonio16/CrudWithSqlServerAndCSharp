using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            listPersons();
            MoveColumns();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void listPersons()
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
                DataListado.Columns["Edit"].DisplayIndex = 9;
                DataListado.Columns["Delete"].DisplayIndex = 9;

                DataListado.Columns["state"].Visible = false;
                DataListado.Columns["Id"].Visible = false;
                DataListado.Columns["Phone"].Visible = false;
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
            listPersons();
        }

        private void DataListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataListado.Rows[e.RowIndex].Cells["Edit"].Selected)
            {
                AddAndEditPerson addAndEditPerson = new AddAndEditPerson();
                addAndEditPerson.Save = true;
                addAndEditPerson.LblId.Text = DataListado.CurrentRow.Cells["id"].Value.ToString();
                addAndEditPerson.TxtFirstName.Text = DataListado.CurrentRow.Cells["firtname"].Value.ToString();
                addAndEditPerson.TxtLastName.Text = DataListado.CurrentRow.Cells["lastName"].Value.ToString();
                addAndEditPerson.TxtDirection.Text = DataListado.CurrentRow.Cells["direction"].Value.ToString();
                addAndEditPerson.TxtPhone.Text = DataListado.CurrentRow.Cells["phone"].Value.ToString();
                addAndEditPerson.CmbCity.Text = DataListado.CurrentRow.Cells["city"].Value.ToString();
                addAndEditPerson.CmbCountry.Text = DataListado.CurrentRow.Cells["country"].Value.ToString();
                addAndEditPerson.ShowDialog();
                listPersons();

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
                    listPersons();

                }
            }
        }
    }
}
