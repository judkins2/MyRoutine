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
      
        public Boolean Complete { get; set; }

        public Routine Routine { get; set; }

        public int RoutineID { get; set; }
        [Column(TypeName="Date")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime CompleteDate { get; set; }
    }
}


//[StringLength(100)]