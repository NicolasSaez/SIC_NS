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
    
    public partial class PERMISSIONS
    {
        public PERMISSIONS()
        {
            this.ROLES = new HashSet<ROLES>();
        }
    
        public int PermissionId { get; set; }
        public string PermissionDescription { get; set; }
        public Nullable<long> IdSubMenu { get; set; }
        public Nullable<long> IdModulo { get; set; }
    
        public virtual ICollection<ROLES> ROLES { get; set; }
        public virtual Modulo Modulo { get; set; }
        public virtual SubMenus SubMenus { get; set; }
    }
}