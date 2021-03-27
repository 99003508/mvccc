using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Batch
    {
        public int BatchID { get; set; }
        [StringLength(50)]
        public string BatchName { get; set; }
        [StringLength(3)]
        public string BatchLocation { get; set; }
        public bool BatchStatus { get; set; }
    }
}
