using company.data.models;
using company.repositry.repositres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.repositry.interfaces
{
    public interface IEmployeeRepositry: IGenericRepositrycs<Employee>
    {
        //Employee GetById(int id);
        //IEnumerable<Employee> GetAll();
        //void Add(Employee employee);
        //void Update(Employee employee);
        //void Delete(Employee employee);
        Employee GetEmployeeByNAme(string name);
        IEnumerable<Employee> GetEmployeesByAddress(string address);
    }
}
