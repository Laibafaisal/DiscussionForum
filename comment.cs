//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debatron_v9
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        public int Comment_ID { get; set; }
        public string CommentContent { get; set; }
        public System.DateTime Date { get; set; }
        public int User_ID { get; set; }
        public int Post_ID { get; set; }
    
        public virtual post post { get; set; }
        public virtual user user { get; set; }
    }
}