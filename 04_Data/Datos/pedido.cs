//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04_Data.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido
    {
        public int id { get; set; }
        public Nullable<int> id_tipo_pago { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual tipo_pago tipo_pago { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
