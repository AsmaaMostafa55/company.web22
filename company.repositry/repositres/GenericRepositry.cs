using company.data.models;
using company.data.models.Contexts;
using company.repositry.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.repositry.repositres
{
    public class GenericRepositry<T> : IGenericRepositrycs<T> where T : BaseeEntity
    {
        private readonly CompanyDbContext _context;
        public GenericRepositry(CompanyDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
       =>_context.Set<T>().Add(entity);

        public void Delete(T entity)
       => _context.Set<T>().Remove(entity);

        public IEnumerable<T> GetAll()
         => _context.Set<T>().ToList();
        public T GetById(int id)
       => _context.Set<T>().Find();

        public void Update(T entity)
       => _context.Set<T>().Update(entity);
    }
}
