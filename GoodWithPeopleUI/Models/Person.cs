using System;
using System.Collections.Generic;

namespace GoodWithPeopleMainUI.Models
{
    public partial class Person
    {
        public Person()
        {
            Note = new HashSet<Note>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Note> Note { get; set; }
    }
}
