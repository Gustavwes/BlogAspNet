using System;
using System.Collections.Generic;

namespace BlogAspNet.Models
{
    public partial class Inlägg
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Rubrik { get; set; }
        public string Inlägg1 { get; set; }
    }
}
