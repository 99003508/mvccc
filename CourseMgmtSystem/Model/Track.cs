using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Track
    {
        public int TrackID { get; set; }
        [StringLength(50)]
        public string TrackName { get; set; }
        [StringLength(200)]
        public string TrackDescription { get; set; }
        public bool TrackStatus { get; set; }
        public int BatchID { get; set; }
        [StringLength(50)]
        public string TrackDuration { get; set; }
    }
}
