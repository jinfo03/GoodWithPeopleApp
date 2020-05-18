using System;
using System.Collections.Generic;

namespace GoodWithPeopleMainUI.Models
{
    public partial class Note
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long TopicId { get; set; }
        public DateTime Date { get; set; }
        public short State { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
