//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COLLINSWEBSHOOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Product_Type Product_Types { get; set; }
    }
}