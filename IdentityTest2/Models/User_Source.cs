
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
    
public partial class User_Source
{

    public int userId { get; set; }

    public int sourceId { get; set; }

    public int subscribeId { get; set; }

    public byte[] subscribeTime { get; set; }



    public virtual AspNetUser AspNetUser { get; set; }

    public virtual Source Source { get; set; }

    public virtual User User { get; set; }

}

}
