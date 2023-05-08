using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess.Contract
{
    public interface IRepositorieGeneric<Entity> where Entity : class
    {

        int Add(Entity entity);
        int Edit(Entity entity);
        int Delete(int idpk);

        IEnumerable<Entity> GetAll();
    }
}
