//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityTest2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News1()
        {
            this.Comments = new HashSet<Comment>();
            this.Comment1 = new HashSet<Comment1>();
        }
    
        public int newsId { get; set; }
        public string uniqueTitle { get; set; }
        public string newsTitle { get; set; }
        public Nullable<System.DateTime> newsDate { get; set; }
        public Nullable<System.TimeSpan> newsTime { get; set; }
        public string author { get; set; }
        public int sourceId { get; set; }
        public int categoryId { get; set; }
        public string origUrl { get; set; }
        public string picUrl { get; set; }
        public string newsContent { get; set; }
        public Nullable<int> numOfClicks { get; set; }
        public Nullable<int> numOfLikes { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Source Source { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment1> Comment1 { get; set; }
    }
}