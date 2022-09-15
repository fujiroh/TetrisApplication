using System;

namespace TaskPlacer
{
    public partial class MasterTask
    {
        public int Id { get; set; }
        public int ProductionCost { get; set; }
        public DateTime? Executable { get; set; }
        public DateTime? DeadLine { get; set; }

        public MasterTask(int id, int productionCost, DateTime executable, DateTime deadLine)
        {
            Id = id;
            Executable = executable;
            DeadLine = deadLine;
            ProductionCost = productionCost;
        }

        public bool HasExecutable()
        {
            return Executable != NullDateTime.Null;
        }

        public bool HasDeadLine()
        {
            return DeadLine != NullDateTime.Null;
        }
    }
}