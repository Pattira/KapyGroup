﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class kapymvc1Entities : DbContext
{
    public kapymvc1Entities()
        : base("name=kapymvc1Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionRecord> ActionRecords { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<News1> News1 { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User_Category> User_Category { get; set; }

    public virtual DbSet<User_Source> User_Source { get; set; }

    public virtual DbSet<Comment1> Comment1 { get; set; }

    public virtual DbSet<AspNetUser_Category> AspNetUser_Category { get; set; }

}

}

