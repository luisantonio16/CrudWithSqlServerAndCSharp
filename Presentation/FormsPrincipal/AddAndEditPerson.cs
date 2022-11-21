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
    public partial class AddAndEditPerson : Form
    {
        private ModelPerson person = new ModelPerson();
        public bool Save =false;
       
        public AddAndEditPerson()
        {
            InitializeComponent();
        }

        private void AddAndEditPerson_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (valid() == true)
            {
                SaveAndEdit();
            }
            else
            {
                MessageBox.Show("Error, Warinig");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearTxt();
        }

        private bool valid()
        {
            if (TxtFirstName.Text == "") { MessageBox.Show("The FirstName is incorrect"); return false; }
            if (TxtLastName.Text == "") { MessageBox.Show("The LastName is incorrect"); return false; }
            if (TxtDirection.Text == "") { MessageBox.Show("The Direction is incorrect"); return false; }

            if (CmbCountry.SelectedIndex == -1) { MessageBox.Show("The Country is incorrect"); return false; }
            if (CmbCity.SelectedIndex == -1) { MessageBox.Show("The Country is incorrect"); return false; }

            return true;

        }

        private void SaveAndEdit()
        {
            try
            {
                if (Save==false)
                {
                    person.Lastname = TxtLastName.Text;
                    person.Firtname = TxtFirstName.Text;
                    person.Country = CmbCountry.Text;
                    person.City = CmbCity.Text;
                    person.Phone = TxtPhone.Text;
                    person.State = "Active";
                    person.Direction = TxtDirection.Text;

                    string confirm = person.SaveChanged();
                    FrmSucces succes = new FrmSucces();
                    succes.LblTitle.Text = confirm;
                    succes.ShowDialog();
                    ClearTxt();
                }
                else if(Save == true)
                {
                    person.stateEntity = StateEntity.edit;
                    person.Id = Convert.ToInt32(LblId.Text);
                    person.Firtname = TxtFirstName.Text;
                    person.Lastname = TxtLastName.Text;
                    person.Country = CmbCountry.Text;
                    person.City = CmbCity.Text;
                    person.Phone = TxtPhone.Text;
                    person.Direction = TxtDirection.Text;
                    person.State = "Active";

                    string confirm = person.SaveChanged();
                    FrmSucces succes = new FrmSucces();
                    succes.LblTitle.Text = confirm;
                    succes.ShowDialog();
                    Save = false;
                    Close();
                }
               
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void ClearTxt()
        {
            TxtDirection.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtPhone.Text = "";
            CmbCity.SelectedIndex = -1;
            CmbCountry.SelectedIndex = -1;
        }
    }
}
