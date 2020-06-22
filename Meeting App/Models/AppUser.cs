
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Meeting_App.Models
{

using System;
    using System.Collections.Generic;
    
public partial class AppUser
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AppUser()
    {

        this.Attendances = new HashSet<Attendance>();

    }


    public int AppUserID { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Initials { get; set; }

    public string Prefix { get; set; }

    public string Suffix { get; set; }

    public string LoginName { get; set; }

    public string Password { get; set; }

    public Nullable<System.DateTime> DisabledDate { get; set; }

    public Nullable<int> LoginAttemptsCount { get; set; }

    public Nullable<System.DateTime> AgreedToLicenseDate { get; set; }

    public string SpecialOption { get; set; }

    public bool IsActive { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string CellPhone { get; set; }

    public string Fax { get; set; }

    public string AppUserNote { get; set; }

    public string SortNameFirstLast { get; set; }

    public string SortNameLastFirst { get; set; }

    public string DisplayName { get; set; }

    public int CreatedByID { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public int ModifiedByID { get; set; }

    public System.DateTime ModifiedDate { get; set; }

    public Nullable<int> RoleId { get; set; }



    public virtual AppUser AppUser1 { get; set; }

    public virtual AppUser AppUser2 { get; set; }

    public virtual Role Role { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Attendance> Attendances { get; set; }

}

}
