using System;

namespace TaskPlacer
{
    public class TaskComponent
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public TaskComponent(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }

        public static TaskComponent Empty => new TaskComponent(0,NullDateTime.Null,NullDateTime.Null);
    }
}