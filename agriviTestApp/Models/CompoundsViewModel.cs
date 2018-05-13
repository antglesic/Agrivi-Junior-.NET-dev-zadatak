using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace agriviTestApp.Models
{
    public class CompoundsViewModel
    {
        public int idSpoja { get; set; }
        public string nazivSpoja { get; set; }
        public int vodik { get; set; }
        public int ugljik { get; set; }
        public int dusik { get; set; }
        public int natrij { get; set; }
        public int kisik { get; set; }
    }
}