using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Module
    {
        public int ModuleID { get; set; }
        [StringLength(50)]
        public string ModuleName { get; set; }
        [StringLength(50)]
        public string ModuleDuration { get; set; }
        public int TrackID { get; set; }
        public byte[] ModuleSyllabus { get; set; }
        public bool ModelStatus { get; set; }
    }
}
