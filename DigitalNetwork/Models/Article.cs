//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.User_Articles = new HashSet<User_Articles>();
        }
    
        public int serial_no { get; set; }
        public int a_id { get; set; }
        public string url { get; set; }
        public bool status { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string photo_url { get; set; }
        public System.DateTime modified_date { get; set; }
        public string site_url { get; set; }
        public string category { get; set; }
        public string sub_category { get; set; }
        public bool custom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Articles> User_Articles { get; set; }
        public virtual Site Site { get; set; }
    }
}
