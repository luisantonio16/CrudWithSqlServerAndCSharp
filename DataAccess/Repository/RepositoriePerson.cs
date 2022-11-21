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
            select = "select * from Person where stateperson = 'Active'";
            insert = "INSERT INTO Person VALUES(@fistname,@lastname,@country,@city,@direction,@phone,@state)";
            edit = "UPDATE Person SET fistName=@fistname,lastName=@lastname,country=@country,city=@city,direction=@direction,phone=@phone, stateperson=@state WHERE idPerson =@idperson";
            delete = "UPDATE Person SET stateperson='delete' WHERE idPerson =@idperson";
        }

        public int Add(Person entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@fistname", entity.fistName));
            parameters.Add(new SqlParameter("@lastname", entity.lastName));
            parameters.Add(new SqlParameter("@country", entity.country));
            parameters.Add(new SqlParameter("@city", entity.city));
            parameters.Add(new SqlParameter("@direction", entity.direction));
            parameters.Add(new SqlParameter("@phone", entity.phone));
            parameters.Add(new SqlParameter("@state", entity.status));
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
            parameters.Add(new SqlParameter("@fistname", entity.fistName));
            parameters.Add(new SqlParameter("@lastname", entity.lastName));
            parameters.Add(new SqlParameter("@country", entity.country));
            parameters.Add(new SqlParameter("@city", entity.city));
            parameters.Add(new SqlParameter("@direction", entity.direction));
            parameters.Add(new SqlParameter("@phone", entity.phone));
            parameters.Add(new SqlParameter("@state", entity.status));
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
                    fistName = item[1].ToString(),
                    lastName = item[2].ToString(),
                    country = item[3].ToString(),
                    city = item[4].ToString(),
                    direction = item[5].ToString(),
                    phone = item[6].ToString(),
                    status = item[7].ToString(),
                    
                });

            }
            return listperson;
        }
    }
}
