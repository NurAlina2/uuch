//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhoto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
