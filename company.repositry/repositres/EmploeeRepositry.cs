using company.data.models;
using company.data.models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.repositry.repositres
{
    public class EmploeeRepositry : GenericRepositry<Employee>, IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmploeeRepositry(CompanyDbContext context) : base(context)
        {
            {
                _context = context;
            }
            //public void Add(Employee employee)
            //{
            //    _context.Employees.Add(employee);
            //}

            //public void Delete(Employee employee)
            //{
            //    _context.Remove(employee);
            //}

            //public void DeleteById(int id)
            //{
            //    throw new NotImplementedException();
            //}

            //public IEnumerable<Employee> GetAll() => _context.Employees.ToList();

            //public Employee GetById(int id) => _context.Employees.Find(id);

            //public void Update(Employee employee)
            //{
            //    _context.Update(employee);
            //}
        }

        public Employee GetEmployeeByName(string name)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Employee> GetEmployeeByAddress(string Address)
        {
            throw new NotImplementedException();
        }
    }
}