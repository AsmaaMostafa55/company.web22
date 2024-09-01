using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.data.models
{
    public class BaseeEntity
    {
        public int id { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public bool isdeleted { get; set; }

    }
}
