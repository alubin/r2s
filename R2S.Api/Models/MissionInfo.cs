//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace R2S.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MissionInfo
    {
        public int MissionID { get; set; }
        public string MissionName { get; set; }
        public Nullable<System.DateTime> MissionReportDate { get; set; }
        public Nullable<System.DateTime> MissionEndDate { get; set; }
        public Nullable<int> RequirementInfoID { get; set; }
    
        public virtual RequirementInfo RequirementInfo { get; set; }
    }
}
