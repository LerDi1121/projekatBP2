//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInterfaceWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Takes
    {
        public int Id_Takes { get; set; }
        public int Won_points { get; set; }
        public System.DateTime Start_time { get; set; }
        public System.DateTime Completion_time { get; set; }
        public System.DateTime Date_of_taking { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual Registered Registered { get; set; }
        public virtual Mark Marks { get; set; }
    }
}
