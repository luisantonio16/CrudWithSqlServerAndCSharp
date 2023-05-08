using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contract;
using DataAccess.Entity;
using DataAccess.Repository;
using Domain.ObjectValues;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class ModelPerson
    {
        private int id;
        private string Nombre;
        private DateTime Fecha;
        private string estadoPersona;

        private List<ModelPerson> listPersons;
        private IRepositoriePerson repositoriePerson;
       
        //creamos este campo del objeto estado entidad y ponemos su propiedad get privada,
        //para que el valor de la clase solo sea obtenido desde la clase.
        public StateEntity stateEntity { private get; set; }
        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string EstadoPersona { get => estadoPersona; set => estadoPersona = value; }

        public ModelPerson()
        {
            repositoriePerson = new RepositoriePerson();
        }

        public string SaveChanged()
        {

            string mensaje = null;

            try
            {
                var PersonDataModels = new Person();
                PersonDataModels.id = id;
                PersonDataModels.Nombre = Nombre;
                PersonDataModels.Fecha = Fecha;
                PersonDataModels.estadoPersona = estadoPersona;
             


                switch (stateEntity)
                {
                    case StateEntity.Add:
                        repositoriePerson.Add(PersonDataModels);
                        mensaje = " Added Successfully";
                        break;
                    case StateEntity.edit:
                        repositoriePerson.Edit(PersonDataModels);
                        mensaje = " Edit Successfully";
                        break;

                    case StateEntity.Delete:
                        repositoriePerson.Delete(id);
                        mensaje = "Delete Successfully";
                        break;
                   
                }

            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();   
            }
            return mensaje;

        }

        public List<ModelPerson> GetAll()
        {
            var PersonDataModels = repositoriePerson.GetAll();
            listPersons = new List<ModelPerson>();
            foreach (Person item in PersonDataModels)
            {
                listPersons.Add(new ModelPerson
                {
                    id = item.id,
                    Nombre = item.Nombre,
                    Fecha = item.Fecha,
                    estadoPersona =item.estadoPersona
                });
            }
            return listPersons;
        }

        //Filtro del tipo Interfaz Enumerable que tiene la entidad modelo persona y un parametro de tipo string.
        //este metodo devuelve una lista del modelo de persona.
        public IEnumerable<ModelPerson> Find(string find)
        {
            return listPersons.FindAll(p => p.Nombre.Contains(find));
        }
    }
}
