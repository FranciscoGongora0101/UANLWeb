//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UANL_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facultad
    {
        public Facultad()
        {
            this.Alumno = new HashSet<Alumno>();
        }
    
        public int id_Facultad { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaCreacion { get; set; }
    
        public virtual ICollection<Alumno> Alumno { get; set; }
    }
}
