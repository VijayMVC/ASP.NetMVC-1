//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAnnouncement
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public int RoleId { get; set; }
        public System.DateTime CreateDatetime { get; set; }
    
        public virtual tblDistrict tblDistrict { get; set; }
        public virtual tblRole tblRole { get; set; }
    }
}
