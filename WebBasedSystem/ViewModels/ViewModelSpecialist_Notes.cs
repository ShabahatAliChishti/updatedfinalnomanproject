using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBasedSystem.ViewModels
{
    public class ViewModelSpecialist_Notes
    {
       public IEnumerable<NotesModel> noteslist {get;set;}
        public IEnumerable<SpecialistModel> specialistlist { get; set; }

    }
}