using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyRoutine.Models
{
    public class RoutineItem
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public byte Complete { get; set; }

        public Routine Routine { get; set; }

        public int RoutineID { get; set; }
    }
}


//[StringLength(100)]