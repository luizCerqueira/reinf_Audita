using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IDAO<T> where T: class
    {
        bool Save(T entidade, string Banco, int Id);

        bool Delete(T entidade, string Banco);

        bool Update(T entidade, string Banco);

    }
}
