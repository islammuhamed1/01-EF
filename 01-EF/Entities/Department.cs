using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
