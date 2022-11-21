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

namespace Domain.Model
{
    public class ModelPerson
    {
        private int id;
        private string firtname;
        private string lastname;
        private string country;
        private string city;
        private string direction;
        private string phone;
        private string state;

        private List<ModelPerson> listPersons;
        private IRepositoriePerson repositoriePerson;
       
        public StateEntity stateEntity { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Firtname { get => firtname; set => firtname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Phone { get => phone; set => phone = value; }
        public string State { get => state; set => state = value; }

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
                //ArticulosDataModels.idArticulo = idArticulo;
                PersonDataModels.id = id;
                PersonDataModels.fistName = firtname;
                PersonDataModels.lastName = lastname;
                PersonDataModels.country = country;
                PersonDataModels.city = city;
                PersonDataModels.direction = direction;
                PersonDataModels.phone = phone;
                PersonDataModels.status = state;
             


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
                    firtname = item.fistName,
                    lastname = item.lastName,
                    country = item.country,
                    city = item.city,
                    direction = item.direction,
                    phone = item.phone,
                    state = item.status,
                });
            }
            return listPersons;
        }

        public IEnumerable<ModelPerson> Find(string find)
        {
            return listPersons.FindAll(p => p.firtname.Contains(find) || p.lastname.Contains(find) || p.country.Contains(find) || p.phone.Contains(find));
        }
    }
}
