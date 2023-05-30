using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class EmpleadoInformatico:Empleado
    {
        public List<string> LenguajeDeProgramacion { get; set; }
        public String EstadoCivil { get; set; }
        public EmpleadoInformatico() { }
        public EmpleadoInformatico( String fullName, String department, String age, String EstadoCivil)
            :base(fullName,department,age)
        {
            this.EstadoCivil = EstadoCivil;
            LenguajeDeProgramacion = new List<string>();
        }

    }
}
