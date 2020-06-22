
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
    
public partial class Meeting
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Meeting()
    {

        this.Action_Item = new HashSet<Action_Item>();

        this.Comments = new HashSet<Comment>();

        this.Decision_Item = new HashSet<Decision_Item>();

        this.Meeting_Notes = new HashSet<Meeting_Note>();

        this.Attendances = new HashSet<Attendance>();

    }


    public int MeetingID { get; set; }

    public string project_Name { get; set; }

    public string Meeting_Subject { get; set; }

    public string Meeting_objective { get; set; }

    public string Agenda { get; set; }

    public string Agenda_SubItem { get; set; }

    public Nullable<System.DateTime> MeetingDate { get; set; }

    public string MeetingTime { get; set; }

    public string MeetingAssignedTo { get; set; }

    public string reoccrence { get; set; }

    public string Meeting_Location { get; set; }

    public string Partipatents { get; set; }

    public string Share_Link { get; set; }

    public Nullable<int> Status { get; set; }

    public string HostUser { get; set; }

    public string Conclusion { get; set; }

    public Nullable<long> RoomKey { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Action_Item> Action_Item { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Comment> Comments { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Decision_Item> Decision_Item { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Meeting_Note> Meeting_Notes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Attendance> Attendances { get; set; }

}

}
