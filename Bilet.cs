//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Kurs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bilet()
        {
            this.seans = new HashSet<seans>();
        }
    
        public int Id_bilet { get; set; }
        public int polzovatelId_polzovatel { get; set; }
    
        public virtual polzovatel polzovatel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seans> seans { get; set; }
    }
}
