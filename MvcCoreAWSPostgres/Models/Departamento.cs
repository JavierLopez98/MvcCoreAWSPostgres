using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPostgres.Models
{
    [Table("dept")]
    public class Departamento
    {
        [Key]
        [Column("dept_no")]
        public int Dept_no { get; set; }
        [Column("Dnombre")]
        public String Dnombre { get; set; }
        [Column("Loc")]
        public String Loc { get; set; }
    }
}
