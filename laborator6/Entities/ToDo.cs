using System;

namespace laborator6.Entities
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public bool IsDone { get; set; } = false;
    }
}
