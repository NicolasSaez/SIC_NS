//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modulo
    {
        public Modulo()
        {
            this.PERMISSIONS = new HashSet<PERMISSIONS>();
            this.SubMenus = new HashSet<SubMenus>();
        }
    
        public long Id { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<PERMISSIONS> PERMISSIONS { get; set; }
        public virtual ICollection<SubMenus> SubMenus { get; set; }
    }
}
