
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
    
public partial class Meeting_Note
{

    public int MeetingNotesID { get; set; }

    public string MeetingNotes { get; set; }

    public string MeetingNotes_Description { get; set; }

    public string project_Name { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<int> Status { get; set; }

    public string LoginName { get; set; }

    public Nullable<int> MeetingID { get; set; }



    public virtual Meeting Meeting { get; set; }

}

}
