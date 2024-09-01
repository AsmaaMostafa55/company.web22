using company.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.repositry.repositres
{
    public interface IEmployeeRepository
    {

        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void DeleteById(int id);
        
      


    }
}
