using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.data.models
{
    public class Department :BaseeEntity
    {
        public string name { get; set; }
        public string code { get; set; }

        public ICollection<Employee> Employees { get; set; }=new List<Employee>();

    }
}
