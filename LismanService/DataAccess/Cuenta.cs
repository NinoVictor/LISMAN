//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuenta()
        {
            this.Partida = new HashSet<Partida>();
        }
    
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string key_confirmation { get; set; }
        public string fecha_registro { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Historial Historial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partida> Partida { get; set; }
        public virtual Mensaje Mensaje { get; set; }
    }
}