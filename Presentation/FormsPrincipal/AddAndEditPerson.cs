using System;
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
            if (TxtNombre.Text == "") { MessageBox.Show("The FirstName is incorrect"); return false; }
            return true;

        }

        private void SaveAndEdit()
        {
            try
            {
                if (Save==false)
                {
          
                    person.Nombre1 = TxtNombre.Text;
                    person.Fecha1 = TxtFecha.Value;
                    person.EstadoPersona = "Activo";
                  

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
                    person.Nombre1 = TxtNombre.Text;
                    person.Fecha1 = TxtFecha.Value;
               

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
            TxtNombre.Text = "";
        }
    }
}
