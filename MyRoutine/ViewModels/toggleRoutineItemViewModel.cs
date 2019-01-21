using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRoutine.Models
{
    public class toggleRoutineItemViewModel
    {
        public List<Routine> RoutineList { get; set; }
        public RoutineItem routineItem { get; set; }
    }
}