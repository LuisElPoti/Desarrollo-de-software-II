//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperCarros
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductComment
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string Email { get; set; }
        public string Datails { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
