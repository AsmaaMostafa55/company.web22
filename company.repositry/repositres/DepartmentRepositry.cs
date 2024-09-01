using company.data.models;
using company.data.models.Contexts;
using company.repositry.interfaces;

namespace company.repositry.repositres
{
    public class DepartmentRepositry : GenericRepositry<Department>, IDepartmentRepositry
    {

        private readonly CompanyDbContext _context;

        public DepartmentRepositry(CompanyDbContext context) : base(context)
        {
            {
                _context = context;
            }
            //public void Add(Department department)

            //  => _context.Add(department);


            //public void Delete(Department department)
            //=>            _context.Remove(department);


            //public void DeleteById(int id)  
            //{
            //    throw new NotImplementedException();
            //}

            //public IEnumerable<Department> GetAll() => _context.Departments.ToList();

            //public Department GetById(int id) => _context.Departments.Find(id);

            //public void Update(Department department)
            //{
            //    _context.Update(department);
            //}


        }
    }
}