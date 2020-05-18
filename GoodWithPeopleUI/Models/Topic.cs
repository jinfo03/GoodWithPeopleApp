using System;
using System.Collections.Generic;

namespace GoodWithPeopleMainUI.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Note = new HashSet<Note>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Note> Note { get; set; }
    }
}
