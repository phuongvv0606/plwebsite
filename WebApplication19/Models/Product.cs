//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication19.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Prices { get; set; }
        public string SeoUrl { get; set; }
        public string SortDesc { get; set; }
        public string Descriptions { get; set; }
        public string ImagesPreview { get; set; }
        public Nullable<int> Status { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> Pioriti { get; set; }
        public Nullable<int> CateId { get; set; }
        public Nullable<bool> HomePage { get; set; }
    }
}
