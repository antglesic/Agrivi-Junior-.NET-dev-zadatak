//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace agriviTestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Spojevi
    {
        public int idSpoja { get; set; }
        [Required(ErrorMessage = "You need to enter a compound name!")]
        public string nazivSpoja { get; set; }
        public int vodik { get; set; }
        public int ugljik { get; set; }
        public int dusik { get; set; }
        public int natrij { get; set; }
        public int kisik { get; set; }

    }
}
