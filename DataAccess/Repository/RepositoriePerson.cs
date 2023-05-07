using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contract;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public class RepositoriePerson:RepositorieMaster,IRepositoriePerson
    {
        private string insert;
        private string edit;
        private string delete;
        private string select;

        public RepositoriePerson()
        {
            select = "select * from persona where estadoPersona = 'Activo'";
            insert = "INSERT INTO persona VALUES(@nombre,@fecha,@estado)";
            edit = "UPDATE persona SET nombre=@nombre,fechaNacimiento=@fecha WHERE idPersona =@idperson";
            delete = "UPDATE persona SET estadoPersona='eliminado' WHERE idPersona =@idperson";
        }

        public int Add(Person entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@estado", entity.estadoPersona));
            return ExecuteNonQuery(insert);
        }

        public int Delete(int idpk)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idperson", idpk));
            return ExecuteNonQuery(delete);
        }

        public int Edit(Person entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idperson", entity.id));
            parameters.Add(new SqlParameter("@nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@fecha", entity.Fecha));
            return ExecuteNonQuery(edit);
        }

       

        public IEnumerable<Person> GetAll()
        {
            var ResultadoTabla = ExecuteReader(select);
            var listperson = new List<Person>();
            foreach (DataRow item in ResultadoTabla.Rows)
            {
                listperson.Add(new Person
                {

                    id = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Fecha = Convert.ToDateTime(item[2].ToString()),
                       estadoPersona = item[3].ToString(),


                });

            }
            return listperson;
        }
    }
}
