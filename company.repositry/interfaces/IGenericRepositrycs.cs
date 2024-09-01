using company.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.repositry.interfaces
{
    public interface IGenericRepositrycs<T> where T : BaseeEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T T);
        void Update(T T);
        void Delete(T T);
    }
}
