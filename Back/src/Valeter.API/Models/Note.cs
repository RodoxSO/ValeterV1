using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public DateTime NoteDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string NoteContent { get; set; }
    }
}