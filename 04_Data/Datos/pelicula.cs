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
    
    public partial class pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pelicula()
        {
            this.frase = new HashSet<frase>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_actor { get; set; }
        public Nullable<int> id_director { get; set; }
        public Nullable<int> id_genero { get; set; }
        public Nullable<int> id_companyia { get; set; }
        public string titulo { get; set; }
        public string añolanzamiento { get; set; }
        public string sinopsis { get; set; }
        public string premios { get; set; }
        public string duracion { get; set; }
        public string clasificacion { get; set; }
        public string presupuesto { get; set; }
        public string recaudacion { get; set; }
    
        public virtual actor actor { get; set; }
        public virtual companyia companyia { get; set; }
        public virtual director director { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<frase> frase { get; set; }
        public virtual genero genero { get; set; }
    }
}
