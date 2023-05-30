using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public  class Empleado
    {
       public String fullName { get; set; }
       public String department { get; set; }
      public  String age { get; set; }
        public Empleado() { }
        public Empleado(String fullName, String department, String age)
        {
            this.fullName = fullName;
            this.department = department;
            this.age = age;

        }
    }
}
