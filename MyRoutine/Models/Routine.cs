using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyRoutine.Models
{
    public class Routine
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string RoutineName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime CreateDate { get; set; }

        public Boolean Complete { get; set; }

        public DateTime? CompleteDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FinalizedDate { get; set; }

    }
}