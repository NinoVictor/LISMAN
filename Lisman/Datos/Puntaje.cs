//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puntaje
    {
        public int idPuntaje { get; set; }
        public int idJugador { get; set; }
        public Nullable<int> puntaje_historia { get; set; }
        public Nullable<int> victorias_multijugador { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
